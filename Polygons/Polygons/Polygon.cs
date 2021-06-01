using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    public class Polygon
    {
        public List<Point> dots { get; set; }
        public Color boja { get; set; }
        public bool isClosed { get; set; }

        public Polygon(Color boja)
        {
            this.dots = new List<Point>();
            this.boja = boja;
            this.isClosed = false;
        }
        public void addPoint(Point p)
        {
            dots.Add(p);
        }
        public void draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            Pen p = new Pen(Color.Black);
            if(isClosed)
            {
                g.FillPolygon(b,dots.ToArray());
            }
            else
            {
                g.DrawLines(p, dots.ToArray());
            }
            b.Dispose();
            p.Dispose();
        }
        public Point lastPoint { get { return dots[dots.Count - 1]; } }
    }
}
