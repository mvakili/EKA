using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace EKAWindowApplication.UI.Template
{
    public partial class AddOrEditForm : Telerik.WinControls.UI.RadForm
    {
        protected bool EditMode { get; set; }

        public AddOrEditForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
