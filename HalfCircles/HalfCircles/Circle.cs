using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{
    [Serializable]
    public class Circle
    {
        public float radius = 30;
        public float doubleRadius;
        public bool rasti { get; set; }
        public Point center { get; set; }
        public Color boja { get; set; }
        public Color boja2 { get; set; }
        public Circle(Point center,Color boja)
        {
            this.center = center;
            this.boja = boja;
            boja2 = Color.FromArgb(255 - boja.R, 255 - boja.G, 255 - boja.B);
            rasti = true;
            doubleRadius = radius * 2;
        }
        public void draw(Graphics g)
        {
            Brush b = new SolidBrush(boja);
            g.FillPie(b, center.X - radius, center.Y - radius, 2 * radius, 2 * radius, 0, 180);
            Brush b2 = new SolidBrush(boja2);
            g.FillPie(b2, center.X - radius, center.Y - radius, 2 * radius, 2 * radius, 180, 180);
            b.Dispose();
            b2.Dispose();
        }
        public void pulse()
        {
            if(rasti)
            {
                radius += 3;
                if(radius>=doubleRadius)
                {
                    rasti = false;
                }
            }
            else
            {
                radius -= 3;
                if(radius<=30)
                {
                    rasti = true;
                }
            }

        }

    }
}
