// <copyright file="DesktopSettingsProvider.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno.Windows.ViewModel
{
    using System;
    using Mooville.QUno.ViewModel;
    using Mooville.QUno.Windows.Properties;

    public class DesktopSettingsProvider : ISettingsProvider
    {
        public DesktopSettingsProvider()
        {
        }

        #region ISettingsProvider Members

        public string DefaultHumanPlayerName
        {
            get
            {
                return Settings.Default.DefaultHumanPlayerName;
            }

            set
            {
                Settings.Default.DefaultHumanPlayerName = value;
            }
        }

        public int DefaultComputerPlayers
        {
            get
            {
                return Settings.Default.DefaultComputerPlayers;
            }

            set
            {
                Settings.Default.DefaultComputerPlayers = value;
            }
        }

        public bool AutoCheckForUpdates
        {
            get
            {
                return Settings.Default.AutoCheckForUpdates;
            }

            set
            {
                Settings.Default.AutoCheckForUpdates = value;
            }
        }

        public void LoadSettings()
        {
            return;
        }

        public void SaveSettings()
        {
            Settings.Default.Save();

            return;
        }

        #endregion
    }
}
