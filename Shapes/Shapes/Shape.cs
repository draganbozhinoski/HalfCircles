using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public Color boja { get; set; }
        public Point location { get; set; }
        public bool isSelected { get; set; }

        public Shape(Color boja, Point location)
        {
            this.boja = boja;
            this.location = location;
            isSelected = false;
        }
        public abstract void draw(Graphics g);
        public abstract bool isClicked(Point p);
        public abstract void pulse();
    }
}
