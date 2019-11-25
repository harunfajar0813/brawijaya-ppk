namespace Laporan1no8
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBukaFile = new System.Windows.Forms.Button();
            this.tbNamaFile = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dlgBukaFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File yang dipilih";
            // 
            // btnBukaFile
            // 
            this.btnBukaFile.Location = new System.Drawing.Point(392, 134);
            this.btnBukaFile.Name = "btnBukaFile";
            this.btnBukaFile.Size = new System.Drawing.Size(75, 23);
            this.btnBukaFile.TabIndex = 1;
            this.btnBukaFile.Text = "Buka File";
            this.btnBukaFile.UseVisualStyleBackColor = true;
            this.btnBukaFile.Click += new System.EventHandler(this.BtnBukaFile_Click);
            // 
            // tbNamaFile
            // 
            this.tbNamaFile.Location = new System.Drawing.Point(248, 170);
            this.tbNamaFile.Multiline = true;
            this.tbNamaFile.Name = "tbNamaFile";
            this.tbNamaFile.ReadOnly = true;
            this.tbNamaFile.Size = new System.Drawing.Size(219, 20);
            this.tbNamaFile.TabIndex = 2;
            this.tbNamaFile.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Keluar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dlgBukaFile
            // 
            this.dlgBukaFile.FileName = "dlgBukaFile ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbNamaFile);
            this.Controls.Add(this.btnBukaFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HarunUlumFajar-185150207111011";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBukaFile;
        private System.Windows.Forms.TextBox tbNamaFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog dlgBukaFile;
    }
}

