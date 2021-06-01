using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movingRectangles
{
    public class Scena
    {
        public List<Rectangle> rectangles { get; set; }

        public Scena()
        {
            rectangles = new List<Rectangle>();
        }
        public void drawAll(Graphics g)
        {
            foreach(Rectangle r in rectangles)
            {
                r.draw(g);
            }
        }
        public void addRectangle(Rectangle r)
        {
            rectangles.Add(r);
        }
        public void select(Point s)
        {
            foreach(var r in rectangles)
            {
                r.select(s);
            }
        }
        public void Move()
        {
            foreach(var s in rectangles)
            {
                s.Move();
            }
        }
    }
}
