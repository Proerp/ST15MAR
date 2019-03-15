using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer.Temporary
{
    public partial class simulateReadfromScanner : Form
    {
        public simulateReadfromScanner()
        {
            InitializeComponent();
            this.buttonOK.DialogResult = DialogResult.OK;
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonCancel;
        }
    }
}
