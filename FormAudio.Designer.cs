namespace Proiect
{
    partial class FormAudio
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
            this.mixAudio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mixAudio
            // 
            this.mixAudio.AllowDrop = true;
            this.mixAudio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mixAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mixAudio.Font = new System.Drawing.Font("Elephant", 12F);
            this.mixAudio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mixAudio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mixAudio.Location = new System.Drawing.Point(334, 114);
            this.mixAudio.Name = "mixAudio";
            this.mixAudio.Size = new System.Drawing.Size(380, 66);
            this.mixAudio.TabIndex = 1;
            this.mixAudio.Text = "Mix  Audio";
            this.mixAudio.UseVisualStyleBackColor = false;
            this.mixAudio.Click += new System.EventHandler(this.mixAudio_Click);
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Elephant", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(334, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Combine  Audio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mixAudio);
            this.Name = "FormAudio";
            this.Text = "FormAudio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mixAudio;
        private System.Windows.Forms.Button button1;
    }
}