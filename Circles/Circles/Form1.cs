using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circles
{
    public partial class Form1 : Form
    {
        Scena scena;
        public Form1()
        {
            InitializeComponent();
            scena = new Scena();
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            CenterToScreen();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scena.selectAll(e.Location);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scena.drawAll(e.Graphics);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            scena.addCircle(new Circle(e.Location, Color.Red));
            Invalidate();
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            scena.moveAll();
            Invalidate();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if(button1.Text == "Start")
            {
                button1.Text = "Stop";
                timerMove.Start();
            }
            else
            {
                button1.Text = "Start";
                timerMove.Stop();
            }
        }
    }
}
