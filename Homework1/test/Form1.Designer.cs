namespace test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramBox = new Emgu.CV.UI.HistogramBox();
            this.binary_img_box = new Emgu.CV.UI.ImageBox();
            this.grey_img_box = new Emgu.CV.UI.ImageBox();
            this.color_img_box = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binary_img_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey_img_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_img_box)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.histogramToolStripMenuItem,
            this.binaryToolStripMenuItem});
            this.menuStrip2.Name = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            resources.ApplyResources(this.histogramToolStripMenuItem, "histogramToolStripMenuItem");
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            resources.ApplyResources(this.binaryToolStripMenuItem, "binaryToolStripMenuItem");
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // histogramBox
            // 
            resources.ApplyResources(this.histogramBox, "histogramBox");
            this.histogramBox.Name = "histogramBox";
            // 
            // binary_img_box
            // 
            this.binary_img_box.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.binary_img_box, "binary_img_box");
            this.binary_img_box.Name = "binary_img_box";
            this.binary_img_box.TabStop = false;
            // 
            // grey_img_box
            // 
            this.grey_img_box.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.grey_img_box, "grey_img_box");
            this.grey_img_box.Name = "grey_img_box";
            this.grey_img_box.TabStop = false;
            // 
            // color_img_box
            // 
            this.color_img_box.BackColor = System.Drawing.Color.White;
            this.color_img_box.BackgroundImage = global::test.Properties.Resources.select_img;
            resources.ApplyResources(this.color_img_box, "color_img_box");
            this.color_img_box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.color_img_box.Name = "color_img_box";
            this.color_img_box.TabStop = false;
            this.color_img_box.Click += new System.EventHandler(this.color_img_box_Click);
            this.color_img_box.MouseHover += new System.EventHandler(this.color_img_box_MouseHover);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.binary_img_box);
            this.Controls.Add(this.histogramBox);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.grey_img_box);
            this.Controls.Add(this.color_img_box);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binary_img_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey_img_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_img_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox color_img_box;
        private Emgu.CV.UI.ImageBox grey_img_box;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private Emgu.CV.UI.HistogramBox histogramBox;
        private Emgu.CV.UI.ImageBox binary_img_box;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

