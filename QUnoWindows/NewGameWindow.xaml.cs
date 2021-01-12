// <copyright file="NewGameWindow.xaml.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno.Windows
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows;
    using System.Windows.Input;
    using Mooville.QUno.Model;
    using Mooville.QUno.Windows.Properties;
    using Mooville.QUno.Windows.ViewModel;

    public partial class NewGameWindow : Window
    {
        private DesktopNewGameViewModel viewModel;

        public NewGameWindow()
        {
            this.InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                this.viewModel = new DesktopNewGameViewModel(Settings.Default.DefaultHumanPlayerName, Settings.Default.DefaultComputerPlayers, Properties.Resources.PlayerNameTemplate);
                this.DataContext = this.viewModel;
                this.CommandBindings.Add(new CommandBinding(QUnoCommands.AddPlayer, this.AddPlayer_Executed, this.AddPlayer_CanExecute));
                this.CommandBindings.Add(new CommandBinding(QUnoCommands.RemovePlayer, this.RemovePlayer_Executed, this.RemovePlayer_CanExecute));
                this.CommandBindings.Add(new CommandBinding(QUnoCommands.StartGame, this.StartGame_Executed, this.StartGame_CanExecute));
            }
        }

        public IEnumerable<Player> Players
        {
            get
            {
                return this.viewModel.Players;
            }
        }

        private void SaveAsDefaults()
        {
            Settings.Default.DefaultHumanPlayerName = this.viewModel.HumanPlayerName;
            Settings.Default.DefaultComputerPlayers = this.viewModel.ComputerPlayers.Cast<Player>().Count();
            Settings.Default.Save();

            return;
        }

        private void AddPlayer_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.viewModel.CanAddComputerPlayer;

            return;
        }

        private void AddPlayer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.viewModel.AddComputerPlayer();

            return;
        }

        private void RemovePlayer_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.viewModel.CanRemoveComputerPlayer;

            return;
        }

        private void RemovePlayer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.viewModel.RemoveComputerPlayer(e.Parameter as Player);

            return;
        }

        private void StartGame_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.viewModel.CanStartGame;

            return;
        }

        private void StartGame_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.SaveAsDefaults(); // I'm not 100% sure I want to do this here.
            this.DialogResult = true;
            this.Close();

            return;
        }
    }
}
