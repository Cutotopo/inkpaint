using ControlzEx.Theming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace InkPaint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Thickness15Item.IsSelected = true;
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("HH:mm:ss");
        }

        private void DeleteCanvas(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("La tavola verrà eliminata. Continuare?", "InkPanel", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    InkPanel.Strokes.Clear();

                    break;
                case MessageBoxResult.No:
                    break;
            }
            String timeStamp = GetTimestamp(DateTime.Now);
            LatestEvent.Text = "New canvas";
            LatestEventTime.Text = "1 second ago";
            var timer4 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            var timer2 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            var timerend = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
            timer4.Start();
            timer4.Tick += (sender, args) =>
            {
                timer4.Stop();
                LatestEventTime.Text = "2 seconds ago";
            };
            timer3.Start();
            timer3.Tick += (sender, args) =>
            {
                timer3.Stop();
                LatestEventTime.Text = "3 seconds ago";
            };
            timer2.Start();
            timer2.Tick += (sender, args) =>
            {
                timer2.Stop();
                LatestEventTime.Text = "4 seconds ago";
            };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                LatestEventTime.Text = "5 seconds ago";
            };
            timerend.Start();
            timerend.Tick += (sender, args) =>
            {
                timerend.Stop();
                LatestEventTime.Text = timeStamp;
            };
        }

        private void AppShutdown(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Thickness15D(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Width = 5;
            InkPanel.DefaultDrawingAttributes.Height = 5;
            Thickness15Item.IsSelected = true;
        }

        private void Thickness10(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Width = 1;
            InkPanel.DefaultDrawingAttributes.Height = 1;
        }

        private void Thickness15(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Width = 5;
            InkPanel.DefaultDrawingAttributes.Height = 5;
        }

        private void Thickness20(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Width = 10;
            InkPanel.DefaultDrawingAttributes.Height = 10;
        }

        private void Thickness25(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Width = 15;
            InkPanel.DefaultDrawingAttributes.Height = 15;
        }

        private void Thickness30(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Width = 20;
            InkPanel.DefaultDrawingAttributes.Height = 20;
        }

        private void Thickness35(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Width = 25;
            InkPanel.DefaultDrawingAttributes.Height = 25;
        }

        private void Thickness40(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Width = 30;
            InkPanel.DefaultDrawingAttributes.Height = 30;
        }

        private void Thickness45(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Width = 35;
            InkPanel.DefaultDrawingAttributes.Height = 35;
        }

        private void Thickness50(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Width = 40;
            InkPanel.DefaultDrawingAttributes.Height = 40;
        }
        private void Thickness55(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Width = 45;
            InkPanel.DefaultDrawingAttributes.Height = 45;
        }

        private void Thickness60(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Width = 50;
            InkPanel.DefaultDrawingAttributes.Height = 50;
        }
        private void Thickness65(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Width = 55;
            InkPanel.DefaultDrawingAttributes.Height = 55;
        }

        private void ColoreNero(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void ColoreRosso(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void ColoreVerde(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void ColoreBlu(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void ColoreGiallo(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void Gomma(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void Evidenzia(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.IsHighlighter = true;
        }

        private void NoEvidenzia(object sender, RoutedEventArgs e)
        {
            InkPanel.DefaultDrawingAttributes.IsHighlighter = false;
        }

        private void ZoomIn(object sender, RoutedEventArgs e)
        {
            Matrix m = new Matrix();
            m.Scale(1.1d, 1.1d);
            ((InkCanvas)InkPanel).Strokes.Transform(m, true);

        }

        private void ZoomOut(object sender, RoutedEventArgs e)
        {
            Matrix m = new Matrix();
            m.Scale(0.9d, 0.9d);
            ((InkCanvas)InkPanel).Strokes.Transform(m, true);
        }
        private void OpenBeta(object sender, RoutedEventArgs e)
        {
            InkPaintWindow window = new InkPaintWindow();
            window.Show();
        }


    }
}
