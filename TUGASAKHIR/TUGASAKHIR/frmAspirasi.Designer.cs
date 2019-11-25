namespace TUGASAKHIR
{
    partial class frmAspirasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNamaKomisi = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNIK = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listAspirasi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxIdKomisi = new System.Windows.Forms.TextBox();
            this.textBoxIdAspirasi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.labelNamaKomisi);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblNIK);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 61);
            this.panel1.TabIndex = 2;
            // 
            // labelNamaKomisi
            // 
            this.labelNamaKomisi.AutoSize = true;
            this.labelNamaKomisi.ForeColor = System.Drawing.Color.White;
            this.labelNamaKomisi.Location = new System.Drawing.Point(659, 18);
            this.labelNamaKomisi.Name = "labelNamaKomisi";
            this.labelNamaKomisi.Size = new System.Drawing.Size(97, 17);
            this.labelNamaKomisi.TabIndex = 3;
            this.labelNamaKomisi.Text = "NAMA KOMISI";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(331, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAMA";
            // 
            // lblNIK
            // 
            this.lblNIK.AutoSize = true;
            this.lblNIK.ForeColor = System.Drawing.Color.White;
            this.lblNIK.Location = new System.Drawing.Point(169, 18);
            this.lblNIK.Name = "lblNIK";
            this.lblNIK.Size = new System.Drawing.Size(30, 17);
            this.lblNIK.TabIndex = 1;
            this.lblNIK.Text = "NIK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listAspirasi
            // 
            this.listAspirasi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listAspirasi.GridLines = true;
            this.listAspirasi.Location = new System.Drawing.Point(123, 93);
            this.listAspirasi.Name = "listAspirasi";
            this.listAspirasi.Size = new System.Drawing.Size(665, 335);
            this.listAspirasi.TabIndex = 3;
            this.listAspirasi.UseCompatibleStateImageBehavior = false;
            this.listAspirasi.View = System.Windows.Forms.View.Details;
            this.listAspirasi.SelectedIndexChanged += new System.EventHandler(this.ListAspirasi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Judul";
            this.columnHeader2.Width = 541;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Jumlah";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tulis Aspirasi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxIdKomisi
            // 
            this.textBoxIdKomisi.Location = new System.Drawing.Point(12, 406);
            this.textBoxIdKomisi.Name = "textBoxIdKomisi";
            this.textBoxIdKomisi.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdKomisi.TabIndex = 5;
            // 
            // textBoxIdAspirasi
            // 
            this.textBoxIdAspirasi.Location = new System.Drawing.Point(12, 378);
            this.textBoxIdAspirasi.Name = "textBoxIdAspirasi";
            this.textBoxIdAspirasi.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdAspirasi.TabIndex = 6;
            // 
            // frmAspirasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxIdAspirasi);
            this.Controls.Add(this.textBoxIdKomisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listAspirasi);
            this.Controls.Add(this.panel1);
            this.Name = "frmAspirasi";
            this.Text = "Form Aspirasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNIK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listAspirasi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNamaKomisi;
        private System.Windows.Forms.TextBox textBoxIdKomisi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBoxIdAspirasi;
    }
}

