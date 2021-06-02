using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles
{
    public class Scena
    {
        public List<Circle> circles { get; set; }

        public Scena()
        {
            circles = new List<Circle>();
        }
        public void drawAll(Graphics g)
        {
            foreach(Circle c in circles)
            {
                c.draw(g);
            }
        }
        public void addCircle(Circle s)
        {
            circles.Add(s);
        }
        public void selectAll(Point p)
        {
            foreach(Circle s in circles)
            {
                s.select(p);
            }
        }
        public void moveAll()
        {
            foreach(Circle c in circles)
            {
                c.Move();
            }
        }
    }
}
