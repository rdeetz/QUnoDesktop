// <copyright file="UpdateWindow.xaml.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno.Windows
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Input;
    using Mooville.QUno.Windows.ViewModel;

    public partial class UpdateWindow : Window, IDisposable
    {
        private UpdateViewModel viewModel;

        public UpdateWindow()
        {
            this.InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                this.viewModel = new UpdateViewModel();
                this.DataContext = this.viewModel;
                this.CommandBindings.Add(new CommandBinding(QUnoCommands.GetUpdate, this.GetUpdate_Executed));
                this.Loaded += new RoutedEventHandler(this.UpdateWindow_Loaded);
                this.Closed += new EventHandler(this.UpdateWindow_Closed);
            }
        }

        #region IDisposable Members

        private bool disposedValue = false;

        public void Dispose()
        {
            this.Dispose(true);

            return;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.viewModel.Dispose();
                }

                disposedValue = true;
            }

            return;
        }

        #endregion

        private void GetUpdate_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Process.Start(this.viewModel.UpdateAddress);

            this.DialogResult = true;
            this.Close();

            return;
        }

        private void UpdateWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.viewModel.CheckForUpdates();

            return;
        }

        private void UpdateWindow_Closed(object sender, EventArgs e)
        {
            this.viewModel.CancelCheckForUpdates();

            return;
        }
    }
}
