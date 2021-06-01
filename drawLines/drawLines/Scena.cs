using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawLines
{
    class Scena
    {
        public List<Line> lines { get; set; }
        public Point firstPoint { get; set; }

        public Scena()
        {
            lines = new List<Line>();
            firstPoint = Point.Empty;
        }
        public void addClick(Point currPoint)
        {
            if(firstPoint.IsEmpty)
            {
                firstPoint = currPoint;
            }
            else
            {
                lines.Add(new Line(1.0f,firstPoint, currPoint,Color.Red));
                firstPoint = currPoint;
            }
        }
        public void draw(Graphics g)
        {
            foreach(Line s in lines)
            {
                s.draw(g);
            }
        }
    }
}
