using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movingRectangles
{
    public partial class Form1 : Form
    {
        Scena scena;
        public Form1()
        {
            InitializeComponent();
            scena = new Scena();
            DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scena.drawAll(e.Graphics);
            Invalidate();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            scena.addRectangle(new Rectangle(e.Location, Color.Red));
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //scena.Move();
                scena.select(e.Location);
                Invalidate();
            }
            if(e.Button == MouseButtons.Right)
            {
                Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
     
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            scena.rectangles.ForEach(r => r.Move());
            //scena.Move();
            Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            scena.Move();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Start")
            {
                timer.Start();
                button1.Text = "Stop";
            }
            else
            {
                button1.Text = "Start";
                timer.Stop();
            }
        }
    }
}
