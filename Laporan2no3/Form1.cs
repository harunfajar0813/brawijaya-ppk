using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laporan2no3
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode.ToString().Equals("A")) label3.Text = "Memilih Semua";
            else if (e.Control == true && e.KeyCode.ToString().Equals("C")) label3.Text = "Melakukan Salin Data";
            else if (e.Control == true && e.KeyCode.ToString().Equals("V")) label3.Text = "Melakukan Tempel Data";
            else if (e.Control == true && e.KeyCode.ToString().Equals("P")) label3.Text = "Melakukan Cetak";
        }

        int hitung = 0;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "tombol yang tekan adalah " + e.Button;
            hitung++;
            if (label2 != null) label2.Text = hitung.ToString();
        }
    }
}
