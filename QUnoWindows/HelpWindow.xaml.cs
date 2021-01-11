// <copyright file="HelpWindow.xaml.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno
{
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Xps.Packaging;
    using Mooville.QUno.Properties;

    public partial class HelpWindow : Window
    {
        public HelpWindow()
        {
            this.InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                this.Loaded += new RoutedEventHandler(this.Window_Loaded);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string currentFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string helpFile = Path.Combine(currentFolder, Settings.Default.HelpFile);

            try
            {
                XpsDocument xpsDocument = new XpsDocument(helpFile, FileAccess.Read);
                this.viewer.Document = xpsDocument.GetFixedDocumentSequence();
            }
            catch (DirectoryNotFoundException)
            {
                this.ShowError();
            }
            catch (FileNotFoundException)
            {
                this.ShowError();
            }

            return;
        }

        private void ShowError()
        {
            this.viewer.IsEnabled = false;
            this.textError.Visibility = Visibility.Visible;

            return;
        }
    }
}
