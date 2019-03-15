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
    public partial class Form1 : Form, IChildForm
    {
        public Form1()
        {
            InitializeComponent();
        }

    //    private void Form1_ParentChanged(object sender, EventArgs e)
    //    {
    //        //Try
        
    //        ToolStripManager.Merge(Me.ToolStrip, TryCast(sender.mdiParent, frmMain).ToolStrip)
    ////Catch 
    ////    ex As Exception
    ////    mErrorLog.ApplicationErrorLog(Me.GetType.Name, "frmTechSelectWO_ParentChanged", ex.ToString)
    ////Finally
    //    Me.ToolStrip.Hide()
    //    Me.MenuStrip1.Hide()
    ////End Try
    //    }


        public ToolStrip ChildToolStrip
        {
            get
            {
                return this.tsChild;
            }
            set
            {
                this.tsChild = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
