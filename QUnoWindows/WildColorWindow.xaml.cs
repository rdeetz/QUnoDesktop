// <copyright file="WildColorWindow.xaml.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno
{
    using System.ComponentModel;
    using System.Windows;
    using Mooville.QUno.Model;
    using Mooville.QUno.ViewModel;

    public partial class WildColorWindow : Window
    {
        private WildColorViewModel viewModel;

        public WildColorWindow()
        {
            this.InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                this.viewModel = new WildColorViewModel();
                this.DataContext = this.viewModel;
                this.buttonOk.Click += new RoutedEventHandler(this.ButtonOk_Click);
            }
        }

        public Color? SelectedColor
        {
            get
            {
                return this.viewModel.SelectedColor;
            }
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();

            return;
        }
    }
}
