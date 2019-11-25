using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laporan3no1
{
    public partial class FormPict : Form
    {
        int deg, n;
        Image gbrAsli;
        Form1 frmParent;

        public FormPict(Form1 f1)
        {
            InitializeComponent();
            frmParent = f1;
        }

        public void setPic(Image img)
        {
            pictureBox1.Image = img;
            gbrAsli = pictureBox1.Image;
        }

        public void PutarKanan()
        {
            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            deg += 90;
            if(deg > 360){ deg = deg - 360; }
            pictureBox1.Image = flipImage;
            textBox1.Text = deg.ToString();
        }

        public void PutarKiri()
        {
            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            deg -= 90;
            if (deg < 0) { deg = 270; }
            pictureBox1.Image = flipImage;
            textBox1.Text = deg.ToString();
        }

        public void ZoomIn()
        {
            int ukuran = 50;
            pictureBox1.Height += ukuran;
            pictureBox1.Width += ukuran;
            textBox1.Text = pictureBox1.Size.ToString();
        }

        public void ZoomOut()
        {
            int ukuran = 50;
            pictureBox1.Height -= ukuran;
            pictureBox1.Width -= ukuran;
            textBox1.Text = pictureBox1.Size.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmParent.AllDegree1 = deg;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int a1, a2;
            a1 = frmParent.AllDegree1 / 90;
            a2 = deg / 90;
            if (a2 < a1)
            {
                for(int i = a2; i < a1; i++)
                {
                    PutarKanan();
                }
            }
            else if (a2 > a1)
            {
                for (int i = a1; i < a2; i++)
                {
                    PutarKiri();
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmParent.AllHeight1 = pictureBox1.Height;
            frmParent.AllWidht1 = pictureBox1.Width;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = frmParent.AllHeight1;
            pictureBox1.Width = frmParent.AllWidht1;
            textBox1.Text = "Height : " + pictureBox1.Height.ToString() + " Width : " + pictureBox1.Width.ToString();
        }

        private void FormPict_Load(object sender, EventArgs e)
        {

        }
    }
}
