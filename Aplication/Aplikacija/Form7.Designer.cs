
namespace Aplikacija
{
    partial class Form7
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
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.red1 = new System.Windows.Forms.PictureBox();
            this.yellow1 = new System.Windows.Forms.PictureBox();
            this.pink1 = new System.Windows.Forms.PictureBox();
            this.red2 = new System.Windows.Forms.PictureBox();
            this.pink = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.pacman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(12, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(53, 21);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "score:";
            // 
            // gameTime
            // 
            this.gameTime.Tick += new System.EventHandler(this.gameTimeEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aplikacija.Properties.Resources.coin;
            this.pictureBox1.Location = new System.Drawing.Point(580, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "coin";
            // 
            // yellow
            // 
            this.yellow.Image = global::Aplikacija.Properties.Resources.yellow_guy;
            this.yellow.Location = new System.Drawing.Point(314, 457);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(40, 60);
            this.yellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellow.TabIndex = 8;
            this.yellow.TabStop = false;
            this.yellow.Tag = "ghost";
            // 
            // red1
            // 
            this.red1.Image = global::Aplikacija.Properties.Resources.red_guy;
            this.red1.Location = new System.Drawing.Point(495, 392);
            this.red1.Name = "red1";
            this.red1.Size = new System.Drawing.Size(40, 60);
            this.red1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.red1.TabIndex = 7;
            this.red1.TabStop = false;
            this.red1.Tag = "ghost";
            // 
            // yellow1
            // 
            this.yellow1.Image = global::Aplikacija.Properties.Resources.yellow_guy;
            this.yellow1.Location = new System.Drawing.Point(329, 9);
            this.yellow1.Name = "yellow1";
            this.yellow1.Size = new System.Drawing.Size(40, 60);
            this.yellow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellow1.TabIndex = 6;
            this.yellow1.TabStop = false;
            this.yellow1.Tag = "ghost";
            // 
            // pink1
            // 
            this.pink1.Image = global::Aplikacija.Properties.Resources.pink_guy;
            this.pink1.Location = new System.Drawing.Point(100, 66);
            this.pink1.Name = "pink1";
            this.pink1.Size = new System.Drawing.Size(40, 60);
            this.pink1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pink1.TabIndex = 5;
            this.pink1.TabStop = false;
            this.pink1.Tag = "ghost";
            // 
            // red2
            // 
            this.red2.Image = global::Aplikacija.Properties.Resources.red_guy;
            this.red2.Location = new System.Drawing.Point(100, 371);
            this.red2.Name = "red2";
            this.red2.Size = new System.Drawing.Size(40, 60);
            this.red2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.red2.TabIndex = 4;
            this.red2.TabStop = false;
            this.red2.Tag = "ghost";
            // 
            // pink
            // 
            this.pink.Image = global::Aplikacija.Properties.Resources.pink_guy;
            this.pink.Location = new System.Drawing.Point(565, 212);
            this.pink.Name = "pink";
            this.pink.Size = new System.Drawing.Size(40, 60);
            this.pink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pink.TabIndex = 3;
            this.pink.TabStop = false;
            this.pink.Tag = "ghost";
            // 
            // red
            // 
            this.red.Image = global::Aplikacija.Properties.Resources.red_guy;
            this.red.Location = new System.Drawing.Point(495, 66);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(40, 60);
            this.red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.red.TabIndex = 2;
            this.red.TabStop = false;
            this.red.Tag = "ghost";
            // 
            // pacman
            // 
            this.pacman.Image = global::Aplikacija.Properties.Resources.right;
            this.pacman.Location = new System.Drawing.Point(314, 217);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(55, 55);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman.TabIndex = 0;
            this.pacman.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.red1);
            this.Controls.Add(this.yellow1);
            this.Controls.Add(this.pink1);
            this.Controls.Add(this.red2);
            this.Controls.Add(this.pink);
            this.Controls.Add(this.red);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pacman);
            this.Name = "Form7";
            this.Text = "Form7";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pacman;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.PictureBox pink;
        private System.Windows.Forms.PictureBox red2;
        private System.Windows.Forms.PictureBox pink1;
        private System.Windows.Forms.PictureBox yellow1;
        private System.Windows.Forms.PictureBox red1;
        private System.Windows.Forms.PictureBox yellow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer gameTime;
    }
}