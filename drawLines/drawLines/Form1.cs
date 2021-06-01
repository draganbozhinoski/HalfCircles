using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawLines
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
            scena.draw(e.Graphics);
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scena.addClick(e.Location);
            Invalidate();
        }
    }
}
