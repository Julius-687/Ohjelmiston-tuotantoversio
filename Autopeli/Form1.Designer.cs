
namespace Autopeli
{
    partial class Autopeli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autopeli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pisteet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trophy = new System.Windows.Forms.PictureBox();
            this.pelaaja = new System.Windows.Forms.PictureBox();
            this.rajahdys = new System.Windows.Forms.PictureBox();
            this.auto2 = new System.Windows.Forms.PictureBox();
            this.auto1 = new System.Windows.Forms.PictureBox();
            this.tie2 = new System.Windows.Forms.PictureBox();
            this.tie1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trophy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelaaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rajahdys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tie1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.trophy);
            this.panel1.Controls.Add(this.pelaaja);
            this.panel1.Controls.Add(this.rajahdys);
            this.panel1.Controls.Add(this.auto2);
            this.panel1.Controls.Add(this.auto1);
            this.panel1.Controls.Add(this.tie2);
            this.panel1.Controls.Add(this.tie1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 498);
            this.panel1.TabIndex = 0;
            // 
            // pisteet
            // 
            this.pisteet.AutoSize = true;
            this.pisteet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pisteet.Location = new System.Drawing.Point(12, 525);
            this.pisteet.Name = "pisteet";
            this.pisteet.Size = new System.Drawing.Size(105, 31);
            this.pisteet.TabIndex = 1;
            this.pisteet.Tag = "pisteet";
            this.pisteet.Text = "Pisteet";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 58);
            this.button1.TabIndex = 2;
            this.button1.Tag = "button1";
            this.button1.Text = "Aloita";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trophy
            // 
            this.trophy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.trophy.Image = ((System.Drawing.Image)(resources.GetObject("trophy.Image")));
            this.trophy.Location = new System.Drawing.Point(34, 193);
            this.trophy.Name = "trophy";
            this.trophy.Size = new System.Drawing.Size(184, 92);
            this.trophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trophy.TabIndex = 2;
            this.trophy.TabStop = false;
            // 
            // pelaaja
            // 
            this.pelaaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pelaaja.Image = ((System.Drawing.Image)(resources.GetObject("pelaaja.Image")));
            this.pelaaja.Location = new System.Drawing.Point(159, 395);
            this.pelaaja.Name = "pelaaja";
            this.pelaaja.Size = new System.Drawing.Size(50, 100);
            this.pelaaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pelaaja.TabIndex = 1;
            this.pelaaja.TabStop = false;
            // 
            // rajahdys
            // 
            this.rajahdys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.rajahdys.Image = ((System.Drawing.Image)(resources.GetObject("rajahdys.Image")));
            this.rajahdys.Location = new System.Drawing.Point(241, 180);
            this.rajahdys.Name = "rajahdys";
            this.rajahdys.Size = new System.Drawing.Size(113, 105);
            this.rajahdys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rajahdys.TabIndex = 1;
            this.rajahdys.TabStop = false;
            this.rajahdys.Tag = "rajahdys";
            // 
            // auto2
            // 
            this.auto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.auto2.Image = ((System.Drawing.Image)(resources.GetObject("auto2.Image")));
            this.auto2.Location = new System.Drawing.Point(274, 36);
            this.auto2.Name = "auto2";
            this.auto2.Size = new System.Drawing.Size(50, 100);
            this.auto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auto2.TabIndex = 1;
            this.auto2.TabStop = false;
            this.auto2.Tag = "auto2";
            // 
            // auto1
            // 
            this.auto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.auto1.Image = ((System.Drawing.Image)(resources.GetObject("auto1.Image")));
            this.auto1.Location = new System.Drawing.Point(54, 36);
            this.auto1.Name = "auto1";
            this.auto1.Size = new System.Drawing.Size(50, 100);
            this.auto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auto1.TabIndex = 1;
            this.auto1.TabStop = false;
            this.auto1.Tag = "auto1";
            // 
            // tie2
            // 
            this.tie2.BackColor = System.Drawing.Color.Black;
            this.tie2.Image = ((System.Drawing.Image)(resources.GetObject("tie2.Image")));
            this.tie2.Location = new System.Drawing.Point(0, -499);
            this.tie2.Name = "tie2";
            this.tie2.Size = new System.Drawing.Size(381, 499);
            this.tie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tie2.TabIndex = 0;
            this.tie2.TabStop = false;
            // 
            // tie1
            // 
            this.tie1.Image = ((System.Drawing.Image)(resources.GetObject("tie1.Image")));
            this.tie1.Location = new System.Drawing.Point(0, 0);
            this.tie1.Name = "tie1";
            this.tie1.Size = new System.Drawing.Size(381, 499);
            this.tie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tie1.TabIndex = 0;
            this.tie1.TabStop = false;
            // 
            // Autopeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 656);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pisteet);
            this.Controls.Add(this.panel1);
            this.Name = "Autopeli";
            this.Text = "Autopeli";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moveCar);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stopCar);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trophy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelaaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rajahdys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tie1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pelaaja;
        private System.Windows.Forms.PictureBox rajahdys;
        private System.Windows.Forms.PictureBox auto2;
        private System.Windows.Forms.PictureBox auto1;
        private System.Windows.Forms.PictureBox tie2;
        private System.Windows.Forms.PictureBox tie1;
        private System.Windows.Forms.Label pisteet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox trophy;
        private System.Windows.Forms.Timer timer1;
    }
}

