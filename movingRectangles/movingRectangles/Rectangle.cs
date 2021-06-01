using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movingRectangles
{
    public class Rectangle
    {
        public Point center { get; set; }
        public Color boja { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool isSelected { get; set; }
        public Rectangle(Point center,Color boja)
        {
            width = 100;
            height = 50;
            this.boja = boja;
            this.center = center;
            isSelected = false;
        }
        public void draw(Graphics g)
        {
            Brush b = new SolidBrush(boja);
            g.FillRectangle(b, center.X - width/2, center.Y - height/2, width, height);
            if(isSelected)
            {
                Pen p = new Pen(Color.Black);
                g.DrawRectangle(p, center.X - width / 2, center.Y - height / 2, width, height);
            }
            b.Dispose();
        }
        public void select(Point p)
        {
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(center.X - width/2, center.Y - height/2, width, height);
            if(r.Contains(p))
            {
                isSelected = true;
                
            }
        }
        public void Move()
        {
            if (isSelected)
            {
                center = new Point(center.X, center.Y + 50);
            }
        }
    }
}
