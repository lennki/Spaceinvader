using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SpaceInvader
{
    public class Schuss
    {
        private double X {  get; set; } 
        private double Y { get; set; }

        public void Erstellen(Canvas canvas, double x,double y)
        {

            X = x;
            Y = y;

            Rectangle schuss = new Rectangle();
            {
                schuss.Width = 5;
                schuss.Height = 10;
                schuss.Fill = Brushes.White;
                Canvas.SetTop(schuss, Y);
                Canvas.SetLeft(schuss, X);
            }
             
            canvas.Children.Add(schuss);

            Bewegen(canvas, x, y, schuss);
        }
        public void Bewegen(Canvas canvas, double x, double y, Rectangle schuss)
        {
            var dp = new DispatcherTimer();
            dp.Interval = new TimeSpan(0, 0, 0, 0, 5);
            dp.Tick += Dp_Tick;
            dp.Start();

            void Dp_Tick(object? sender, EventArgs e)
            {
                y -= 5;
                Canvas.SetTop(schuss, y);
                Canvas.SetLeft(schuss, x);

                int anzahl = canvas.Children.Count;

                for (int i = 0; i < anzahl; i++)
                {
                       if (canvas.Children[i] is Rectangle && Canvas.GetTop(canvas.Children[i]) <= 0)
                    {
                        canvas.Children.RemoveAt(i);
                    }
                }
            }
        }
    }
}
