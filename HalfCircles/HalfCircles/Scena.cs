using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{
    [Serializable]
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
        public void addCircle(Circle c)
        {
            circles.Add(c);
        }
        public void pulseAll()
        {
            foreach(Circle c in circles)
            {
                c.pulse();
            }
        }
    }
}
