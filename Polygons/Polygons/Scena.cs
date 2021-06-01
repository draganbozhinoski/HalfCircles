using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    public class Scena
    {
        public List<Polygon> listaPoligoni { get; set; }
        public Color boja { get; set; }
        public Point firstPoint { get; set; }

        public Polygon currentPolygon { get; set; }
        public Point currentPoint { get; set; }
        public bool isHit { get; set; }

        public Scena(Color boja)
        {
            this.listaPoligoni = new List<Polygon>();
            this.boja = boja;
            firstPoint = Point.Empty;
            isHit = false;
        }
        public void Click(Point p)
        {
            if(firstPoint.IsEmpty)
            {
                firstPoint = p;
                currentPolygon = new Polygon(boja);
                currentPolygon.addPoint(p);
            }
            else
            {
                currentPolygon.addPoint(p);
                if(isHit)
                {
                    currentPolygon.isClosed = true;
                    listaPoligoni.Add(currentPolygon);
                    firstPoint = Point.Empty;
                    currentPolygon = null;
                }
            }
        }
        public void draw(Graphics g)
        {
            foreach(Polygon z in listaPoligoni)
            {
                z.draw(g);
            }
            if(currentPolygon != null)
            {
                if(currentPolygon.dots.Count > 1)
                {
                    currentPolygon.draw(g);
                }
            }
            if(!firstPoint.IsEmpty)
            {
                Pen p = new Pen(Color.Black,1);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawLine(p, currentPolygon.lastPoint, currentPoint);
                if(isHit)
                {
                    g.DrawEllipse(p, firstPoint.X - 5, firstPoint.Y - 5, 10, 10);
                }
                p.Dispose();
            }
        }
        public void Move(Point position)
        {
            currentPoint = position;
            isHit = false;
            if(currentPolygon != null)
            {
                if(currentPolygon.dots.Count > 1)
                {
                    isHit = distance(firstPoint, currentPoint)<= 5*5 ;
                }
            }
        }
        double distance(Point p1,Point p2)
        {
            return Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2);
        }
    }
}
