
namespace Shapes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPulse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.pulseTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCircle,
            this.menuSquare,
            this.menuPulse,
            this.menuColor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCircle
            // 
            this.menuCircle.Name = "menuCircle";
            this.menuCircle.Size = new System.Drawing.Size(60, 24);
            this.menuCircle.Text = "Circle";
            this.menuCircle.Click += new System.EventHandler(this.menuCircle_Click);
            // 
            // menuSquare
            // 
            this.menuSquare.Name = "menuSquare";
            this.menuSquare.Size = new System.Drawing.Size(69, 24);
            this.menuSquare.Text = "Square";
            this.menuSquare.Click += new System.EventHandler(this.menuSquare_Click);
            // 
            // menuPulse
            // 
            this.menuPulse.Name = "menuPulse";
            this.menuPulse.Size = new System.Drawing.Size(57, 24);
            this.menuPulse.Text = "Pulse";
            this.menuPulse.Click += new System.EventHandler(this.menuPulse_Click);
            // 
            // menuColor
            // 
            this.menuColor.Name = "menuColor";
            this.menuColor.Size = new System.Drawing.Size(59, 24);
            this.menuColor.Text = "Color";
            this.menuColor.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCircle;
        private System.Windows.Forms.ToolStripMenuItem menuSquare;
        private System.Windows.Forms.ToolStripMenuItem menuPulse;
        private System.Windows.Forms.ToolStripMenuItem menuColor;
        private System.Windows.Forms.Timer pulseTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

