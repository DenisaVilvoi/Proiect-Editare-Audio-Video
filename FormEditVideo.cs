using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormEditVideo : Form
    {
        Video video = new Video();
        public FormEditVideo()
        {
            InitializeComponent();
        }

        private void LoadVideo_Click(object sender, EventArgs e)
        {
            video.loadVideo(pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            video.playVideo();
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            video.grayScale();
        }
        private void showMenu(MouseEventArgs e, ContextMenuStrip contextMenuStrip)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point screenPoint = Cursor.Position;
                contextMenuStrip.Show(screenPoint);
            }
        }
        private void FormEditVideo_MouseDown(object sender, MouseEventArgs e)
        {
            showMenu(e, contextMenuStrip1);
        }

        private void rEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            video.extract(new Bgr(255, 255, 0));
        }

        private void gREENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            video.extract(new Bgr(255, 0, 255));
        }

        private void bLUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            video.extract(new Bgr(0, 255, 255));
        }

        private void carouselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            video.carousel();

        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            video.gammaCorection(textBox1);
            textBox1.Visible = false;
        }

        private void alphaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
                
        }

        private void applyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            video.brightnessVideo(textBox1, textBox2);
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;


        }
    }
}
