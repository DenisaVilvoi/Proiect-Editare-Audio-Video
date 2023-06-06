namespace Proiect
{
    partial class FormEditVideo
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
            this.LoadVideo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gREENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLUEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carouselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaCorectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadVideo
            // 
            this.LoadVideo.AllowDrop = true;
            this.LoadVideo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LoadVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadVideo.Font = new System.Drawing.Font("Elephant", 12F);
            this.LoadVideo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoadVideo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoadVideo.Location = new System.Drawing.Point(361, 21);
            this.LoadVideo.Name = "LoadVideo";
            this.LoadVideo.Size = new System.Drawing.Size(380, 66);
            this.LoadVideo.TabIndex = 1;
            this.LoadVideo.Text = "Load Video";
            this.LoadVideo.UseVisualStyleBackColor = false;
            this.LoadVideo.Click += new System.EventHandler(this.LoadVideo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(155, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 387);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Elephant", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(500, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.extractToolStripMenuItem,
            this.carouselToolStripMenuItem,
            this.gammaCorectionToolStripMenuItem,
            this.brightnessToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 124);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEDToolStripMenuItem,
            this.gREENToolStripMenuItem,
            this.bLUEToolStripMenuItem});
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.extractToolStripMenuItem.Text = "Extract";
            // 
            // rEDToolStripMenuItem
            // 
            this.rEDToolStripMenuItem.Name = "rEDToolStripMenuItem";
            this.rEDToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.rEDToolStripMenuItem.Text = "RED";
            this.rEDToolStripMenuItem.Click += new System.EventHandler(this.rEDToolStripMenuItem_Click);
            // 
            // gREENToolStripMenuItem
            // 
            this.gREENToolStripMenuItem.Name = "gREENToolStripMenuItem";
            this.gREENToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.gREENToolStripMenuItem.Text = "GREEN";
            this.gREENToolStripMenuItem.Click += new System.EventHandler(this.gREENToolStripMenuItem_Click);
            // 
            // bLUEToolStripMenuItem
            // 
            this.bLUEToolStripMenuItem.Name = "bLUEToolStripMenuItem";
            this.bLUEToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.bLUEToolStripMenuItem.Text = "BLUE";
            this.bLUEToolStripMenuItem.Click += new System.EventHandler(this.bLUEToolStripMenuItem_Click);
            // 
            // carouselToolStripMenuItem
            // 
            this.carouselToolStripMenuItem.Name = "carouselToolStripMenuItem";
            this.carouselToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.carouselToolStripMenuItem.Text = "Carousel";
            this.carouselToolStripMenuItem.Click += new System.EventHandler(this.carouselToolStripMenuItem_Click);
            // 
            // gammaCorectionToolStripMenuItem
            // 
            this.gammaCorectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.applyToolStripMenuItem});
            this.gammaCorectionToolStripMenuItem.Name = "gammaCorectionToolStripMenuItem";
            this.gammaCorectionToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.gammaCorectionToolStripMenuItem.Text = "Gamma Corection";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.inputToolStripMenuItem.Text = "Input";
            this.inputToolStripMenuItem.Click += new System.EventHandler(this.inputToolStripMenuItem_Click);
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.applyToolStripMenuItem.Text = "Apply";
            this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alphaToolStripMenuItem,
            this.applyToolStripMenuItem1});
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            // 
            // alphaToolStripMenuItem
            // 
            this.alphaToolStripMenuItem.Name = "alphaToolStripMenuItem";
            this.alphaToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.alphaToolStripMenuItem.Text = "Alpha Beta";
            this.alphaToolStripMenuItem.Click += new System.EventHandler(this.alphaToolStripMenuItem_Click);
            // 
            // applyToolStripMenuItem1
            // 
            this.applyToolStripMenuItem1.Name = "applyToolStripMenuItem1";
            this.applyToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.applyToolStripMenuItem1.Text = "Apply";
            this.applyToolStripMenuItem1.Click += new System.EventHandler(this.applyToolStripMenuItem1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alpha";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Beta";
            this.label2.Visible = false;
            // 
            // FormEditVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect.Properties.Resources.first_page;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoadVideo);
            this.Name = "FormEditVideo";
            this.Text = "FormEditVideo";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormEditVideo_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadVideo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gREENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bLUEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carouselToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaCorectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}