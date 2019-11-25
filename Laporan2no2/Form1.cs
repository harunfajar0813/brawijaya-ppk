using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laporan2no2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            label1.Text = "Ini adalah event ENTER";
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            label1.Text = "Ini adalah event LEAVE";
        }

        private void TextBox1_EnabledChanged(object sender, EventArgs e)
        {
            if(textBox1.Enabled)
                button1.Text = "textbox dapat menerima masukkan";
            else
                button1.Text = "textbox dapat tidak menerima masukkan";
        }

        private void TextBox1_VisibleChanged(object sender, EventArgs e)
        {
            if(textBox1.Visible == true)
                button2.Text = "event VISIBLE ketika TRUE";
            else
                button2.Text = "event VISIBLE ketika FALSE";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = !textBox1.Enabled;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = !textBox1.Visible;
        }
    }
}
