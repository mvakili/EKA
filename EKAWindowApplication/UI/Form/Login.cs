using System;
using System.Drawing;
using Logic.Service;

namespace EKAWindowApplication.UI.Form
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserService.IsLoggedIn) UserService.Logout();

            var result = UserService.Login(txtUserName.Text, txtPassword.Text);
            

            switch (result.Status)
            {
                case ResultStatus.Ok:
                    lblResult.ForeColor = Color.DarkGreen;
                    lblResult.Text =
                        $@" خوش آمدید {UserService.Me.FirstName} {UserService.Me.LastName}";
                    Hide();
                    Clear();
                    new Main().ShowDialog();
                    Show();
                    break;
                case ResultStatus.NotFound:
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = @"نام کاربری/ رمز عبور وارد شده صحیح نمی باشد";
                    break;
                case ResultStatus.AccessFail:
                    lblResult.ForeColor = Color.DarkOrange;
                    lblResult.Text = @"اجازه ی ورود ندارید";
                    break;
                default:
                    lblResult.ForeColor = Color.Black;
                    lblResult.Text = @"اشکالی پیش آمد، لطفا به پشتیبانی اطلاع دهید";
                    break;

            }
        }

        private void Clear()
        {
            lblResult.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
        }
    }

}
