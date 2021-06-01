using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Scena
    {
        public List<Shape> shapes { get; set; }
        public Shape selectedShape { get; set; }
        public Scena()
        {
            this.shapes = new List<Shape>();
        }
        public void addShape(Shape s)
        {
            shapes.Add(s);
        }

        public void drawAll(Graphics g)
        {
            foreach(Shape s in shapes)
            {
                s.draw(g);
            }
        }
        public bool click(Point p)
        {
            foreach(Shape s in shapes)
            {
                if(s.isClicked(p))
                {
                    if(selectedShape != null)
                    {
                        selectedShape.isSelected = false;
                    }
                    s.isSelected = true;
                    selectedShape = s;
                    return true;
                }
            }
            return false;
        }
        public void pulse()
        {
            foreach(Shape s in shapes)
            {
                s.pulse();
            }
        }
    }
}
