// <copyright file="MainViewModel.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno.Windows.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows.Data;
    using Mooville.QUno.Model;
    using Mooville.QUno.Properties;
    using Mooville.QUno.ViewModel;
    using Mooville.QUno.Windows.Model;

    public class MainViewModel : ViewModelBase
    {
        private Game game;
        private IGameSerializer gameSerializer;
        private ObservableCollection<Player> computerPlayers;
        private ListCollectionView computerPlayersView;
        private string title;
        private bool isGameNotYetStarted;
        private ObservableCollection<LogEntry> log;
        private ListCollectionView logView;
        private int logIndex;

        public MainViewModel()
            : this(new StandardGameSerializer())
        {
        }

        public MainViewModel(IGameSerializer gameSerializer)
        {
            if (gameSerializer == null)
            {
                throw new ArgumentNullException("gameSerializer");
            }

            this.game = new Game(); // This prevents NRE during the initial data binding calls, but might not be the best idea.
            this.gameSerializer = gameSerializer;
            this.computerPlayers = new ObservableCollection<Player>();
            this.computerPlayersView = new ListCollectionView(this.computerPlayers);
            this.title = Resources.StatusDefault;
            this.isGameNotYetStarted = true;
            this.log = new ObservableCollection<LogEntry>();
            this.logView = new ListCollectionView(this.log);
            this.logView.SortDescriptions.Add(new SortDescription("Index", ListSortDirection.Descending));
            this.logIndex = 0;
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
                this.OnPropertyChanged("Title");
            }
        }

        public Direction CurrentDirection
        {
            get
            {
                return this.game.CurrentDirection;
            }
        }

        public Color? CurrentWildColor
        {
            get
            {
                return this.game.Deck.CurrentWildColor;
            }
        }

        public Card CurrentCard
        {
            get
            {
                return this.game.Deck.CurrentCard;
            }
        }

        public int DiscardPileSize
        {
            get
            {
                return this.game.Deck.DiscardPile.Count;
            }
        }

        public int DrawPileSize
        {
            get
            {
                return this.game.Deck.DrawPile.Count;
            }
        }

        public ICollectionView ComputerPlayers
        {
            get
            {
                return this.computerPlayersView;
            }
        }

        public Player HumanPlayer
        {
            get
            {
                return this.game.Players.FirstOrDefault(p => p.IsHuman);
            }
        }

        public IList<Player> Players
        {
            get
            {
                return this.game.Players;
            }
        }

        public Player CurrentPlayer
        {
            get
            {
                return this.game.CurrentPlayer;
            }
        }

        public bool IsGameInProgress
        {
            get
            {
                bool isGameInProgress = false;

                if (this.game != null)
                {
                    if (!this.IsGameNotYetStarted)
                    {
                        if (!this.IsGameOver())
                        {
                            isGameInProgress = true;
                        }
                    }
                }

                return isGameInProgress;
            }
        }

        public bool IsGameNotYetStarted
        {
            get
            {
                return this.isGameNotYetStarted;
            }

            set
            {
                this.isGameNotYetStarted = value;
                this.OnPropertyChanged("IsGameNotYetStarted");
            }
        }

        public ICollectionView Log
        {
            get
            {
                return this.logView;
            }
        }

        public void StartGame(IEnumerable<Player> players)
        {
            if (players == null)
            {
                throw new ArgumentNullException("players");
            }

            this.ResetGame();
            this.ResetLog();
            this.Title = Resources.StatusGameInProgress;
            this.IsGameNotYetStarted = false;

            this.game = new Game();
            this.game.PlayerChanged += new EventHandler(this.Game_PlayerChanged);

            foreach (var player in players)
            {
                this.game.Players.Add(player);

                if (!player.IsHuman)
                {
                    this.computerPlayers.Add(player);
                }
            }

            this.game.Deal();

            return;
        }

        public bool CanPlayCard(Card card)
        {
            if (card != null)
            {
                if (this.IsGameInProgress)
                {
                    return this.game.CanPlay(card);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void PlayCard(Card card)
        {
            if (card == null)
            {
                throw new ArgumentNullException("card");
            }

            if (this.IsGameInProgress)
            {
                Player player = this.game.CurrentPlayer;

                this.RecordTurn(player, card, null, LogMode.Play);
                player.Hand.Cards.Remove(card);
                this.game.PlayCard(card);
            }

            return;
        }

        public void PlayCard(Card card, Color? wildColor)
        {
            if (card == null)
            {
                throw new ArgumentNullException("card");
            }

            if (this.IsGameInProgress)
            {
                Player player = this.game.CurrentPlayer;

                this.RecordTurn(player, card, wildColor, LogMode.WildPlay);
                player.Hand.Cards.Remove(card);
                this.game.PlayCard(card, wildColor);
            }

            return;
        }

        public void DrawCard()
        {
            if (this.IsGameInProgress)
            {
                Player player = this.game.CurrentPlayer;

                this.RecordTurn(player, null, null, LogMode.Draw); // I don't like passing null for the card here, but it's easier for now.
                Card card = this.game.DrawCard();
                player.Hand.Cards.Add(card);
            }

            return;
        }

        public void TakeTurn()
        {
            if (this.IsGameInProgress)
            {
                this.TakeNextTurn();
            }

            return;
        }

        public void OpenGame(string fileName)
        {
            if (String.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }

            this.ResetGame();
            this.ResetLog();
            this.Title = Resources.StatusGameInProgress;
            this.IsGameNotYetStarted = false;

            this.game = this.gameSerializer.Load(fileName);
            this.game.PlayerChanged += new EventHandler(this.Game_PlayerChanged);

            foreach (var player in this.game.Players)
            {
                if (!player.IsHuman)
                {
                    this.computerPlayers.Add(player);
                }
            }
            
            this.OnPropertyChanged(String.Empty);

            return;
        }

        public void SaveGame(string fileName)
        {
            if (String.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }

            if (this.IsGameInProgress)
            {
                this.gameSerializer.Save(this.game, fileName);
            }

            return;
        }

        private void ResetGame()
        {
            if (this.game != null)
            {
                this.game.PlayerChanged -= new EventHandler(this.Game_PlayerChanged);
                this.game = null;
            }

            this.computerPlayers.Clear();

            return;
        }

        private void ResetLog()
        {
            this.log.Clear();
            this.logIndex = 0;

            return;
        }

        private void RecordTurn(Player player, Card card, Color? wildColor, LogMode mode)
        {
            string message = String.Empty;

            switch (mode)
            {
                case LogMode.Play:
                    message = String.Format(Resources.LogMessagePlay,  player.Name, card.ToString());
                    break;

                case LogMode.WildPlay:
                    message = String.Format(Resources.LogMessageWildPlay, player.Name, card.Value.ToString(), wildColor.ToString());
                    break;

                case LogMode.Draw:
                    message = String.Format(Resources.LogMessageDraw, player.Name);
                    break;
            }

            this.logIndex++;
            LogEntry logEntry = new LogEntry() { Message = message, Index = this.logIndex };
            this.log.Add(logEntry);

            return;
        }

        private void TakeNextTurn()
        {
            Player player = this.game.CurrentPlayer;

            if (!player.IsHuman)
            {
                Card cardToPlay = this.ChooseCardToPlay(player);

                if (cardToPlay != null)
                {
                    if (cardToPlay.Color == Color.Wild)
                    {
                        Color wildColor = this.ChooseWildColor(player);
                        this.RecordTurn(player, cardToPlay, wildColor, LogMode.WildPlay);
                        this.game.PlayCard(cardToPlay, wildColor);
                    }
                    else
                    {
                        this.RecordTurn(player, cardToPlay, null, LogMode.Play);
                        this.game.PlayCard(cardToPlay);
                    }
                }
                else
                {
                    this.RecordTurn(player, null, null, LogMode.Draw);
                    Card cardToDraw = this.game.DrawCard();
                    player.Hand.Cards.Add(cardToDraw);
                }
            }

            return;
        }

        private Card ChooseCardToPlay(Player player)
        {
            return player.ChooseCardToPlay(this.game);
        }

        private Color ChooseWildColor(Player player)
        {
            return player.ChooseWildColor();
        }

        private bool IsGameOver()
        {
            return this.game.IsGameOver;
        }

        private Player FindWinner()
        {
            // This will return null if it is called before the game is over.
            return this.game.Players.FirstOrDefault(p => p.Hand.Cards.Count == 0);
        }

        private void Game_PlayerChanged(object sender, EventArgs e)
        {
            this.OnPropertyChanged(String.Empty);

            if (!this.IsGameOver())
            {
                this.TakeNextTurn();
            }
            else
            {
                // Hopefully this only ever happens when the game is actually over, 
                // otherwise we could get a NullReferenceException.
                this.OnPropertyChanged("IsGameInProgress");
                this.Title = String.Format(Resources.StatusGameOver, this.FindWinner().Name);
            }

            return;
        }

        private class LogEntry
        {
            public string Message { get; set; }
            public int Index { get; set; }
        }

        private enum LogMode
        {
            Play,
            WildPlay,
            Draw
        }
    }
}
