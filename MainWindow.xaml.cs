using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace SpaceInvader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            dp.Interval = TimeSpan.FromSeconds(2.5);
            dp.Tick += Dp_Tick;

            Gegner gegner = new Gegner();
            gegner.ErstellenGegner(canvas);
        }
        
        DispatcherTimer dp = new DispatcherTimer();

        public bool kann = true;
        void Dp_Tick(object? sender, EventArgs e)
        {
            kann = true;
            dp.Stop();
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

            var y = Canvas.GetTop(spielfigur);
            var x = Canvas.GetLeft(spielfigur);
            
            if (e.Key == Key.Up)
            {
                y -= 10;
                Canvas.SetTop(spielfigur, y);
            }
            else if (e.Key == Key.Down)
            {
                y += 10;
                Canvas.SetTop(spielfigur, y);
            }

            if (e.Key == Key.Left)
            {
                x -= 10;
                Canvas.SetLeft(spielfigur, x);
            }
            else if (e.Key == Key.Right)
            {
                x += 10;
                Canvas.SetLeft(spielfigur, x);
            }

            if(e.Key == Key.Space && kann)
            {
                Schuss schuss = new Schuss();
                schuss.Erstellen(canvas, x, y);
                kann = false;
                dp.Start();
            }
        }
    }
}