// <copyright file="DesktopNewGameViewModel.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno.Windows.ViewModel
{
    using System;
    using System.ComponentModel;
    using System.Windows.Data;
    using Mooville.QUno.ViewModel;

    public class DesktopNewGameViewModel : NewGameViewModel, IDataErrorInfo
    {
        private ListCollectionView computerPlayersView;
        private string error = String.Empty;

        public DesktopNewGameViewModel(string humanPlayerName, int numberOfComputerPlayers, string playerNameTemplate)
            : base(humanPlayerName, numberOfComputerPlayers, playerNameTemplate)
        {
            this.computerPlayersView = new ListCollectionView(this.ComputerPlayersCollection);
        }

        #region Public Properties

        public ICollectionView ComputerPlayers
        {
            get
            {
                return this.computerPlayersView;
            }
        }

        public override bool CanRemoveComputerPlayer
        {
            get
            {
                return (this.ComputerPlayersCollection.Count > 0) && (this.computerPlayersView.CurrentItem != null);
            }
        }

        #endregion

        #region IDataErrorInfo Members

        public string Error
        {
            get
            {
                return this.error;
            }
        }

        public string this[string columnName]
        {
            get
            {
                string columnError = null;

                switch (columnName)
                {
                    case "HumanPlayerName":
                        if (String.IsNullOrWhiteSpace(this.HumanPlayerName))
                        {
                            columnError = "Enter your name.";
                        }

                        break;

                    // This block never seems to be hit; I wonder if the ListBox doesn't work with IDataErrorInfo?
                    case "ComputerPlayers":
                        if (this.ComputerPlayersCollection.Count == 0)
                        {
                            columnError = "Add at least one computer player.";
                        }

                        break;
                }

                return columnError;
            }
        }

        #endregion
    }
}
