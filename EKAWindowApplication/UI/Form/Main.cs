using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logic.Service;

namespace EKAWindowApplication.UI.Form
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        public Main()
        {
            InitializeComponent();
            Clear();
        }

        private void Clear()
        {
            lblUserDetails.Text = $@"{UserService.Me.FirstName} {UserService.Me.LastName}";
        }
    }
}
