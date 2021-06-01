using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        public int a = 30;
        public bool pulsing = true;
        public Square(Color boja, Point lokacija) : base(boja, lokacija)
        {

        }

        public override void draw(Graphics g)
        {
            Brush b = new SolidBrush(boja);
            g.FillRectangle(b, location.X - a / 2, location.Y - a / 2, a, a);
            if (isSelected)
            {
                Pen p = new Pen(Color.Black, 3);
                g.DrawRectangle(p, location.X - a / 2, location.Y - a / 2, a, a);
                p.Dispose();
            }
            b.Dispose();
        }

        public override bool isClicked(Point p)
        {
            Rectangle r = new Rectangle(location.X - a / 2, location.Y - a / 2, a, a);
            return r.Contains(p);
        }
        public override void pulse()
        {
            if (pulsing)
            {
                a += 2;
                if (a > 60)
                {
                    pulsing = false;
                }
            }
            else
            {
                a -= 2;
                if (a <= 20)
                {
                    pulsing = true;
                }
            }
        }
    }
}
