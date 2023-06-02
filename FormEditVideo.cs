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
    }
}
