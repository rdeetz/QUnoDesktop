// <copyright file="OptionsWindow.xaml.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno
{
    using System.ComponentModel;
    using System.Windows;
    using Mooville.QUno.ViewModel;

    public partial class OptionsWindow : Window
    {
        private OptionsViewModel viewModel;

        public OptionsWindow()
        {
            this.InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                this.viewModel = new OptionsViewModel(new DesktopSettingsProvider());
                this.viewModel.LoadSettings();
                this.DataContext = this.viewModel;
                this.buttonOk.Click += new RoutedEventHandler(this.ButtonOk_Click);
            }
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel.SaveSettings();
            this.DialogResult = true;
            this.Close();

            return;
        }
    }
}
