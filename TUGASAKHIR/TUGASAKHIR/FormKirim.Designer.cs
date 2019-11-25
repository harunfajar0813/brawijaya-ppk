namespace TUGASAKHIR
{
    partial class FormKirim
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
            this.textKirimJudul = new System.Windows.Forms.TextBox();
            this.textKirimIsi = new System.Windows.Forms.TextBox();
            this.btnKirimAspirasi = new System.Windows.Forms.Button();
            this.textBoxIdKomisi = new System.Windows.Forms.TextBox();
            this.textBoxIdUser = new System.Windows.Forms.TextBox();
            this.textBoxIdAspirasi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kirim Aspirasi";
            // 
            // textKirimJudul
            // 
            this.textKirimJudul.Location = new System.Drawing.Point(52, 65);
            this.textKirimJudul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textKirimJudul.Multiline = true;
            this.textKirimJudul.Name = "textKirimJudul";
            this.textKirimJudul.Size = new System.Drawing.Size(494, 35);
            this.textKirimJudul.TabIndex = 1;
            // 
            // textKirimIsi
            // 
            this.textKirimIsi.Location = new System.Drawing.Point(52, 115);
            this.textKirimIsi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textKirimIsi.Multiline = true;
            this.textKirimIsi.Name = "textKirimIsi";
            this.textKirimIsi.Size = new System.Drawing.Size(494, 226);
            this.textKirimIsi.TabIndex = 2;
            // 
            // btnKirimAspirasi
            // 
            this.btnKirimAspirasi.Location = new System.Drawing.Point(423, 354);
            this.btnKirimAspirasi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKirimAspirasi.Name = "btnKirimAspirasi";
            this.btnKirimAspirasi.Size = new System.Drawing.Size(122, 27);
            this.btnKirimAspirasi.TabIndex = 3;
            this.btnKirimAspirasi.Text = "Kirim Aspirasi";
            this.btnKirimAspirasi.UseVisualStyleBackColor = true;
            this.btnKirimAspirasi.Click += new System.EventHandler(this.BtnKirimAspirasi_Click);
            // 
            // textBoxIdKomisi
            // 
            this.textBoxIdKomisi.Location = new System.Drawing.Point(52, 345);
            this.textBoxIdKomisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIdKomisi.Name = "textBoxIdKomisi";
            this.textBoxIdKomisi.Size = new System.Drawing.Size(76, 20);
            this.textBoxIdKomisi.TabIndex = 4;
            // 
            // textBoxIdUser
            // 
            this.textBoxIdUser.Location = new System.Drawing.Point(131, 345);
            this.textBoxIdUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIdUser.Name = "textBoxIdUser";
            this.textBoxIdUser.Size = new System.Drawing.Size(76, 20);
            this.textBoxIdUser.TabIndex = 5;
            // 
            // textBoxIdAspirasi
            // 
            this.textBoxIdAspirasi.Location = new System.Drawing.Point(423, 386);
            this.textBoxIdAspirasi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIdAspirasi.Name = "textBoxIdAspirasi";
            this.textBoxIdAspirasi.Size = new System.Drawing.Size(76, 20);
            this.textBoxIdAspirasi.TabIndex = 6;
            // 
            // FormKirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 416);
            this.Controls.Add(this.textBoxIdAspirasi);
            this.Controls.Add(this.textBoxIdUser);
            this.Controls.Add(this.textBoxIdKomisi);
            this.Controls.Add(this.btnKirimAspirasi);
            this.Controls.Add(this.textKirimIsi);
            this.Controls.Add(this.textKirimJudul);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKirim";
            this.Text = "FormKirim";
            this.Load += new System.EventHandler(this.FormKirim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKirimJudul;
        private System.Windows.Forms.TextBox textKirimIsi;
        private System.Windows.Forms.Button btnKirimAspirasi;
        private System.Windows.Forms.TextBox textBoxIdKomisi;
        private System.Windows.Forms.TextBox textBoxIdUser;
        private System.Windows.Forms.TextBox textBoxIdAspirasi;
    }
}