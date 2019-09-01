namespace proje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cizimSekil = new System.Windows.Forms.Panel();
            this.Altigen = new System.Windows.Forms.PictureBox();
            this.Ucgen = new System.Windows.Forms.PictureBox();
            this.Daire = new System.Windows.Forms.PictureBox();
            this.Dortgen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dosya_islemleri = new System.Windows.Forms.Panel();
            this.open = new System.Windows.Forms.PictureBox();
            this.kaydet = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sekil_islemleri = new System.Windows.Forms.Panel();
            this.silme = new System.Windows.Forms.PictureBox();
            this.secme = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RenkSecim = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.R_white = new System.Windows.Forms.Button();
            this.R_brown = new System.Windows.Forms.Button();
            this.R_mor = new System.Windows.Forms.Button();
            this.R_yello = new System.Windows.Forms.Button();
            this.R_black = new System.Windows.Forms.Button();
            this.R_orange = new System.Windows.Forms.Button();
            this.R_green = new System.Windows.Forms.Button();
            this.R_mavi = new System.Windows.Forms.Button();
            this.R_red = new System.Windows.Forms.Button();
            this.panel_Draw = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cizimSekil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Altigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ucgen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Daire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dortgen)).BeginInit();
            this.Dosya_islemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaydet)).BeginInit();
            this.sekil_islemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.silme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secme)).BeginInit();
            this.RenkSecim.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cizimSekil
            // 
            this.cizimSekil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cizimSekil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cizimSekil.Controls.Add(this.Altigen);
            this.cizimSekil.Controls.Add(this.Ucgen);
            this.cizimSekil.Controls.Add(this.Daire);
            this.cizimSekil.Controls.Add(this.Dortgen);
            this.cizimSekil.Controls.Add(this.label2);
            this.cizimSekil.Location = new System.Drawing.Point(632, 5);
            this.cizimSekil.Name = "cizimSekil";
            this.cizimSekil.Size = new System.Drawing.Size(156, 143);
            this.cizimSekil.TabIndex = 1;
            this.cizimSekil.Paint += new System.Windows.Forms.PaintEventHandler(this.cizimSekil_Paint);
            // 
            // Altigen
            // 
            this.Altigen.Image = ((System.Drawing.Image)(resources.GetObject("Altigen.Image")));
            this.Altigen.Location = new System.Drawing.Point(85, 83);
            this.Altigen.Name = "Altigen";
            this.Altigen.Size = new System.Drawing.Size(66, 55);
            this.Altigen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Altigen.TabIndex = 14;
            this.Altigen.TabStop = false;
            this.Altigen.Click += new System.EventHandler(this.Altigen_Click_1);
            this.Altigen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Altigen_MouseClick);
            this.Altigen.MouseLeave += new System.EventHandler(this.Altigen_MouseLeave);
            // 
            // Ucgen
            // 
            this.Ucgen.Image = ((System.Drawing.Image)(resources.GetObject("Ucgen.Image")));
            this.Ucgen.Location = new System.Drawing.Point(10, 83);
            this.Ucgen.Name = "Ucgen";
            this.Ucgen.Size = new System.Drawing.Size(66, 55);
            this.Ucgen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ucgen.TabIndex = 13;
            this.Ucgen.TabStop = false;
            this.Ucgen.Click += new System.EventHandler(this.Ucgen_Click_1);
            this.Ucgen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Ucgen_MouseClick);
            this.Ucgen.MouseLeave += new System.EventHandler(this.Ucgen_MouseLeave);
            // 
            // Daire
            // 
            this.Daire.Image = ((System.Drawing.Image)(resources.GetObject("Daire.Image")));
            this.Daire.Location = new System.Drawing.Point(85, 19);
            this.Daire.Name = "Daire";
            this.Daire.Size = new System.Drawing.Size(66, 55);
            this.Daire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Daire.TabIndex = 12;
            this.Daire.TabStop = false;
            this.Daire.Click += new System.EventHandler(this.Daire_Click_1);
            this.Daire.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Daire_MouseClick);
            this.Daire.MouseLeave += new System.EventHandler(this.Daire_MouseLeave);
            // 
            // Dortgen
            // 
            this.Dortgen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Dortgen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dortgen.Location = new System.Drawing.Point(13, 29);
            this.Dortgen.Name = "Dortgen";
            this.Dortgen.Size = new System.Drawing.Size(53, 45);
            this.Dortgen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dortgen.TabIndex = 11;
            this.Dortgen.TabStop = false;
            this.Dortgen.Click += new System.EventHandler(this.Dortgen_Click_1);
            this.Dortgen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dortgen_MouseClick);
            this.Dortgen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dortgen_MouseDown);
            this.Dortgen.MouseLeave += new System.EventHandler(this.Dortgen_MouseLeave);
            this.Dortgen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dortgen_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Çizim Şekli";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 503);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(417, 503);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(63, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mouse X Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(309, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mouse Y Position";
            // 
            // Dosya_islemleri
            // 
            this.Dosya_islemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dosya_islemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dosya_islemleri.Controls.Add(this.open);
            this.Dosya_islemleri.Controls.Add(this.kaydet);
            this.Dosya_islemleri.Controls.Add(this.label4);
            this.Dosya_islemleri.Location = new System.Drawing.Point(632, 388);
            this.Dosya_islemleri.Name = "Dosya_islemleri";
            this.Dosya_islemleri.Size = new System.Drawing.Size(156, 110);
            this.Dosya_islemleri.TabIndex = 2;
            // 
            // open
            // 
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.Location = new System.Drawing.Point(10, 35);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(66, 55);
            this.open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.open.TabIndex = 13;
            this.open.TabStop = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            this.open.MouseClick += new System.Windows.Forms.MouseEventHandler(this.open_MouseClick);
            this.open.MouseLeave += new System.EventHandler(this.open_MouseLeave);
            // 
            // kaydet
            // 
            this.kaydet.Image = ((System.Drawing.Image)(resources.GetObject("kaydet.Image")));
            this.kaydet.Location = new System.Drawing.Point(85, 35);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(66, 55);
            this.kaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaydet.TabIndex = 12;
            this.kaydet.TabStop = false;
            this.kaydet.Click += new System.EventHandler(this.save_Click);
            this.kaydet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kaydet_MouseClick);
            this.kaydet.MouseLeave += new System.EventHandler(this.kaydet_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dosya işlemleri";
            // 
            // sekil_islemleri
            // 
            this.sekil_islemleri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sekil_islemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekil_islemleri.Controls.Add(this.silme);
            this.sekil_islemleri.Controls.Add(this.secme);
            this.sekil_islemleri.Controls.Add(this.label3);
            this.sekil_islemleri.Location = new System.Drawing.Point(632, 303);
            this.sekil_islemleri.Name = "sekil_islemleri";
            this.sekil_islemleri.Size = new System.Drawing.Size(156, 79);
            this.sekil_islemleri.TabIndex = 2;
            // 
            // silme
            // 
            this.silme.Image = ((System.Drawing.Image)(resources.GetObject("silme.Image")));
            this.silme.Location = new System.Drawing.Point(85, 21);
            this.silme.Name = "silme";
            this.silme.Size = new System.Drawing.Size(50, 51);
            this.silme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.silme.TabIndex = 14;
            this.silme.TabStop = false;
            this.silme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.silme_MouseClick);
            this.silme.MouseLeave += new System.EventHandler(this.silme_MouseLeave);
            // 
            // secme
            // 
            this.secme.Image = ((System.Drawing.Image)(resources.GetObject("secme.Image")));
            this.secme.Location = new System.Drawing.Point(16, 21);
            this.secme.Name = "secme";
            this.secme.Size = new System.Drawing.Size(50, 51);
            this.secme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secme.TabIndex = 15;
            this.secme.TabStop = false;
            this.secme.Click += new System.EventHandler(this.secme_Click);
            this.secme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.secme_MouseClick);
            this.secme.MouseLeave += new System.EventHandler(this.secme_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şekil işlemleri";
            // 
            // RenkSecim
            // 
            this.RenkSecim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RenkSecim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RenkSecim.Controls.Add(this.label1);
            this.RenkSecim.Controls.Add(this.R_white);
            this.RenkSecim.Controls.Add(this.R_brown);
            this.RenkSecim.Controls.Add(this.R_mor);
            this.RenkSecim.Controls.Add(this.R_yello);
            this.RenkSecim.Controls.Add(this.R_black);
            this.RenkSecim.Controls.Add(this.R_orange);
            this.RenkSecim.Controls.Add(this.R_green);
            this.RenkSecim.Controls.Add(this.R_mavi);
            this.RenkSecim.Controls.Add(this.R_red);
            this.RenkSecim.Location = new System.Drawing.Point(632, 154);
            this.RenkSecim.Name = "RenkSecim";
            this.RenkSecim.Size = new System.Drawing.Size(160, 143);
            this.RenkSecim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Renk Seçimi";
            // 
            // R_white
            // 
            this.R_white.BackColor = System.Drawing.Color.LavenderBlush;
            this.R_white.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_white.Location = new System.Drawing.Point(111, 97);
            this.R_white.Name = "R_white";
            this.R_white.Size = new System.Drawing.Size(28, 27);
            this.R_white.TabIndex = 8;
            this.R_white.UseVisualStyleBackColor = false;
            this.R_white.Click += new System.EventHandler(this.R_white_Click);
            // 
            // R_brown
            // 
            this.R_brown.BackColor = System.Drawing.Color.Maroon;
            this.R_brown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_brown.Location = new System.Drawing.Point(64, 97);
            this.R_brown.Name = "R_brown";
            this.R_brown.Size = new System.Drawing.Size(28, 27);
            this.R_brown.TabIndex = 7;
            this.R_brown.UseVisualStyleBackColor = false;
            this.R_brown.Click += new System.EventHandler(this.R_brown_Click);
            // 
            // R_mor
            // 
            this.R_mor.BackColor = System.Drawing.Color.Purple;
            this.R_mor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_mor.Location = new System.Drawing.Point(17, 97);
            this.R_mor.Name = "R_mor";
            this.R_mor.Size = new System.Drawing.Size(28, 27);
            this.R_mor.TabIndex = 6;
            this.R_mor.UseVisualStyleBackColor = false;
            this.R_mor.Click += new System.EventHandler(this.R_mor_Click);
            // 
            // R_yello
            // 
            this.R_yello.BackColor = System.Drawing.Color.Yellow;
            this.R_yello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_yello.Location = new System.Drawing.Point(111, 64);
            this.R_yello.Name = "R_yello";
            this.R_yello.Size = new System.Drawing.Size(28, 27);
            this.R_yello.TabIndex = 5;
            this.R_yello.UseVisualStyleBackColor = false;
            this.R_yello.Click += new System.EventHandler(this.R_yello_Click);
            // 
            // R_black
            // 
            this.R_black.BackColor = System.Drawing.Color.Black;
            this.R_black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_black.Location = new System.Drawing.Point(64, 64);
            this.R_black.Name = "R_black";
            this.R_black.Size = new System.Drawing.Size(28, 27);
            this.R_black.TabIndex = 4;
            this.R_black.UseVisualStyleBackColor = false;
            this.R_black.Click += new System.EventHandler(this.R_black_Click);
            // 
            // R_orange
            // 
            this.R_orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.R_orange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_orange.Location = new System.Drawing.Point(17, 64);
            this.R_orange.Name = "R_orange";
            this.R_orange.Size = new System.Drawing.Size(28, 27);
            this.R_orange.TabIndex = 3;
            this.R_orange.UseVisualStyleBackColor = false;
            this.R_orange.Click += new System.EventHandler(this.R_orange_Click);
            // 
            // R_green
            // 
            this.R_green.BackColor = System.Drawing.Color.Green;
            this.R_green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_green.Location = new System.Drawing.Point(111, 31);
            this.R_green.Name = "R_green";
            this.R_green.Size = new System.Drawing.Size(28, 27);
            this.R_green.TabIndex = 2;
            this.R_green.UseVisualStyleBackColor = false;
            this.R_green.Click += new System.EventHandler(this.R_green_Click);
            // 
            // R_mavi
            // 
            this.R_mavi.BackColor = System.Drawing.Color.Blue;
            this.R_mavi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_mavi.Location = new System.Drawing.Point(64, 31);
            this.R_mavi.Name = "R_mavi";
            this.R_mavi.Size = new System.Drawing.Size(28, 27);
            this.R_mavi.TabIndex = 1;
            this.R_mavi.UseVisualStyleBackColor = false;
            this.R_mavi.Click += new System.EventHandler(this.R_mavi_Click);
            // 
            // R_red
            // 
            this.R_red.BackColor = System.Drawing.Color.Red;
            this.R_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_red.Location = new System.Drawing.Point(17, 31);
            this.R_red.Name = "R_red";
            this.R_red.Size = new System.Drawing.Size(28, 27);
            this.R_red.TabIndex = 0;
            this.R_red.UseVisualStyleBackColor = false;
            this.R_red.Click += new System.EventHandler(this.R_red_Click);
            // 
            // panel_Draw
            // 
            this.panel_Draw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Draw.Location = new System.Drawing.Point(10, 7);
            this.panel_Draw.Name = "panel_Draw";
            this.panel_Draw.Size = new System.Drawing.Size(605, 490);
            this.panel_Draw.TabIndex = 3;
            this.panel_Draw.Click += new System.EventHandler(this.panel_Draw_Click);
            this.panel_Draw.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Draw_Paint);
            this.panel_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Draw_MouseDown);
            this.panel_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Draw_MouseMove);
            this.panel_Draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Draw_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Draw);
            this.panel1.Controls.Add(this.RenkSecim);
            this.panel1.Controls.Add(this.sekil_islemleri);
            this.panel1.Controls.Add(this.Dosya_islemleri);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 546);
            this.panel1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 546);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cizimSekil);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Paint Application";
            this.cizimSekil.ResumeLayout(false);
            this.cizimSekil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Altigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ucgen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Daire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dortgen)).EndInit();
            this.Dosya_islemleri.ResumeLayout(false);
            this.Dosya_islemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaydet)).EndInit();
            this.sekil_islemleri.ResumeLayout(false);
            this.sekil_islemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.silme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secme)).EndInit();
            this.RenkSecim.ResumeLayout(false);
            this.RenkSecim.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel cizimSekil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Altigen;
        private System.Windows.Forms.PictureBox Ucgen;
        private System.Windows.Forms.PictureBox Daire;
        private System.Windows.Forms.PictureBox Dortgen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Dosya_islemleri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel sekil_islemleri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel RenkSecim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button R_white;
        private System.Windows.Forms.Button R_brown;
        private System.Windows.Forms.Button R_mor;
        private System.Windows.Forms.Button R_yello;
        private System.Windows.Forms.Button R_black;
        private System.Windows.Forms.Button R_orange;
        private System.Windows.Forms.Button R_green;
        private System.Windows.Forms.Button R_mavi;
        private System.Windows.Forms.Button R_red;
        private System.Windows.Forms.Panel panel_Draw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox open;
        private System.Windows.Forms.PictureBox kaydet;
        private System.Windows.Forms.PictureBox silme;
        private System.Windows.Forms.PictureBox secme;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

