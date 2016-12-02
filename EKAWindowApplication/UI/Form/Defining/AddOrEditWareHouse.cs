using System;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class AddOrEditWareHouse : AddOrEditForm, IForm
    {
        public Logic.Data.WareHouse Selected { get; }

        public AddOrEditWareHouse()
        {
            InitializeComponent();
            EditMode = false;
            Bind();
        }

        public AddOrEditWareHouse(Logic.Data.WareHouse wareHouse)
        {
            InitializeComponent();
            EditMode = true;
            Selected = wareHouse;
            Bind();
        }

        public void Bind()
        {
            if (EditMode)
            {
                txtName.Text = Selected.Name;
                rbAllowSendTrue.IsChecked = Selected.AllowSend;
                rbAllowSendFalse.IsChecked = !Selected.AllowSend;

                rbAllowReceiveTrue.IsChecked = Selected.AllowReceive;
                rbAllowReceiveFalse.IsChecked = !Selected.AllowReceive;

                rbIsCountable.IsChecked = Selected.IsCountable;
                rbIsNotCountable.IsChecked = !Selected.IsCountable;

                breUser.Tag = Selected.User;
                breUser.Value = Selected.User?.FirstName + " " + Selected.User?.LastName;
            }
        }

        public void Clear()
        {
        }

        private void btnCancel_Click(object sender, EventArgs e) 
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var allowSend = rbAllowSendTrue.IsChecked;
            var allowReceive = rbAllowReceiveTrue.IsChecked;
            var isCountable = rbIsCountable.IsChecked;
            if (EditMode)
            {
                var result = WareHouseService.EditWareHouse(Selected, txtName.Text, allowSend, allowReceive, (Logic.Data.User) breUser.Tag, isCountable);
                switch (result.Status)
                {
                    case ResultStatus.Ok:
                        MessageBox.Show(Resources.SuccessfulOperation);
                        break;
                    default:
                        MessageBox.Show(Resources.UnknownError);
                        break;
                }
                Close();
            }
            if (!EditMode)
            {
                var result = WareHouseService.CreateWareHouse(txtName.Text, allowSend, allowReceive, (Logic.Data.User)breUser.Tag, isCountable);
                switch (result.Status)
                {
                    case ResultStatus.Ok:
                        MessageBox.Show(Resources.SuccessfulOperation);
                        break;
                    default:
                        MessageBox.Show(Resources.UnknownError);
                        break;
                }
                Close();
            }
        }

        private void breUser_Click(object sender, EventArgs e)
        {
            var form = new User.User() {SelectMode = true};
            if (form.ShowDialog() == DialogResult.OK)
            {
                breUser.Tag = form.Selected;
                breUser.Value = (form.Selected != null) ? $"{form.Selected.FirstName} {form.Selected.LastName}" : null;
            }
        }
    }
}
