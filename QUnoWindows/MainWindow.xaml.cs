// <copyright file="MainWindow.xaml.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno.Windows
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using Microsoft.Win32;
    using Mooville.QUno.Model;
    using Mooville.QUno.Properties;
    using Mooville.QUno.Windows.ViewModel;

    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;

        public MainWindow()
        {
            this.InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                this.viewModel = new MainViewModel();
                this.DataContext = this.viewModel;
                this.Loaded += new RoutedEventHandler(this.Window_Loaded);
                this.listHumanHand.KeyUp += new KeyEventHandler(this.ListBox_KeyUp);
                this.listHumanHand.MouseDoubleClick += new MouseButtonEventHandler(this.ListBox_MouseDoubleClick);
                this.CommandBindings.Add(new CommandBinding(ApplicationCommands.New, this.New_Executed, this.New_CanExecute));
                this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, this.Open_Executed, this.Open_CanExecute));
                this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Save, this.Save_Executed, this.Save_CanExecute));
                this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Close, this.Close_Executed, this.Close_CanExecute));
                this.CommandBindings.Add(new CommandBinding(QUnoCommands.Options, this.Options_Executed, this.Options_CanExecute));
                this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Help, this.Help_Executed, this.Help_CanExecute));
                this.CommandBindings.Add(new CommandBinding(QUnoCommands.CheckForUpdates, this.CheckForUpdates_Executed, this.CheckForUpdates_CanExecute));
                this.CommandBindings.Add(new CommandBinding(QUnoCommands.About, this.About_Executed, this.About_CanExecute));
                this.CommandBindings.Add(new CommandBinding(QUnoCommands.PlayCard, this.PlayCard_Executed, this.PlayCard_CanExecute));
                this.CommandBindings.Add(new CommandBinding(QUnoCommands.DrawCard, this.DrawCard_Executed, this.DrawCard_CanExecute));
                this.CommandBindings.Add(new CommandBinding(QUnoCommands.TakeTurn, this.TakeTurn_Executed, this.TakeTurn_CanExecute));
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Settings.Default.AutoCheckForUpdates)
            {
                UpdateViewModel updateViewModel = new UpdateViewModel();
                this.statusBar.DataContext = updateViewModel;
                updateViewModel.CheckForUpdatesCompleted += new EventHandler(this.UpdateViewModel_CheckForUpdatesCompleted);
                updateViewModel.CheckForUpdates();
            }

            return;
        }

        private void UpdateViewModel_CheckForUpdatesCompleted(object sender, EventArgs e)
        {
            this.statusBar.ClearValue(FrameworkElement.DataContextProperty);

            return;
        }

        private void New_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

            return;
        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NewGameWindow newGameWindow = new NewGameWindow();
            newGameWindow.Owner = this;
            bool? result = newGameWindow.ShowDialog();

            if ((bool)result)
            {
                IEnumerable<Player> players = newGameWindow.Players;
                this.viewModel.StartGame(players);
            }

            return;
        }

        private void Open_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

            return;
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = Properties.Resources.FilterQUnoFiles;
            bool? result = openFileDialog.ShowDialog(this);

            if ((bool)result)
            {
                string fileName = openFileDialog.FileName;
                this.viewModel.OpenGame(fileName);
            }

            return;
        }

        private void Save_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.viewModel.IsGameInProgress;

            return;
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Filter = Properties.Resources.FilterQUnoFiles;
            bool? result = saveFileDialog.ShowDialog(this);

            if ((bool)result)
            {
                string fileName = saveFileDialog.FileName;
                this.viewModel.SaveGame(fileName);
            }

            return;
        }

        private void Close_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

            return;
        }

        private void Close_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            App.Current.Shutdown();

            return;
        }

        private void Options_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

            return;
        }

        private void Options_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OptionsWindow optionsWindow = new OptionsWindow();
            optionsWindow.Owner = this;
            optionsWindow.ShowDialog();

            return;
        }

        private void Help_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

            return;
        }

        private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Owner = this;
            helpWindow.Show();

            return;
        }

        private void CheckForUpdates_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

            return;
        }

        private void CheckForUpdates_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            UpdateWindow updateWindow = new UpdateWindow();
            updateWindow.Owner = this;
            updateWindow.ShowDialog();

            return;
        }

        private void About_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

            return;
        }

        private void About_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Owner = this;
            aboutWindow.ShowDialog();

            return;
        }

        private void PlayCard_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.viewModel.CanPlayCard(e.Parameter as Card);

            return;
        }

        private void PlayCard_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.PlayCardUI(e.Parameter as Card);

            return;
        }

        private void DrawCard_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

            return;
        }

        private void DrawCard_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.viewModel.DrawCard();

            return;
        }

        private void TakeTurn_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

            return;
        }

        private void TakeTurn_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.viewModel.TakeTurn();

            return;
        }

        private void ListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ListBox listBox = sender as ListBox;
                Card card = listBox.SelectedItem as Card;
                this.PlayCardUI(card);
            }
            else if (e.Key == Key.Space)
            {
                this.viewModel.DrawCard();
            }

            return;
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            Card card = listBox.SelectedItem as Card;
            this.PlayCardUI(card);

            return;
        }

        private void PlayCardUI(Card card)
        {
            if (this.viewModel.CanPlayCard(card))
            {
                if (card.Color == Color.Wild)
                {
                    WildColorWindow wildColorWindow = new WildColorWindow();
                    wildColorWindow.Owner = this;
                    bool? result = wildColorWindow.ShowDialog();

                    if ((bool)result)
                    {
                        Color? wildColor = wildColorWindow.SelectedColor;
                        this.viewModel.PlayCard(card, wildColor);
                    }
                }
                else
                {
                    this.viewModel.PlayCard(card);
                }
            }

            return;
        }
    }
}
