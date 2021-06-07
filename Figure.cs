using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace sem2lab5_
{
    public abstract class Figure
    {
        public int x { get; set; }
        public int y { get; set; }

        public abstract void DrawBlack(Panel f);
        public abstract void HideDrawingBackGround(Panel f);

        private Random random;
        public void MoveRight(Panel f)
        {
            random = new Random();
            int xRight = random.Next(10, 50);
            HideDrawingBackGround(f);
            x += xRight;
            DrawBlack(f);

        }
    }
}
