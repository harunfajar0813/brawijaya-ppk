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
    public partial class FormKirim : Form
    {
        private static string connect = string.Format("Server=localhost; port=3306; username=root; password=;database=utarain_db");
        private MySqlConnection dbConnect = new MySqlConnection(connect);
        public FormKirim()
        {
            InitializeComponent();
        }

        public void setValue(string nik, string idKomisi)
        {
            textBoxIdKomisi.Text = idKomisi;
            textBoxIdUser.Text = nik;
        }

        private void BtnKirimAspirasi_Click(object sender, EventArgs e)
        {
            string query1 = "INSERT INTO aspirasi (judul, aspirasi, user_nik, komisi_id) VALUES (@aspirasiJudul, @aspirasiAspirasi, @aspirasiUserNIK, @aspirasiKomisiID)";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query1, dbConnect);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@aspirasiJudul", textKirimJudul.Text);
                cmd.Parameters.AddWithValue("@aspirasiAspirasi", textKirimIsi.Text);
                cmd.Parameters.AddWithValue("@aspirasiUserNIK", textBoxIdUser.Text);
                cmd.Parameters.AddWithValue("@aspirasiKomisiID", textBoxIdKomisi.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("1");
            }
            finally
            {
                dbConnect.Close();
                
            }

            string query2 = "SELECT * FROM aspirasi WHERE judul = @pilihJudul AND user_nik = @pilihNIK";
            try
            {
                // Open the database
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query2, dbConnect);
                cmd.Parameters.AddWithValue("@pilihJudul", textKirimJudul.Text);
                cmd.Parameters.AddWithValue("@pilihNIK", textBoxIdUser.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBoxIdAspirasi.Text = reader.GetString("id");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("2");
            }
            finally
            {
                dbConnect.Close();
            }

            string query3 = "INSERT INTO urut_aspirasi (aspirasi_id, jumlah) VALUES (@urutAspirasiID, @urutAspirasiJumlah)";
            try
            {
                // Open the database
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query3, dbConnect);
                cmd.Parameters.AddWithValue("@urutAspirasiID", textBoxIdAspirasi.Text);
                cmd.Parameters.AddWithValue("@urutAspirasiJumlah", 0);
                MySqlDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("3");
            }
            finally
            {
                dbConnect.Close();
            }
        }

        private void FormKirim_Load(object sender, EventArgs e)
        {
        }
    }
}
