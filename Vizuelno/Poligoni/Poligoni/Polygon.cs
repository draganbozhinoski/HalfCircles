using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligoni
{
    [Serializable]
    public class Polygon
    {
        public List<Point> points { get; set; }
        public Color boja { get; set; }
        public bool isClosed { get; set; }
        public bool nearStart { get; set; }
        public Polygon(Color boja)
        {
            points = new List<Point>();
            this.boja = boja;
            isClosed = false;
            nearStart = false;
        }
        public void addPoint(Point p)
        {
            points.Add(p);
            if (nearStart)
                isClosed = true;
        }
        public void Move(string dir)
        {
            for(int i=0;i<points.Count;i++)
            {
                if(dir=="gore")
                {
                    points[i] = new Point(points[i].X, points[i].Y - 10);
                }
                if(dir=="dole")
                {
                    points[i] = new Point(points[i].X, points[i].Y + 10);
                }
                if(dir=="levo")
                {
                    points[i] = new Point(points[i].X-10, points[i].Y);
                }
                if(dir=="desno")
                {
                    points[i] = new Point(points[i].X+10, points[i].Y);
                }
            }
        }
        public void draw(Graphics g)
        {
            if (isClosed)
            {
                Brush b = new SolidBrush(boja);
                g.FillPolygon(b, points.ToArray());
                b.Dispose();
            }
            Pen p = new Pen(Color.Black);
            if (points.Count > 1)
            {
                g.DrawLines(p, points.ToArray());
                if (nearStart)
                {
                    g.DrawRectangle(p, points[0].X - 5, points[0].Y - 5, 10, 10);
                }
            }
            p.Dispose();
        }
        public void checkIfNearStart(Point p)
        {
            Point startingPoint = points[0];
            double distance = Math.Sqrt(Math.Pow(p.X - startingPoint.X, 2) + Math.Pow(p.Y - startingPoint.Y, 2));
            if (distance < 5)
                nearStart = true;
            else
            {
                nearStart = false;
            }
        }
        public bool isEmpty()
        {
            return points.Count == 0;
        }
        public Point getLastPoint()
        {
            return points[points.Count - 1];
        }
    }
}
