namespace Laporan2
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
            this.btUbah1 = new System.Windows.Forms.Button();
            this.btUbah2 = new System.Windows.Forms.Button();
            this.btUbah3 = new System.Windows.Forms.Button();
            this.lbHelo1 = new System.Windows.Forms.Label();
            this.lbHelo2 = new System.Windows.Forms.Label();
            this.lbHelo3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btUbah1
            // 
            this.btUbah1.Location = new System.Drawing.Point(0, 0);
            this.btUbah1.Name = "btUbah1";
            this.btUbah1.Size = new System.Drawing.Size(110, 23);
            this.btUbah1.TabIndex = 0;
            this.btUbah1.Text = "Ubah Label1";
            this.btUbah1.UseVisualStyleBackColor = true;
            this.btUbah1.Click += new System.EventHandler(this.lihatData);
            // 
            // btUbah2
            // 
            this.btUbah2.Location = new System.Drawing.Point(0, 29);
            this.btUbah2.Name = "btUbah2";
            this.btUbah2.Size = new System.Drawing.Size(110, 23);
            this.btUbah2.TabIndex = 1;
            this.btUbah2.Text = "Ubah Label2";
            this.btUbah2.UseVisualStyleBackColor = true;
            this.btUbah2.Click += new System.EventHandler(this.cetakLaporan);
            // 
            // btUbah3
            // 
            this.btUbah3.Location = new System.Drawing.Point(0, 58);
            this.btUbah3.Name = "btUbah3";
            this.btUbah3.Size = new System.Drawing.Size(110, 23);
            this.btUbah3.TabIndex = 2;
            this.btUbah3.Text = "Ubah Label3";
            this.btUbah3.UseVisualStyleBackColor = true;
            this.btUbah3.Click += new System.EventHandler(this.tutupAplikasi);
            // 
            // lbHelo1
            // 
            this.lbHelo1.AutoSize = true;
            this.lbHelo1.Location = new System.Drawing.Point(141, 10);
            this.lbHelo1.Name = "lbHelo1";
            this.lbHelo1.Size = new System.Drawing.Size(83, 13);
            this.lbHelo1.TabIndex = 3;
            this.lbHelo1.Text = "Platofrm Khusus";
            // 
            // lbHelo2
            // 
            this.lbHelo2.AutoSize = true;
            this.lbHelo2.Location = new System.Drawing.Point(141, 39);
            this.lbHelo2.Name = "lbHelo2";
            this.lbHelo2.Size = new System.Drawing.Size(83, 13);
            this.lbHelo2.TabIndex = 4;
            this.lbHelo2.Text = "Platofrm Khusus";
            // 
            // lbHelo3
            // 
            this.lbHelo3.AutoSize = true;
            this.lbHelo3.Location = new System.Drawing.Point(141, 68);
            this.lbHelo3.Name = "lbHelo3";
            this.lbHelo3.Size = new System.Drawing.Size(83, 13);
            this.lbHelo3.TabIndex = 5;
            this.lbHelo3.Text = "Platofrm Khusus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbHelo3);
            this.Controls.Add(this.lbHelo2);
            this.Controls.Add(this.lbHelo1);
            this.Controls.Add(this.btUbah3);
            this.Controls.Add(this.btUbah2);
            this.Controls.Add(this.btUbah1);
            this.Name = "Form1";
            this.Text = "HarunUlumFajar-185150207111011";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUbah1;
        private System.Windows.Forms.Button btUbah2;
        private System.Windows.Forms.Button btUbah3;
        private System.Windows.Forms.Label lbHelo1;
        private System.Windows.Forms.Label lbHelo2;
        private System.Windows.Forms.Label lbHelo3;
    }
}

