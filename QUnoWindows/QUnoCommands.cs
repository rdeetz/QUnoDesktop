// <copyright file="QUnoCommands.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno
{
    using System.Windows.Input;
    using Mooville.QUno.Properties;

    public static class QUnoCommands
    {
        private static RoutedUICommand options =
            new RoutedUICommand(Resources.CommandOptions, "Options", typeof(QUnoCommands));

        private static RoutedUICommand checkForUpdates =
            new RoutedUICommand(Resources.CommandCheckForUpdates, "CheckForUpdates", typeof(QUnoCommands));

        private static RoutedUICommand getUpdate = 
            new RoutedUICommand(Resources.CommandGetUpdate, "GetUpdate", typeof(QUnoCommands));

        private static RoutedUICommand about =
            new RoutedUICommand(Resources.CommandAbout, "About", typeof(QUnoCommands));

        private static RoutedUICommand addPlayer =
            new RoutedUICommand(Resources.CommandAddPlayer, "AddPlayer", typeof(QUnoCommands));

        private static RoutedUICommand removePlayer =
            new RoutedUICommand(Resources.CommandRemovePlayer, "RemovePlayer", typeof(QUnoCommands));

        private static RoutedUICommand startGame =
            new RoutedUICommand(Resources.CommandStartGame, "StartGame", typeof(QUnoCommands));

        private static RoutedUICommand playCard =
            new RoutedUICommand(Resources.CommandPlayCard, "PlayCard", typeof(QUnoCommands));

        private static RoutedUICommand drawCard =
            new RoutedUICommand(Resources.CommandDrawCard, "DrawCard", typeof(QUnoCommands));

        private static RoutedUICommand takeTurn =
            new RoutedUICommand(Resources.CommandDrawCard, "TakeTurn", typeof(QUnoCommands));

        public static RoutedUICommand Options
        {
            get
            {
                return QUnoCommands.options;
            }
        }

        public static RoutedUICommand CheckForUpdates
        {
            get
            {
                return QUnoCommands.checkForUpdates;
            }
        }

        public static RoutedUICommand GetUpdate
        {
            get
            {
                return QUnoCommands.getUpdate;
            }
        }

        public static RoutedUICommand About
        {
            get
            {
                return QUnoCommands.about;
            }
        }

        public static RoutedUICommand AddPlayer
        {
            get
            {
                return QUnoCommands.addPlayer;
            }
        }

        public static RoutedUICommand RemovePlayer
        {
            get
            {
                return QUnoCommands.removePlayer;
            }
        }

        public static RoutedUICommand StartGame
        {
            get
            {
                return QUnoCommands.startGame;
            }
        }

        public static RoutedUICommand PlayCard
        {
            get
            {
                return QUnoCommands.playCard;
            }
        }

        public static RoutedUICommand DrawCard
        {
            get
            {
                return QUnoCommands.drawCard;
            }
        }

        public static RoutedUICommand TakeTurn
        {
            get
            {
                return QUnoCommands.takeTurn;
            }
        }
    }
}
