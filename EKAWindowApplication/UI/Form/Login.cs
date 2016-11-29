using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logic.Service;
using Telerik.WinControls;

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
            if (Logic.Service.UserService.IsLoggedIn) Logic.Service.UserService.Logout();

            var result = Logic.Service.UserService.Login(txtUserName.Text, txtPassword.Text);
            

            switch (result.Status)
            {
                case ResultStatus.Ok:
                    lblResult.ForeColor = Color.DarkGreen;
                    lblResult.Text =
                        $@" خوش آمدید {Logic.Service.UserService.Me.FirstName} {Logic.Service.UserService.Me.LastName}";
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
