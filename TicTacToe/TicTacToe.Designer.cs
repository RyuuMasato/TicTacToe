using System;

namespace TicTacToe
{
    partial class TicTacToe
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
            this.tile1 = new System.Windows.Forms.Button();
            this.tile2 = new System.Windows.Forms.Button();
            this.tile3 = new System.Windows.Forms.Button();
            this.tile4 = new System.Windows.Forms.Button();
            this.tile5 = new System.Windows.Forms.Button();
            this.tile6 = new System.Windows.Forms.Button();
            this.tile7 = new System.Windows.Forms.Button();
            this.tile8 = new System.Windows.Forms.Button();
            this.tile9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tile1
            // 
            this.tile1.Location = new System.Drawing.Point(0, 0);
            this.tile1.Name = "tile1";
            this.tile1.Size = new System.Drawing.Size(100, 100);
            this.tile1.TabIndex = 0;
            this.tile1.UseVisualStyleBackColor = true;
            this.tile1.Click += new System.EventHandler(this.TurnPlayed);
            // 
            // tile2
            // 
            this.tile2.Location = new System.Drawing.Point(106, 0);
            this.tile2.Name = "tile2";
            this.tile2.Size = new System.Drawing.Size(100, 100);
            this.tile2.TabIndex = 1;
            this.tile2.UseVisualStyleBackColor = true;
            this.tile2.Click += new System.EventHandler(this.TurnPlayed);
            // 
            // tile3
            // 
            this.tile3.Location = new System.Drawing.Point(212, 0);
            this.tile3.Name = "tile3";
            this.tile3.Size = new System.Drawing.Size(100, 100);
            this.tile3.TabIndex = 2;
            this.tile3.UseVisualStyleBackColor = true;
            this.tile3.Click += new System.EventHandler(this.TurnPlayed);
            // 
            // tile4
            // 
            this.tile4.Location = new System.Drawing.Point(0, 106);
            this.tile4.Name = "tile4";
            this.tile4.Size = new System.Drawing.Size(100, 100);
            this.tile4.TabIndex = 3;
            this.tile4.UseVisualStyleBackColor = true;
            this.tile4.Click += new System.EventHandler(this.TurnPlayed);
            // 
            // tile5
            // 
            this.tile5.Location = new System.Drawing.Point(106, 106);
            this.tile5.Name = "tile5";
            this.tile5.Size = new System.Drawing.Size(100, 100);
            this.tile5.TabIndex = 4;
            this.tile5.UseVisualStyleBackColor = true;
            this.tile5.Click += new System.EventHandler(this.TurnPlayed);
            // 
            // tile6
            // 
            this.tile6.Location = new System.Drawing.Point(212, 106);
            this.tile6.Name = "tile6";
            this.tile6.Size = new System.Drawing.Size(100, 100);
            this.tile6.TabIndex = 5;
            this.tile6.UseVisualStyleBackColor = true;
            this.tile6.Click += new System.EventHandler(this.TurnPlayed);
            // 
            // tile7
            // 
            this.tile7.Location = new System.Drawing.Point(0, 212);
            this.tile7.Name = "tile7";
            this.tile7.Size = new System.Drawing.Size(100, 100);
            this.tile7.TabIndex = 6;
            this.tile7.UseVisualStyleBackColor = true;
            this.tile7.Click += new System.EventHandler(this.TurnPlayed);
            // 
            // tile8
            // 
            this.tile8.Location = new System.Drawing.Point(106, 212);
            this.tile8.Name = "tile8";
            this.tile8.Size = new System.Drawing.Size(100, 100);
            this.tile8.TabIndex = 7;
            this.tile8.UseVisualStyleBackColor = true;
            this.tile8.Click += new System.EventHandler(this.TurnPlayed);
            // 
            // tile9
            // 
            this.tile9.Location = new System.Drawing.Point(212, 212);
            this.tile9.Name = "tile9";
            this.tile9.Size = new System.Drawing.Size(100, 100);
            this.tile9.TabIndex = 8;
            this.tile9.UseVisualStyleBackColor = true;
            this.tile9.Click += new System.EventHandler(this.TurnPlayed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 313);
            this.Controls.Add(this.tile9);
            this.Controls.Add(this.tile8);
            this.Controls.Add(this.tile7);
            this.Controls.Add(this.tile6);
            this.Controls.Add(this.tile5);
            this.Controls.Add(this.tile4);
            this.Controls.Add(this.tile3);
            this.Controls.Add(this.tile2);
            this.Controls.Add(this.tile1);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tile1;
        private System.Windows.Forms.Button tile2;
        private System.Windows.Forms.Button tile3;
        private System.Windows.Forms.Button tile4;
        private System.Windows.Forms.Button tile5;
        private System.Windows.Forms.Button tile6;
        private System.Windows.Forms.Button tile7;
        private System.Windows.Forms.Button tile8;
        private System.Windows.Forms.Button tile9;

        public Array tiles { get; private set; }
    }
}

