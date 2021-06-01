using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligoni
{
    public partial class Form1 : Form
    {
        Scena scena;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            scena = new Scena();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scena.addPoint(e.Location);
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            scena.updateCursor(e.Location);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scena.draw(e.Graphics);
            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scena = new Scena();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            if(sf.ShowDialog() == DialogResult.OK)
            {
                save(sf.FileName);
            }    
        }
        private void save(string Path)
        {
            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, scena);
            }
        }
        private void open(string Path)
        {
            using (FileStream fs = new FileStream(Path,FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                scena = (Scena)formatter.Deserialize(fs);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                open(ofd.FileName);
            }
        }

        private void menuStrip1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
                scena.movePolygons("dole");
            if (e.KeyData == Keys.Up)
                scena.movePolygons("gore");
            if (e.KeyData == Keys.Left)
                scena.movePolygons("levo");
            if (e.KeyData == Keys.Right)
                scena.movePolygons("desno");
        }
    }
}
