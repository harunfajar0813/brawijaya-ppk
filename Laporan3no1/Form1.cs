using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laporan3no1
{
    public partial class Form1 : Form
    {
        String ActiveForm;
        List<FormPict> frmPict = new List<FormPict>();
        List<ToolStripMenuItem> tsItem = new List<ToolStripMenuItem>();
        ToolStripMenuItem ts;
        public event PropertyChangedEventHandler PropertyChanged;

        private int AllDegree;
        public int AllDegree1
        {
            get
            {
                return AllDegree;
            }
            set
            {
                AllDegree = value;
            }
        }


        private void OnPropertyChanged(String v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
            ToolStripMenuItem item = (ToolStripMenuItem)menuStrip1.Items["windowToolStripMenuItem"];
            foreach (ToolStripMenuItem itemChecked in item.DropDownItems)
            {
                if (!itemChecked.Text.Equals(v))
                    itemChecked.Checked = false;
                else
                    itemChecked.Checked = true;
            }
        }

        public string ActiveForm1
        {
            get
            {
                return ActiveForm;
            }
            set
            {
                ActiveForm = value;
                OnPropertyChanged(ActiveForm);
            }
        }

        public Form1()
        {
            InitializeComponent();
            FormPict Fp;
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                frmPict.Add(new FormPict(this)
                {
                    Text = System.IO.Path.GetFileName(openFileDialog1.FileName),
                    MdiParent = this
                });
            }
            frmPict[frmPict.Count - 1].setPic(Image.FromFile(openFileDialog1.FileName));
            frmPict[frmPict.Count - 1].Show();
            ToolStripMenuItem item = (ToolStripMenuItem)menuStrip1.Items["windowToolStripMenuItem"];
            foreach(ToolStripMenuItem itemChecked in item.DropDownItems)
            {
                itemChecked.Checked = false;
            }
            tsItem.Add(new ToolStripMenuItem(null, null, ItemClick)
            {
                Text = System.IO.Path.GetFileName(openFileDialog1.FileName),
                Checked = true
            });
            item.DropDownItems.Add(tsItem[tsItem.Count - 1]);
        }

        private void ItemClick(Object sender, EventArgs e)
        {
            var tms = (ToolStripMenuItem)sender;
            for(int i=0; i<frmPict.Count; i++)
            {
                if(String.Equals(frmPict[i].Text, tms.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    frmPict[i].Activate();
                }
            }
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            FormPict tempChild = (FormPict)this.ActiveMdiChild;
            tempChild.PutarKanan();
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            FormPict tempChild = (FormPict)this.ActiveMdiChild;
            tempChild.PutarKiri();
        }

        private int AllWidth;
        public int AllWidht1
        {
            get
            {
                return AllWidth;
            }
            set
            {
                AllWidth = value;
            }
        }

        private int AllHeight;
        public int AllHeight1
        {
            get
            {
                return AllHeight;
            }
            set
            {
                AllHeight = value;
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            FormPict tempChild = (FormPict)this.ActiveMdiChild;
            if (tempChild == null)
            {
                MessageBox.Show("No Image", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                tempChild.ZoomIn();
            }
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            FormPict tempChild = (FormPict)this.ActiveMdiChild;
            if (tempChild == null)
            {
                MessageBox.Show("No Image", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                tempChild.ZoomOut();
            }
        }
    }
}
