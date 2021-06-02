
namespace BrziPrsti
{
    partial class Game
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
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wordsToGuessLabel = new System.Windows.Forms.Label();
            this.guessedWordsLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGuess
            // 
            this.tbGuess.Location = new System.Drawing.Point(16, 389);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(579, 22);
            this.tbGuess.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start typing here:";
            // 
            // wordsToGuessLabel
            // 
            this.wordsToGuessLabel.AutoSize = true;
            this.wordsToGuessLabel.Location = new System.Drawing.Point(15, 9);
            this.wordsToGuessLabel.Name = "wordsToGuessLabel";
            this.wordsToGuessLabel.Size = new System.Drawing.Size(107, 17);
            this.wordsToGuessLabel.TabIndex = 2;
            this.wordsToGuessLabel.Text = "Words to guess";
            // 
            // guessedWordsLabel
            // 
            this.guessedWordsLabel.AutoSize = true;
            this.guessedWordsLabel.Location = new System.Drawing.Point(15, 169);
            this.guessedWordsLabel.Name = "guessedWordsLabel";
            this.guessedWordsLabel.Size = new System.Drawing.Size(168, 17);
            this.guessedWordsLabel.TabIndex = 3;
            this.guessedWordsLabel.Text = "Guessed Words are here";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(493, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(102, 39);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "02:00";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 434);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(583, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(15, 512);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(583, 23);
            this.progressBar2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time left:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Guessed words";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.guessedWordsLabel);
            this.Controls.Add(this.wordsToGuessLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGuess);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wordsToGuessLabel;
        private System.Windows.Forms.Label guessedWordsLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}