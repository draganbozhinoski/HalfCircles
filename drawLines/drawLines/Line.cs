using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawLines
{
    class Line
    {
        public float Thickness { get; set; }
        public Point from { get; set; }
        public Point to { get; set; }
        public Color boja { get; set; }

        public Line(float thickness, Point from, Point to, Color boja)
        {
            Thickness = thickness;
            this.from = from;
            this.to = to;
            this.boja = boja;
        }
        public void draw(Graphics g)
        {
            Pen p = new Pen(boja, Thickness);
            g.DrawLine(p, from, to);
            p.Dispose();
        }
        public void move(int dx,int dy)
        {
            from = new Point(from.X + dx, from.Y + dy);
            to = new Point(to.X + dx, to.Y + dy);
        }
    }
}
