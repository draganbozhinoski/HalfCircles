using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygons
{
    public partial class Form1 : Form
    {
        Scena scena;
        public Form1()
        {
            InitializeComponent();
            scena = new Scena(Color.Purple);
            DoubleBuffered = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scena.Click(e.Location);
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            scena.Move(e.Location);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            scena.draw(e.Graphics);
        }
    }
}
