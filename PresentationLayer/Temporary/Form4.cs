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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            
        }

        
        private void Form4_Load(object sender, EventArgs e)
        {
            frmMDIMain parent = (frmMDIMain)(this.MdiParent);
            parent.Save += new frmMDIMain.SaveDelegate(this.Save);
            //parent.Save += new System.EventHandler(this.Save); ----- cau lenh nay dung syntax, nhung khong chay duoc, thay vao do, cau lenh phia tren lai ok!!!
            
        }


        public void Save(object sender, EventArgs e)
        {
            this.label1.Text = sender.ToString() + " " +  this.Text;
            /// TODO: save code
        }

    }
}
