using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public int radius = 20;
        public bool pulsing = true;
        public Circle(Color boja, Point location) : base(boja, location)
        {
        }

        public override void draw(Graphics g)
        {
            Brush b = new SolidBrush(boja);
            g.FillEllipse(b, location.X - radius, location.Y - radius, 2 * radius, 2 * radius);
            if (isSelected)
            {
                Pen p = new Pen(Color.Black, 3);
                g.DrawEllipse(p, location.X - radius, location.Y - radius, 2 * radius, 2 * radius);
                p.Dispose();
            }
            b.Dispose();
        }

        public override bool isClicked(Point p)
        {
            return Math.Pow(p.X - location.X, 2) + Math.Pow(p.Y - location.Y, 2) < radius * radius;
        }
        public override void pulse()
        {
            if (pulsing)
            {
                radius += 2;
                if (radius > 60)
                {
                    pulsing = false;
                }
            }
            else
            {
                radius -= 2;
                if (radius <= 20)
                {
                    pulsing = true;
                }
            }
        }
    }
}
