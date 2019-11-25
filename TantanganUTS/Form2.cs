using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TantanganUTS
{
    public partial class Form2 : Form
    {
        private static string connect = string.Format("Server=localhost; port=3306; username=root; password=;database=quiz_ppk");
        private MySqlConnection dbConnect = new MySqlConnection(connect);
        public Form2(String nim, String nama, String alamat, String tempat, String tgl, String path)
        {
            InitializeComponent();
            textBox1.Text = nim;
            textBox2.Text = nama;
            textBox3.Text = alamat;
            textBox4.Text = tempat;
            textBox5.Text = tgl[0].ToString()+tgl[1].ToString()+"-"+tgl[3].ToString()+tgl[4].ToString()+"-"+tgl[6].ToString() + tgl[7].ToString() + tgl[8].ToString()+tgl[9].ToString();
            pictureBox1.Image = Image.FromFile(path);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
