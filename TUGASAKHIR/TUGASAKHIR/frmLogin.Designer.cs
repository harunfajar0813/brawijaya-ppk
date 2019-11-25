namespace TUGASAKHIR
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.textNIK = new System.Windows.Forms.TextBox();
            this.textTanggal = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textNIK
            // 
            this.textNIK.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNIK.Location = new System.Drawing.Point(75, 219);
            this.textNIK.Name = "textNIK";
            this.textNIK.Size = new System.Drawing.Size(323, 38);
            this.textNIK.TabIndex = 2;
            this.textNIK.Text = "185150200123012";
            // 
            // textTanggal
            // 
            this.textTanggal.Font = new System.Drawing.Font("School Times", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTanggal.ForeColor = System.Drawing.Color.Black;
            this.textTanggal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textTanggal.Location = new System.Drawing.Point(75, 265);
            this.textTanggal.Name = "textTanggal";
            this.textTanggal.Size = new System.Drawing.Size(323, 36);
            this.textTanggal.TabIndex = 3;
            this.textTanggal.Tag = "";
            this.textTanggal.Text = "26052000";
            this.textTanggal.UseSystemPasswordChar = true;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Transparent;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLog.ForeColor = System.Drawing.Color.Black;
            this.btnLog.Location = new System.Drawing.Point(310, 321);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(87, 35);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "LOGIN";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.UseWaitCursor = true;
            this.btnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.textTanggal);
            this.Controls.Add(this.textNIK);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNIK;
        private System.Windows.Forms.TextBox textTanggal;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

