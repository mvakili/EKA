using System;
using System.Drawing;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class AddOrEditUser : AddOrEditForm, IForm
    {
        private Logic.Data.User _user;
        public AddOrEditUser()
        {
            InitializeComponent();
            EditMode = false;
            Bind();
        }

        public AddOrEditUser(Logic.Data.User user)
        {
            InitializeComponent();
            EditMode = true;
            _user = user;
            Bind();
        }

        public Logic.Data.User User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }

        public void Bind()
        {
            if (EditMode)
            {
                txtUserName.Text = _user.UserName;
                txtUserName.Enabled = false;

                txtFirstName.Text = _user.FirstName;
                txtLastName.Text = _user.LastName;
                rbIsActive.IsChecked = _user.IsActive;
                rbIsAdmin.IsChecked = _user.IsAdmin;
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
            bool isAdmin = rbIsAdmin.IsChecked;
            bool isActive = rbIsActive.IsChecked;
            if (EditMode)
            {
                
                var result = UserService.EditUser(_user, txtFirstName.Text, txtLastName.Text,txtPassword.Text, isActive, isAdmin);
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
                var result = UserService.CreateUser(txtUserName.Text, txtFirstName.Text, txtLastName.Text, txtPassword.Text, isActive, isAdmin);
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

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            var result = UserService.IsFreeUserName(txtUserName.Text);
            if (result.Status != ResultStatus.Ok)
            {
                txtUserName.ForeColor = Color.Red;
            }
            else
            {
                txtFirstName.ForeColor = DefaultForeColor;
            }

        }
    }
}
