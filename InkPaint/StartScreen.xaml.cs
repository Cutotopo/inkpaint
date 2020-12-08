using DiscordRPC;
using Fluent;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TixFactory.Discord;

namespace InkPaint
{
    /// <summary>
    /// Logica di interazione per StartScreen.xaml
    /// </summary>
    public partial class StartScreen : RibbonWindow
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InkPaintWindow inkpanel = new InkPaintWindow();
            inkpanel.Show();
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var inkpaintwin = new InkPaintWindow();
            InkPaintWindow inkpanelwin = new InkPaintWindow();
            inkpanelwin.Show();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File di FrancyINK (*.fink)|*.fink";

            if (openFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName,
                                               FileMode.Open);
                inkpaintwin.InkPanel.Strokes = new StrokeCollection(fs);
                fs.Close();
                this.Close();
            }

        }

        private void AppShutdown(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
