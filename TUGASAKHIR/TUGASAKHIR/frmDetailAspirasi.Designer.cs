namespace TUGASAKHIR
{
    partial class frmDetailAspirasi
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
            this.textJudulAspirasi = new System.Windows.Forms.TextBox();
            this.btnUpvote = new System.Windows.Forms.Button();
            this.btnDownvote = new System.Windows.Forms.Button();
            this.textDetailAspirasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdUser = new System.Windows.Forms.TextBox();
            this.textBoxIdAspirasi = new System.Windows.Forms.TextBox();
            this.textBoxJumlahVote = new System.Windows.Forms.TextBox();
            this.textBoxIdUrut = new System.Windows.Forms.TextBox();
            this.textBoxIdKomisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textJudulAspirasi
            // 
            this.textJudulAspirasi.Location = new System.Drawing.Point(167, 70);
            this.textJudulAspirasi.Margin = new System.Windows.Forms.Padding(4);
            this.textJudulAspirasi.Multiline = true;
            this.textJudulAspirasi.Name = "textJudulAspirasi";
            this.textJudulAspirasi.Size = new System.Drawing.Size(624, 40);
            this.textJudulAspirasi.TabIndex = 0;
            // 
            // btnUpvote
            // 
            this.btnUpvote.Location = new System.Drawing.Point(37, 129);
            this.btnUpvote.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpvote.Name = "btnUpvote";
            this.btnUpvote.Size = new System.Drawing.Size(100, 84);
            this.btnUpvote.TabIndex = 1;
            this.btnUpvote.Text = "Upvote";
            this.btnUpvote.UseVisualStyleBackColor = true;
            this.btnUpvote.Click += new System.EventHandler(this.chooseButton);
            // 
            // btnDownvote
            // 
            this.btnDownvote.Location = new System.Drawing.Point(37, 235);
            this.btnDownvote.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownvote.Name = "btnDownvote";
            this.btnDownvote.Size = new System.Drawing.Size(100, 81);
            this.btnDownvote.TabIndex = 2;
            this.btnDownvote.Text = "Downvote";
            this.btnDownvote.UseVisualStyleBackColor = true;
            this.btnDownvote.Click += new System.EventHandler(this.chooseButton);
            // 
            // textDetailAspirasi
            // 
            this.textDetailAspirasi.Location = new System.Drawing.Point(167, 129);
            this.textDetailAspirasi.Margin = new System.Windows.Forms.Padding(4);
            this.textDetailAspirasi.Multiline = true;
            this.textDetailAspirasi.Name = "textDetailAspirasi";
            this.textDetailAspirasi.Size = new System.Drawing.Size(624, 347);
            this.textDetailAspirasi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detail Aspirasi";
            // 
            // textBoxIdUser
            // 
            this.textBoxIdUser.Location = new System.Drawing.Point(37, 454);
            this.textBoxIdUser.Name = "textBoxIdUser";
            this.textBoxIdUser.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdUser.TabIndex = 5;
            // 
            // textBoxIdAspirasi
            // 
            this.textBoxIdAspirasi.Location = new System.Drawing.Point(37, 426);
            this.textBoxIdAspirasi.Name = "textBoxIdAspirasi";
            this.textBoxIdAspirasi.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdAspirasi.TabIndex = 6;
            // 
            // textBoxJumlahVote
            // 
            this.textBoxJumlahVote.Location = new System.Drawing.Point(37, 70);
            this.textBoxJumlahVote.Name = "textBoxJumlahVote";
            this.textBoxJumlahVote.Size = new System.Drawing.Size(100, 22);
            this.textBoxJumlahVote.TabIndex = 7;
            // 
            // textBoxIdUrut
            // 
            this.textBoxIdUrut.Location = new System.Drawing.Point(37, 99);
            this.textBoxIdUrut.Name = "textBoxIdUrut";
            this.textBoxIdUrut.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdUrut.TabIndex = 8;
            // 
            // textBoxIdKomisi
            // 
            this.textBoxIdKomisi.Location = new System.Drawing.Point(37, 398);
            this.textBoxIdKomisi.Name = "textBoxIdKomisi";
            this.textBoxIdKomisi.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdKomisi.TabIndex = 9;
            // 
            // frmDetailAspirasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 510);
            this.Controls.Add(this.textBoxIdKomisi);
            this.Controls.Add(this.textBoxIdUrut);
            this.Controls.Add(this.textBoxJumlahVote);
            this.Controls.Add(this.textBoxIdAspirasi);
            this.Controls.Add(this.textBoxIdUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDetailAspirasi);
            this.Controls.Add(this.btnDownvote);
            this.Controls.Add(this.btnUpvote);
            this.Controls.Add(this.textJudulAspirasi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDetailAspirasi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmDetailAspirasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textJudulAspirasi;
        private System.Windows.Forms.Button btnUpvote;
        private System.Windows.Forms.Button btnDownvote;
        private System.Windows.Forms.TextBox textDetailAspirasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdUser;
        private System.Windows.Forms.TextBox textBoxIdAspirasi;
        private System.Windows.Forms.TextBox textBoxJumlahVote;
        private System.Windows.Forms.TextBox textBoxIdUrut;
        private System.Windows.Forms.TextBox textBoxIdKomisi;
    }
}

