using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace sem2lab5_
{
    public class Square : Figure
    {
        private double side { get; set; }        

        public Square() { }

        public Square(int x, int y, double side)
        {           
            this.x = x;
            this.y = y;
            this.side = side;
        }

        public override void DrawBlack(Panel p)
        {
            try
            {
                using (Graphics g = Graphics.FromImage(p.BackgroundImage))
                {
                    g.DrawRectangle(Pens.Black, x, y, (int)side, (int)side);
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
                using (Graphics g = Graphics.FromImage(p.BackgroundImage))
                {
                    g.DrawRectangle(Pens.White, x, y, (int)side, (int)side);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            

        }
    }
}
