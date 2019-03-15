using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmMDIMain_Old : Form
    {
        public frmMDIMain_Old()
        {
            InitializeComponent();
        }

        private void frmMDIMain_Activated(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.splitContainer1.Dock = DockStyle.Fill;

            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;
            f1.TopLevel = false;
            //this.splitContainer1.Panel2.Controls.Add(f1);
            
            

            f1.Show();
            f1.Dock = DockStyle.Fill;
            
        }

        private void frmMDIMain_MdiChildActivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(this.tsParent);
            IChildForm ChildForm = ActiveMdiChild as IChildForm;
            if (ChildForm != null)
            {
                ToolStripManager.Merge(ChildForm.ChildToolStrip, tsParent);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.splitContainer1.Dock = DockStyle.Fill;

            Form2 f1 = new Form2();
            f1.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;
            f1.TopLevel = false;
            //this.splitContainer1.Panel2.Controls.Add(f1
            f1.Show();
            f1.Dock = DockStyle.Fill;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.splitContainer1.Dock = DockStyle.Fill;

            Form3 f1 = new Form3();
            f1.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;
            f1.TopLevel = false;
            //this.splitContainer1.Panel2.Controls.Add(f1
            f1.Show();
            f1.Dock = DockStyle.Fill;
        }

        
    }
}
