﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laporan1no6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnGanti_Click(object sender, EventArgs e)
        {
            DialogResult pilihan = dlgWarna.ShowDialog();
            if(pilihan == DialogResult.OK)
            {
                this.BackColor = dlgWarna.Color;
            }
        }
    }
}
