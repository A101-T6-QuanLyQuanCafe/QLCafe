﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }
    
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNHANVIEN frm = new QLNHANVIEN();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nGUYÊNLIỆUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNGUYENLIEU frm = new QLNGUYENLIEU();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}