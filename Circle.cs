using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace sem2lab5_
{
    public class Circle : Figure
    {
        private double radius { get; set; }        
        private Circle(double radius) { this.radius = radius; }
        private Circle() { } 

        public Circle(int x, int y, double radius)
        {           
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void DrawBlack(Panel f)
        {
            try
            {
                using (var g = Graphics.FromImage(f.BackgroundImage))
                {
                    g.DrawEllipse(Pens.Black, x, y, (int)radius, (int)radius);
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
  
        }
        public override void HideDrawingBackGround(Panel f)
        {   
            try
            {
                using (var g = Graphics.FromImage(f.BackgroundImage))
                {
                    g.DrawEllipse(Pens.White, x, y, (int)radius, (int)radius);
                    
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            

        }
    }
}
