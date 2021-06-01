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

namespace HalfCircles
{
    public partial class Form1 : Form
    {
        public Scena scena;
        public Color boja { get; set; }
        string fileName;
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            fileName = null;
            scena = new Scena();
            DoubleBuffered = true;
            update();
            boja = Color.MediumPurple;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scena.drawAll(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scena.addCircle(new Circle(e.Location,boja));
            update();
            Invalidate();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if(toolStripLabel1.Text == "Старт")
            {
                toolStripLabel1.Text = "Стоп";
                timer1.Start();
            }
            else
            {
                toolStripLabel1.Text = "Старт";
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scena.pulseAll();
            Invalidate();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                boja = cd.Color;
            }    
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Init();
            Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                open(ofd.FileName);
                update();
                Invalidate();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool closed = false;
            if (fileName == null)
            {
                SaveFileDialog fd = new SaveFileDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    fileName = fd.FileName;
                }
                else { 
                    closed = true;
                }
            }
            if(!closed)
                save(fileName);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = null;
            saveToolStripMenuItem_Click(sender, e);
        }
        private void save(string Path)
        {
            using (FileStream fs = new FileStream(Path,FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, scena);
                fs.Close();
            }
        }
        private void open(string path)
        {
            using (FileStream fs = new FileStream(path,FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                scena = (Scena) formatter.Deserialize(fs);
            }
        }
        private void update()
        {
            totalLbl.Text = String.Format("Total: {0}", scena.circles.Count);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }
    }
}
