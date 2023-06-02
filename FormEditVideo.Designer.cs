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
            this.LoadVideo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // FormEditVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoadVideo);
            this.Name = "FormEditVideo";
            this.Text = "FormEditVideo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadVideo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}