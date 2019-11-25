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
    public partial class Form1 : Form
    {
        private static string connect = string.Format("Server=localhost; port=3306; username=root; password=;database=quiz_ppk");
        private MySqlConnection dbConnect = new MySqlConnection(connect);
        public Form1()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                textBox5.Text = openFileDialog1.FileName;
            }
        }

        public void refresh() {
            listView1.Items.Clear();
            string query = "SELECT * FROM mhs";
            try
            {
                // Open the database
                dbConnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["nim"].ToString());
                        listViewItem.SubItems.Add(reader["nama"].ToString());
                        listViewItem.SubItems.Add(reader["alamat"].ToString());
                        listViewItem.SubItems.Add(reader["tempat_lahir"].ToString());
                        listViewItem.SubItems.Add(reader["tgl_lahir"].ToString());
                        listViewItem.SubItems.Add(reader["path_foto"].ToString());
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
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.Close();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int nimMahasiswa;
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                if(!int.TryParse(textBox1.Text, out nimMahasiswa))
                {
                    MessageBox.Show("NIM Haruslah angka");
                } else
                {
                    MessageBox.Show("Terdapat bagian kosong");
                }
            }
            else
            {
                string createQuery = "INSERT INTO mhs (nim, nama, alamat, tempat_lahir, tgl_lahir, path_foto) VALUES (@nim,@nama,@alamat,@tempat_lahir,@tgl_lahir,@path_foto)";
                try
                {
                    dbConnect.Open();
                    MySqlCommand perintah = new MySqlCommand(createQuery, dbConnect);
                    perintah.CommandTimeout = 60;
                    perintah.Parameters.AddWithValue("@nim", textBox1.Text);
                    perintah.Parameters.AddWithValue("@nama", textBox2.Text);
                    perintah.Parameters.AddWithValue("@alamat", textBox3.Text);
                    perintah.Parameters.AddWithValue("@tempat_lahir", textBox4.Text);
                    perintah.Parameters.AddWithValue("@tgl_lahir", dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString());
                    perintah.Parameters.AddWithValue("@path_foto", textBox5.Text);
                    perintah.ExecuteNonQuery();
                    MessageBox.Show("Success!");
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
            }
            
            
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection pilihan = listView1.SelectedIndices;
            if(pilihan.Count == 1)
            {
                ListViewItem setItem = listView1.Items[pilihan[0]];
                Form2 form2 = new Form2(setItem.SubItems[0].Text, setItem.SubItems[1].Text, setItem.SubItems[2].Text, setItem.SubItems[3].Text, setItem.SubItems[4].Text, setItem.SubItems[5].Text);
                //form2.makeValue(setItem.SubItems[0].Text, setItem.SubItems[1].Text, setItem.SubItems[2].Text, setItem.SubItems[3].Text, setItem.SubItems[4].Text, setItem.SubItems[5].Text);
                form2.Show();
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    refresh();
                    break;
            }
        }
    }
}
