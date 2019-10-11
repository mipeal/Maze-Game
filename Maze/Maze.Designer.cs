namespace Maze
{
    partial class Maze
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
            this.MazePBX = new System.Windows.Forms.PictureBox();
            this.Entry2BTN = new System.Windows.Forms.Button();
            this.Entry1BTN = new System.Windows.Forms.Button();
            this.Entry4BTN = new System.Windows.Forms.Button();
            this.Entry3BTN = new System.Windows.Forms.Button();
            this.ClickTMR = new System.Windows.Forms.Timer(this.components);
            this.TimerLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MazePBX)).BeginInit();
            this.SuspendLayout();
            // 
            // MazePBX
            // 
            this.MazePBX.BackColor = System.Drawing.Color.Transparent;
            this.MazePBX.Location = new System.Drawing.Point(32, 29);
            this.MazePBX.Name = "MazePBX";
            this.MazePBX.Size = new System.Drawing.Size(720, 705);
            this.MazePBX.TabIndex = 0;
            this.MazePBX.TabStop = false;
            // 
            // Entry2BTN
            // 
            this.Entry2BTN.Location = new System.Drawing.Point(12, 726);
            this.Entry2BTN.Name = "Entry2BTN";
            this.Entry2BTN.Size = new System.Drawing.Size(75, 23);
            this.Entry2BTN.TabIndex = 1;
            this.Entry2BTN.Text = "Entry 2";
            this.Entry2BTN.UseVisualStyleBackColor = true;
            this.Entry2BTN.Click += new System.EventHandler(this.Entry2BTN_Click);
            // 
            // Entry1BTN
            // 
            this.Entry1BTN.Location = new System.Drawing.Point(12, 12);
            this.Entry1BTN.Name = "Entry1BTN";
            this.Entry1BTN.Size = new System.Drawing.Size(75, 23);
            this.Entry1BTN.TabIndex = 2;
            this.Entry1BTN.Text = "Entry 1";
            this.Entry1BTN.UseVisualStyleBackColor = true;
            this.Entry1BTN.Click += new System.EventHandler(this.Entry1BTN_Click);
            // 
            // Entry4BTN
            // 
            this.Entry4BTN.Location = new System.Drawing.Point(697, 12);
            this.Entry4BTN.Name = "Entry4BTN";
            this.Entry4BTN.Size = new System.Drawing.Size(75, 23);
            this.Entry4BTN.TabIndex = 3;
            this.Entry4BTN.Text = "Entry 4";
            this.Entry4BTN.UseVisualStyleBackColor = true;
            this.Entry4BTN.Click += new System.EventHandler(this.Entry4BTN_Click);
            // 
            // Entry3BTN
            // 
            this.Entry3BTN.Location = new System.Drawing.Point(697, 726);
            this.Entry3BTN.Name = "Entry3BTN";
            this.Entry3BTN.Size = new System.Drawing.Size(75, 23);
            this.Entry3BTN.TabIndex = 4;
            this.Entry3BTN.Text = "Entry 3";
            this.Entry3BTN.UseVisualStyleBackColor = true;
            this.Entry3BTN.Click += new System.EventHandler(this.Entry3BTN_Click);
            // 
            // ClickTMR
            // 
            this.ClickTMR.Tick += new System.EventHandler(this.ClickTMR_Tick);
            // 
            // TimerLBL
            // 
            this.TimerLBL.AutoSize = true;
            this.TimerLBL.Location = new System.Drawing.Point(363, 17);
            this.TimerLBL.Name = "TimerLBL";
            this.TimerLBL.Size = new System.Drawing.Size(0, 13);
            this.TimerLBL.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Timer";
            // 
            // Maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Maze.Properties.Resources.jack_square;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerLBL);
            this.Controls.Add(this.Entry3BTN);
            this.Controls.Add(this.Entry4BTN);
            this.Controls.Add(this.Entry1BTN);
            this.Controls.Add(this.Entry2BTN);
            this.Controls.Add(this.MazePBX);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "Maze";
            this.Text = "Maze Game";
            this.Load += new System.EventHandler(this.Maze_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Maze_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.MazePBX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MazePBX;
        private System.Windows.Forms.Button Entry2BTN;
        private System.Windows.Forms.Button Entry1BTN;
        private System.Windows.Forms.Button Entry4BTN;
        private System.Windows.Forms.Button Entry3BTN;
        private System.Windows.Forms.Timer ClickTMR;
        private System.Windows.Forms.Label TimerLBL;
        private System.Windows.Forms.Label label1;
    }
}

