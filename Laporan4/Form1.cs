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

namespace Laporan4
{
    public partial class Form1 : Form
    {
        private static string connect = string.Format("Server=localhost; port=3306; username=root; password=;database=perpustakaan");
        private MySqlConnection dbConnect = new MySqlConnection(connect);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
            refreshPinjam();
            comboFill();
            string query = "SELECT * FROM data_buku";
            string query1 = "SELECT * FROM data_buku WHERE id_buku = 3";
            MySqlCommand cmdea = new MySqlCommand(query1, dbConnect);
            MySqlDataReader readerea = cmdea.ExecuteReader();
            textBox2.Text = readerea["jumlah"].ToString();
        }

        public void refresh()
        {
            listView1.Items.Clear();
            string query = "SELECT * FROM data_buku";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["pengarang"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listView1.Items.Add(listViewItem);
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

        private void Button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO data_buku (id_buku, judul, pengarang, jumlah) VALUES (@id, @judul, @pengarang, @jumlah)"; 
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@judul", textBox2.Text);
                cmd.Parameters.AddWithValue("@pengarang", textBox3.Text);
                cmd.Parameters.AddWithValue("@jumlah", textBox4.Text);
                cmd.ExecuteNonQuery();
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
            refresh();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM data_buku WHERE id_buku = @id";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.Close();
            }
            refresh();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string query = "UPDATE data_buku SET judul = @judul, pengarang=@pengarang, jumlah = @jumlah WHERE id_buku = @id";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@judul", textBox2.Text);
                cmd.Parameters.AddWithValue("@pengarang", textBox3.Text);
                cmd.Parameters.AddWithValue("@jumlah", textBox4.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.Close();
            }
            refresh();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView1.SelectedItems[0];
            textBox1.Text = item.SubItems[0].Text;
            textBox2.Text = item.SubItems[1].Text;
            textBox3.Text = item.SubItems[2].Text;
            textBox4.Text = item.SubItems[3].Text;
        }

        // nomer 3
        public void resultQuery(Object sender, EventArgs e)
        {
            string query = "";
            Button tekan = (Button)sender;
            if(tekan == button1)
            {
                query = "SELECT * FROM data_buku WHERE judul = @cariJudul";
                resultOf(query,1);
            }
            else
            {
                query = "SELECT * FROM data_buku WHERE pengarang = @cariPengarang";
                resultOf(query,2);
            }
        }

        public void resultOf(string finalQuery, int number)
        {
            listView1.Items.Clear();
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(finalQuery, dbConnect);
                if (number == 1) cmd.Parameters.Add(new MySqlParameter("@cariJudul", textBox5.Text));
                else cmd.Parameters.Add(new MySqlParameter("@cariPengarang", textBox5.Text));
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["pengarang"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listView1.Items.Add(listViewItem);
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
        } // nomer 3 

        // nomer 4
        public void refreshPinjam()
        {
            listView3.Items.Clear();
            string query = "SELECT * FROM mahasiswa";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["nim"].ToString());
                        listViewItem.SubItems.Add(reader["nama"].ToString());
                        listView3.Items.Add(listViewItem);
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

            listView2.Items.Clear();
            string queryPinjam = "SELECT * FROM data_pinjam";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(queryPinjam, dbConnect);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader1 = cmd.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader1["id"].ToString());
                        listViewItem.SubItems.Add(reader1["mahasiswaID"].ToString());
                        listViewItem.SubItems.Add(reader1["bukuID"].ToString());
                        listView2.Items.Add(listViewItem);
                    }
                    reader1.Close();
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
        private void Button6_Click(object sender, EventArgs e) 
        {
            string query = "INSERT INTO mahasiswa (nim, nama) VALUES (@nimMHS, @namaMHS)";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nimMHS", textBox6.Text);
                cmd.Parameters.AddWithValue("@namaMHS", textBox7.Text);
                cmd.ExecuteNonQuery();
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
            refreshPinjam();
            comboFill();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM mahasiswa WHERE nim = @nimMHS";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nimMHS", textBox6.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.Close();
            }
            refreshPinjam();
        }

        private void ListView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView3.SelectedItems[0];
            textBox6.Text = item.SubItems[0].Text;
            textBox7.Text = item.SubItems[1].Text;
        }

        public void comboFill()
        {
            string queryMahasiswa = "SELECT * FROM mahasiswa";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd1 = new MySqlCommand(queryMahasiswa, dbConnect);
                cmd1.CommandTimeout = 60;
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        comboBox1.Items.Add(reader1.GetString("nim"));
                    }
                    reader1.Close();

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

            string queryBuku = "SELECT * FROM data_buku";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd2 = new MySqlCommand(queryBuku, dbConnect);
                cmd2.CommandTimeout = 60;
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        comboBox2.Items.Add(reader2.GetString("id_buku"));
                    }
                    reader2.Close();

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

        private void Button8_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO data_pinjam (mahasiswaID, bukuID) VALUES (@mahasiswaPinjam, @bukuPinjam)";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@mahasiswaPinjam", comboBox1.Text);
                cmd.Parameters.AddWithValue("@bukuPinjam", comboBox2.Text);
                cmd.ExecuteNonQuery();
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
            refreshPinjam();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM data_pinjam WHERE id = @idPinjam";
            try
            {
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@idPinjam", textBox8.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.Close();
            }
            refreshPinjam();
        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView2.SelectedItems[0];
            textBox8.Text = item.SubItems[0].Text;
            comboBox1.Text = item.SubItems[1].Text;
            comboBox2.Text = item.SubItems[2].Text;
        }
        // nomer 4
    }
}
