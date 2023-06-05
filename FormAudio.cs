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
    public partial class FormAudio : Form
    {
        Audio audio = new Audio();
        public FormAudio()
        {
            InitializeComponent();
        }

        private void mixAudio_Click(object sender, EventArgs e)
        {
            audio.mixAudio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            audio.combine();
        }
    }
}
