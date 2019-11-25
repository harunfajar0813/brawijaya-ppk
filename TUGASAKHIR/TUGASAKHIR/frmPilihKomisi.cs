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

namespace TUGASAKHIR
{
    
    public partial class frmPilihKomisi : Form
    {
        private static string connect = string.Format("Server=localhost; port=3306; username=root; password=;database=utarain_db");
        private MySqlConnection dbConnect = new MySqlConnection(connect);
        public frmPilihKomisi()
        {
            InitializeComponent();
        }

        public void setValue(string nik, string nama)
        {
            lblNIK.Text = nik;
            lblName.Text = nama;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM komisi";
            try
            {
                // Open the database
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxKomisi.Items.Add(reader.GetString("nama"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.Close();
            }
        }

        private void BtnSampaikan_Click(object sender, EventArgs e)
        {
            Hide();
            frmPilihKomisi formPilihKomisi = new frmPilihKomisi();
            frmAspirasi formAspirasi = new frmAspirasi();
            // Masuk ke Form Aspirasi
            // constuctor kirim nik, nama, idKomisi
            formAspirasi.setValueAspirasi(lblNIK.Text, lblName.Text, textBoxGetIdKomisi.Text, textBoxGetNamaKomisi.Text);
            formPilihKomisi.Close();
            formAspirasi.ShowDialog();
        }

        private void ComboBoxKomisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // kirim id dari komisi dan lempar ke textbox
            string query = "SELECT * FROM komisi WHERE nama = @namaKomisi";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.Parameters.Add(new MySqlParameter("@namaKomisi", comboBoxKomisi.Text));
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBoxGetIdKomisi.Text = reader.GetString("id");
                    textBoxGetNamaKomisi.Text = reader.GetString("nama");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.Close();
            }
        }
    }
   
}
