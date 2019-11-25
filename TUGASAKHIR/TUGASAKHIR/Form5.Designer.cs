namespace KirimAspirasi
{
    partial class frmKirimAspirasi
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
            this.textKirimJudulAspirasi = new System.Windows.Forms.TextBox();
            this.textKirimIsiAspirasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKirimAspirasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textKirimJudulAspirasi
            // 
            this.textKirimJudulAspirasi.Location = new System.Drawing.Point(51, 58);
            this.textKirimJudulAspirasi.Multiline = true;
            this.textKirimJudulAspirasi.Name = "textKirimJudulAspirasi";
            this.textKirimJudulAspirasi.Size = new System.Drawing.Size(520, 43);
            this.textKirimJudulAspirasi.TabIndex = 0;
            // 
            // textKirimIsiAspirasi
            // 
            this.textKirimIsiAspirasi.Location = new System.Drawing.Point(51, 117);
            this.textKirimIsiAspirasi.Multiline = true;
            this.textKirimIsiAspirasi.Name = "textKirimIsiAspirasi";
            this.textKirimIsiAspirasi.Size = new System.Drawing.Size(520, 252);
            this.textKirimIsiAspirasi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kirim Aspirasi";
            // 
            // btnKirimAspirasi
            // 
            this.btnKirimAspirasi.Location = new System.Drawing.Point(456, 385);
            this.btnKirimAspirasi.Name = "btnKirimAspirasi";
            this.btnKirimAspirasi.Size = new System.Drawing.Size(115, 32);
            this.btnKirimAspirasi.TabIndex = 3;
            this.btnKirimAspirasi.Text = "Kirim Aspirasi";
            this.btnKirimAspirasi.UseVisualStyleBackColor = true;
            // 
            // frmKirimAspirasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 459);
            this.Controls.Add(this.btnKirimAspirasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textKirimIsiAspirasi);
            this.Controls.Add(this.textKirimJudulAspirasi);
            this.Name = "frmKirimAspirasi";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textKirimJudulAspirasi;
        private System.Windows.Forms.TextBox textKirimIsiAspirasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKirimAspirasi;
    }
}

