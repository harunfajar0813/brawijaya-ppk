namespace TUGASAKHIR
{
    partial class frmPilihKomisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNIK = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxKomisi = new System.Windows.Forms.ComboBox();
            this.btnSampaikan = new System.Windows.Forms.Button();
            this.textBoxGetIdKomisi = new System.Windows.Forms.TextBox();
            this.textBoxGetNamaKomisi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILIH KOMISI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblNIK);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 61);
            this.panel1.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(441, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAMA";
            // 
            // lblNIK
            // 
            this.lblNIK.AutoSize = true;
            this.lblNIK.ForeColor = System.Drawing.Color.White;
            this.lblNIK.Location = new System.Drawing.Point(202, 18);
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
            // comboBoxKomisi
            // 
            this.comboBoxKomisi.FormattingEnabled = true;
            this.comboBoxKomisi.Location = new System.Drawing.Point(217, 172);
            this.comboBoxKomisi.Name = "comboBoxKomisi";
            this.comboBoxKomisi.Size = new System.Drawing.Size(283, 24);
            this.comboBoxKomisi.TabIndex = 2;
            this.comboBoxKomisi.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKomisi_SelectedIndexChanged);
            // 
            // btnSampaikan
            // 
            this.btnSampaikan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSampaikan.Location = new System.Drawing.Point(289, 202);
            this.btnSampaikan.Name = "btnSampaikan";
            this.btnSampaikan.Size = new System.Drawing.Size(134, 54);
            this.btnSampaikan.TabIndex = 3;
            this.btnSampaikan.Text = "SAMPAIKAN \r\nASPIRASI";
            this.btnSampaikan.UseVisualStyleBackColor = true;
            this.btnSampaikan.Click += new System.EventHandler(this.BtnSampaikan_Click);
            // 
            // textBoxGetIdKomisi
            // 
            this.textBoxGetIdKomisi.Location = new System.Drawing.Point(12, 79);
            this.textBoxGetIdKomisi.Name = "textBoxGetIdKomisi";
            this.textBoxGetIdKomisi.Size = new System.Drawing.Size(100, 22);
            this.textBoxGetIdKomisi.TabIndex = 4;
            // 
            // textBoxGetNamaKomisi
            // 
            this.textBoxGetNamaKomisi.Location = new System.Drawing.Point(12, 107);
            this.textBoxGetNamaKomisi.Name = "textBoxGetNamaKomisi";
            this.textBoxGetNamaKomisi.Size = new System.Drawing.Size(100, 22);
            this.textBoxGetNamaKomisi.TabIndex = 5;
            // 
            // frmPilihKomisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(730, 357);
            this.Controls.Add(this.textBoxGetNamaKomisi);
            this.Controls.Add(this.textBoxGetIdKomisi);
            this.Controls.Add(this.btnSampaikan);
            this.Controls.Add(this.comboBoxKomisi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmPilihKomisi";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNIK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxKomisi;
        private System.Windows.Forms.Button btnSampaikan;
        private System.Windows.Forms.TextBox textBoxGetIdKomisi;
        private System.Windows.Forms.TextBox textBoxGetNamaKomisi;
    }
}