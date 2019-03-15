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
    public partial class Form2 : Form, IChildForm
    {
        public Form2()
        {
            InitializeComponent();
        }
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
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
