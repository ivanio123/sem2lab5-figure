using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace sem2lab5_
{
    public class Rhomb : Figure
    {
        private double diagHor { get; set; }
        private double diagvert { get; set; }

        public Rhomb() { }
       
        public Rhomb(int x, int y, double diagHor, double diagvert)
        {
            this.x = x;
            this.y = y;
            this.diagHor = diagHor;
            this.diagvert = diagvert;
        }

        public override void DrawBlack(Panel p)
        {
            try
            {
                using (var g = Graphics.FromImage(p.BackgroundImage))
                {

                    Rectangle rhomb = new Rectangle(x, y, (int)diagHor, (int)diagvert);
                    using (Matrix matrix = new Matrix())
                    {
                        matrix.RotateAt(45, new PointF(rhomb.Left + (rhomb.Width / 2), rhomb.Top + (rhomb.Height / 2)));

                        g.Transform = matrix;
                        g.DrawRectangle(Pens.Black, rhomb);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            
        }
        public override void HideDrawingBackGround(Panel p)
        {
            try
            {
                using (var g = Graphics.FromImage(p.BackgroundImage))
                {
                    Rectangle rhomb = new Rectangle(x, y, (int)diagHor, (int)diagvert);
                    using (Matrix matrix = new Matrix())
                    {
                        matrix.RotateAt(45, new PointF(rhomb.Left + (rhomb.Width / 2), rhomb.Top + (rhomb.Height / 2)));


                        g.Transform = matrix;
                        g.DrawRectangle(Pens.White, rhomb);

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
