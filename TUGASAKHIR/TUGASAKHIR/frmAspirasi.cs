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
    public partial class frmAspirasi : Form
    {
        private static string connect = string.Format("Server=localhost; port=3306; username=root; password=;database=utarain_db");
        private MySqlConnection dbConnect = new MySqlConnection(connect);
        public frmAspirasi()
        {
            InitializeComponent();
        }

        public frmAspirasi(String resultFinish)
        {
            refreshDariFormDetail(resultFinish);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void setValueAspirasi(string nik, string nama, string idKomisi, string namaKomisi)
        {

            lblNIK.Text = nik;
            lblName.Text = nama;
            labelNamaKomisi.Text = namaKomisi;
            textBoxIdKomisi.Text = idKomisi;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAspirasi formAspirasi = new frmAspirasi();
            FormKirim formKirim = new FormKirim();
            // Masuk ke Form Kirim
            // constuctor kirim nik, idKomisi
            Hide();
            formKirim.setValue(lblNIK.Text, textBoxIdKomisi.Text);
            formAspirasi.Close();
            formKirim.ShowDialog();
            Show();
        }

        public void refresh()
        {
            listAspirasi.Items.Clear();
            string query = "SELECT aspirasi.judul, aspirasi.komisi_id, urut_aspirasi.id, urut_aspirasi.jumlah FROM urut_aspirasi JOIN aspirasi ON urut_aspirasi.aspirasi_id=aspirasi.id WHERE komisi_id=@pilihKomisiID ORDER BY urut_aspirasi.jumlah DESC";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.Parameters.AddWithValue("@pilihKomisiID", textBoxIdKomisi.Text);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["id"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listAspirasi.Items.Add(listViewItem);
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

        private void ListAspirasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAspirasi.SelectedItems.Count == 0)
                return;

            ListViewItem item = listAspirasi.SelectedItems[0];

            string query = "SELECT * FROM urut_aspirasi WHERE id = @urutPilihId";
            try
            {
                // Open the database
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.Parameters.AddWithValue("@urutPilihId", item.SubItems[0].Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBoxIdAspirasi.Text = reader.GetString("aspirasi_id");
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

            Hide();
            frmAspirasi formAspirasi = new frmAspirasi();
            frmDetailAspirasi formDetail = new frmDetailAspirasi(item.SubItems[0].Text, item.SubItems[1].Text, textBoxIdAspirasi.Text, lblNIK.Text, item.SubItems[0].Text, textBoxIdKomisi.Text);
            formAspirasi.Close();
            formDetail.ShowDialog();
            formDetail.Hide();
            Show();
        }

        public void refreshDariFormDetail(String resultFinish)
        {
            listAspirasi.Items.Clear();
            string query = "SELECT aspirasi.judul, aspirasi.komisi_id, urut_aspirasi.id, urut_aspirasi.jumlah FROM urut_aspirasi JOIN aspirasi ON urut_aspirasi.aspirasi_id=aspirasi.id WHERE komisi_id=@pilihKomisiID ORDER BY urut_aspirasi.jumlah DESC";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.Parameters.AddWithValue("@pilihKomisiID", resultFinish);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["id"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listAspirasi.Items.Add(listViewItem);
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
    }
}
