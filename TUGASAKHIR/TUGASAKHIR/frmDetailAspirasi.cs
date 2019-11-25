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
    public partial class frmDetailAspirasi : Form
    {
        private static string connect = string.Format("Server=localhost; port=3306; username=root; password=;database=utarain_db");
        private MySqlConnection dbConnect = new MySqlConnection(connect);
        public frmDetailAspirasi(String judul, String detail, String aspirasiID, String userNIK, String urutId, String komisiId)
        {
            InitializeComponent();
            textJudulAspirasi.Text = judul;
            textDetailAspirasi.Text = detail;
            textBoxIdAspirasi.Text = aspirasiID;
            textBoxIdUser.Text = userNIK;
            textBoxIdUrut.Text = urutId;
            textBoxIdKomisi.Text = komisiId;

            string query = "SELECT * FROM urut_aspirasi WHERE id = @pilihAspiriasiID";
            try
            {
                dbConnect.Open();
                MySqlCommand cmdPilihJumlah = new MySqlCommand(query, dbConnect);
                cmdPilihJumlah.Parameters.AddWithValue("@pilihAspiriasiID", textBoxIdUrut.Text);
                cmdPilihJumlah.CommandTimeout = 60;
                MySqlDataReader reader = cmdPilihJumlah.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBoxJumlahVote.Text = reader["jumlah"].ToString();
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
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
            updateTextBoxJumlahTerkini();
            deteksiGerakan();
        }

        public void chooseButton(Object sender, EventArgs e)
        {
            Button tekan = (Button)sender;
            string query = "SELECT * FROM vote WHERE aspirasi_id = @voteAspirasiID AND user_nik = @voteUserNIK";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.Parameters.AddWithValue("@voteAspirasiID", textBoxIdAspirasi.Text);
                cmd.Parameters.AddWithValue("@voteUserNIK", textBoxIdUser.Text);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (tekan == btnUpvote)
                    {
                        dbConnect.Close();
                        kirimVoteAda(1);
                    }
                    else if (tekan == btnDownvote)
                    {
                        dbConnect.Close();
                        kirimVoteAda(0);
                    }
                }
                else
                {
                    if (tekan == btnUpvote)
                    {
                        dbConnect.Close();
                        kirimVoteKosong(1);
                    }
                    else if (tekan == btnDownvote)
                    {
                        dbConnect.Close();
                        kirimVoteKosong(0);
                    }
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
            
            frmAspirasi frmPindah = new frmAspirasi();
            frmPindah.Show();
            this.Hide();
        }

        public void updateTextBoxJumlahTerkini()
        {
            string query = "SELECT * FROM urut_aspirasi WHERE id = @pilihAspiriasiID";
            try
            {
                dbConnect.Open();
                MySqlCommand cmdPilihJumlah = new MySqlCommand(query, dbConnect);
                cmdPilihJumlah.Parameters.AddWithValue("@pilihAspiriasiID", textBoxIdUrut.Text);
                cmdPilihJumlah.CommandTimeout = 60;
                MySqlDataReader reader = cmdPilihJumlah.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBoxJumlahVote.Text = reader["jumlah"].ToString();
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
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

        public void kirimVoteKosong(int UpOrDown)
        {
            string queryKosong = "INSERT INTO vote (user_nik, aspirasi_id, status_vote) VALUES (@voteNIK, @voteAspirasiID, @voteStatus)";
            try
            {
                dbConnect.Open();
                MySqlCommand cmdKosong = new MySqlCommand(queryKosong, dbConnect);
                cmdKosong.CommandTimeout = 60;
                cmdKosong.Parameters.AddWithValue("@voteNIK", textBoxIdUser.Text);
                cmdKosong.Parameters.AddWithValue("@voteAspirasiID", textBoxIdAspirasi.Text);
                if (UpOrDown == 1) cmdKosong.Parameters.AddWithValue("@voteStatus", 1);
                else if (UpOrDown == 0) cmdKosong.Parameters.AddWithValue("@voteStatus", 0);
                cmdKosong.ExecuteNonQuery();
                btnUpvote.Enabled = false;
                btnDownvote.Enabled = false;
                MessageBox.Show("Data berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.Close();
            }

            string queryUpdate = "UPDATE urut_aspirasi SET jumlah=@jumlah WHERE id = @pilihIDUrut";
            try
            {
                // Open the database
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(queryUpdate, dbConnect);
                cmd.CommandTimeout = 60;
                int hasilAkhir = Int32.Parse(textBoxJumlahVote.Text);
                if(UpOrDown == 1) cmd.Parameters.AddWithValue("@jumlah", hasilAkhir + 1);
                else if(UpOrDown == 0) cmd.Parameters.AddWithValue("@jumlah", hasilAkhir - 1);
                cmd.Parameters.AddWithValue("@pilihIDUrut", textBoxIdUrut.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.Close();
            }
            updateTextBoxJumlahTerkini();
            deteksiGerakan();
        }

        public void deteksiGerakan()
        {
            string query = "SELECT * FROM vote WHERE user_nik = @pilihNIKBro AND aspirasi_id = @pilihIDBro";
            try
            {
                dbConnect.Open();
                MySqlCommand cmdPilihJumlah = new MySqlCommand(query, dbConnect);
                cmdPilihJumlah.Parameters.AddWithValue("@pilihNIKBro", textBoxIdUser.Text);
                cmdPilihJumlah.Parameters.AddWithValue("@pilihIDBro", textBoxIdAspirasi.Text);
                cmdPilihJumlah.CommandTimeout = 60;
                MySqlDataReader reader = cmdPilihJumlah.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader["status_vote"].ToString().Equals("1"))
                        {
                            btnUpvote.Enabled = false;
                            btnDownvote.Enabled = false;
                        }
                        else
                        {
                            btnUpvote.Enabled = false;
                            btnDownvote.Enabled = false;
                        }
                    }

                    reader.Close();
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

        public void kirimVoteAda(int UpOrDown)
        {
            MessageBox.Show(""+UpOrDown);
            // buat vote kolom status_vote jadi 1 atau 0
            // buat urut_aspirasi kolom jumlah kurangi jadi -1 atau +1
            string queryVote = "UPDATE vote SET status_vote=@updateVote WHERE aspirasi_id = @pilihIDUrut";
            try
            {
                // Open the database
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(queryVote, dbConnect);
                cmd.CommandTimeout = 60;
                if (UpOrDown == 1) cmd.Parameters.AddWithValue("@updateVote", 0);
                else if (UpOrDown == 0) cmd.Parameters.AddWithValue("@updateVote", 1);
                cmd.Parameters.AddWithValue("@pilihIDUrut", textBoxIdAspirasi.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.Close();
            }
            updateTextBoxJumlahTerkini();

            string queryUrutAspirasi = "UPDATE urut_aspirasi SET status_vote=@updateVote WHERE aspirasi_id = @pilihIDUrut";
            try
            {
                // Open the database
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(queryVote, dbConnect);
                cmd.CommandTimeout = 60;
                int hasilAkhir = Int32.Parse(textBoxJumlahVote.Text);
                if (UpOrDown == 1) cmd.Parameters.AddWithValue("@updateVote", hasilAkhir + 1);
                else if (UpOrDown == 0) cmd.Parameters.AddWithValue("@updateVote", hasilAkhir - 1);
                cmd.Parameters.AddWithValue("@pilihIDUrut", textBoxIdAspirasi.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.Close();
            }
            updateTextBoxJumlahTerkini();
            deteksiGerakan();
        }

        private void FrmDetailAspirasi_Load(object sender, EventArgs e)
        {

        }
    }
}
