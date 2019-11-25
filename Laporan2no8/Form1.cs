using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laporan2no8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Control formAktif;
        private void Button5_Click(object sender, EventArgs e)
        {
            Button tombolAngka = (Button)sender;
            formAktif.Focus();
            SendKeys.Send(tombolAngka.Text);
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            formAktif = (Control)sender;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button tombolHitung = (Button)sender;
            switch (tombolHitung.Text)
            {
                case "+":
                    label1.Text = (float.Parse(textBox1.Text) + float.Parse(textBox2.Text)).ToString();
                    break;
                case "-":
                    label1.Text = (float.Parse(textBox1.Text) - float.Parse(textBox2.Text)).ToString();
                    break;
                case "*":
                    label1.Text = (float.Parse(textBox1.Text) * float.Parse(textBox2.Text)).ToString();
                    break;
                case "/":
                    label1.Text = (float.Parse(textBox1.Text) / float.Parse(textBox2.Text)).ToString();
                    break;
            }
        }
    }
}
