// <copyright file="AboutWindow.xaml.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno
{
    using System;
    using System.ComponentModel;
    using System.Globalization;
    using System.Reflection;
    using System.Windows;

    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            this.InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                this.Loaded += new RoutedEventHandler(this.Window_Loaded);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.textVersion.Text = String.Format(CultureInfo.CurrentCulture, textVersion.Text, version.ToString());

            // TODO Once I created the QUno page on mooville.com, I can switch 
            //      the CodePlex link (below the version) to point there. 
            //      Then, I can removed the hyperlink on "Roger Deetz", and then 
            //      I can use the attributes on the assembly to populate the 
            //      copyright notice, so I only need to update it in once place.
            return;
        }
    }
}
