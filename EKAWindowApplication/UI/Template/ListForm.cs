using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace EKAWindowApplication.UI.Template
{
    public partial class ListForm : RadForm
    {
        private bool _selectMode;
        public bool SelectMode
        {
            get { return _selectMode; }
            set
            {
                if (value)
                {
                    pnlOperation.Visible = false;
                    pnlSelect.Visible = true;
                    FormBorderStyle = FormBorderStyle.Sizable;
                }

                if (!value)
                {
                    pnlOperation.Visible = true;
                    pnlSelect.Visible = false;
                    FormBorderStyle = FormBorderStyle.None;
                }

                _selectMode = value;
            }
        }
        public ListForm()
        {
            InitializeComponent();
            SelectMode = false;
        }

        private void ListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
