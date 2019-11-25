namespace Laporan1no7
{
    partial class Form1
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
            this.btnGantiFont = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // btnGantiFont
            // 
            this.btnGantiFont.Location = new System.Drawing.Point(189, 144);
            this.btnGantiFont.Name = "btnGantiFont";
            this.btnGantiFont.Size = new System.Drawing.Size(75, 23);
            this.btnGantiFont.TabIndex = 0;
            this.btnGantiFont.Text = "Ganti Font";
            this.btnGantiFont.UseVisualStyleBackColor = true;
            this.btnGantiFont.Click += new System.EventHandler(this.BtnGantiFont_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(321, 144);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 1;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(275, 63);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(100, 23);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Hello World";
            // 
            // dlgFont
            // 
            this.dlgFont.ShowApply = true;
            this.dlgFont.ShowColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnGantiFont);
            this.Name = "Form1";
            this.Text = "HarunUlumFajar-185150207111011";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGantiFont;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.FontDialog dlgFont;
    }
}

