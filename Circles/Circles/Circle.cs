using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles
{
    public class Circle
    {
        public int radius { get; set; }
        public Point center { get; set; }
        public Color boja { get; set; }
        public bool isSelected { get; set; }

        public Circle(Point p,Color boja)
        {
            radius = 30;
            center = p;
            this.boja = boja;
            isSelected = false;
        }
        public void draw(Graphics g)
        {
            Brush b = new SolidBrush(boja);
            g.FillEllipse(b, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
            if(isSelected)
            {
                Pen p = new Pen(Color.Black);
                g.DrawEllipse(p, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
                p.Dispose();
            }
            b.Dispose();
        }
        public void select(Point p)
        {
            double distance = Math.Pow(p.X - center.X, 2) + Math.Pow(p.Y - center.Y, 2);
            if(distance <= radius*radius)
            {
                isSelected = !isSelected;
            }
        }
        public void Move()
        {
            if(isSelected)
                center = new Point(center.X + 10, center.Y);
        }
    }
}
