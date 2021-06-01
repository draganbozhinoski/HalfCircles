using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligoni
{
    [Serializable]
    class Scena
    {
        public List<Polygon> polygons { get; set; }
        public Polygon polygon { get; set; }
        public Point cursor { get; set; }
        public Scena()
        {
            polygons = new List<Polygon>();
            polygon = new Polygon(Color.Red);
        }
        public void updateCursor(Point p)
        {
            cursor = p;
            if(!polygon.isEmpty())
            {
                polygon.checkIfNearStart(p);
            }
        }
        public void addPoint(Point p)
        {
            polygon.addPoint(p);
            if(polygon.isClosed)
            {
                polygon.nearStart = false;
                polygons.Add(polygon);
                polygon = new Polygon(Color.Red);
            }
        }
        public void draw(Graphics g)
        {
            polygon.draw(g);
            foreach(Polygon p in polygons)
                p.draw(g);
            if(!polygon.isEmpty())
            {
                Pen p = new Pen(Color.Black);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                g.DrawLine(p, polygon.getLastPoint(), cursor);
                p.Dispose();
            }
        }
        public void movePolygons(string dir)
        {
            foreach(Polygon s in polygons)
            {
                s.Move(dir);
            }
        }
    }
}
