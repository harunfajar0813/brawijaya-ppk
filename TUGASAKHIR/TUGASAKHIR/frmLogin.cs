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
    public partial class frmLogin : Form
    {
        private static string connect = string.Format("Server=localhost; port=3306; username=root; password=;database=utarain_db");
        private MySqlConnection dbConnect = new MySqlConnection(connect);
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM user WHERE nik = @nikPengguna AND tanggal = @tanggalPengguna";
            try
            {
                // Open the database
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.Parameters.Add(new MySqlParameter("@nikPengguna", textNIK.Text));
                cmd.Parameters.Add(new MySqlParameter("@tanggalPengguna", textTanggal.Text));
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Hide();
                    frmLogin formLogin = new frmLogin();
                    frmPilihKomisi formPilihKomisi = new frmPilihKomisi();
                    formPilihKomisi.setValue(reader["nik"].ToString(), reader["nama"].ToString());
                    formLogin.Close();
                    formPilihKomisi.ShowDialog();
                    Show();
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
