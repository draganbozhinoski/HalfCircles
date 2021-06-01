using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        Scena scena;
        Color boja;
        SHAPE_TYPE currType;
        public Shape selectedShape { get; set; }
        public enum SHAPE_TYPE
        {
            CIRCLE,
            SQUARE
        };
        public Form1()
        {
            InitializeComponent();
            scena = new Scena();
            boja = Color.Red;
            currType = SHAPE_TYPE.CIRCLE;
            DoubleBuffered = true;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                boja = cd.Color;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scena.drawAll(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!scena.click(e.Location))
            {
                if (currType == SHAPE_TYPE.CIRCLE)
                    scena.addShape(new Circle(boja, e.Location));
                else
                    scena.addShape(new Square(boja, e.Location));
            }
            else
            {
                //pulse
            }
            Invalidate();
        }

        private void menuSquare_Click(object sender, EventArgs e)
        {
            currType = SHAPE_TYPE.SQUARE;
        }

        private void menuCircle_Click(object sender, EventArgs e)
        {
            currType = SHAPE_TYPE.CIRCLE;
        }

        private void menuPulse_Click(object sender, EventArgs e)
        {
            if (menuPulse.Text == "Pulse")
            {
                timer1.Start();
                menuPulse.Text = "Stop Pulsing";
            }
            else
            {
                timer1.Stop();
                menuPulse.Text = "Pulse";
            }
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scena.pulse();
            Invalidate();
        }
    }
}
