using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SpaceInvader
{
    internal class Gegner
    {

        public void ErstellenGegner(Canvas canvas)
        {
            var x = 0;
            var y = canvas.ActualHeight;

            for (int i = 0; i < 10; i++)
            {

                Ellipse gegner = new Ellipse();
                {
                    gegner.Width = 20;
                    gegner.Height = 20;
                    gegner.Fill = Brushes.White;
                    Canvas.SetTop(gegner, y);
                    Canvas.SetLeft(gegner, x);
                }

                canvas.Children.Add(gegner);
                x += 50;
            }
        }
        public void LoescheGegner(Canvas canvas)
        {

        }

        public void Getroffen(Canvas canvas)
        {
            var gegner1 = canvas.Children[1];

        }
    }
}
