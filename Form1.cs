﻿using System;
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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void EditVideo_Click(object sender, EventArgs e)
        {
            FormEditVideo formEditVideo= new FormEditVideo();
            formEditVideo.ShowDialog();
        }
    }
}
