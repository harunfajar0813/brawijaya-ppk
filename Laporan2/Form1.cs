using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laporan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lihatData(object sender, EventArgs e)
        {
            lbHelo1.Text = "ini adalah lihatData";
        }

        private void cetakLaporan(object sender, EventArgs e)
        {
            lbHelo2.Text = "ini adalah cetakLaporan";
        }

        private void tutupAplikasi(object sender, EventArgs e)
        {
            lbHelo3.Text = "ini adalah tutupAplikasi";
        }
    }
}
