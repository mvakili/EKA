using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
            
            // Login successful
            switch (result)
            {
                case 0:
                    lblResult.ForeColor = Color.DarkGreen;
                    lblResult.Text =
                        $@" خوش آمدید {Logic.Service.UserService.Me.FirstName} {Logic.Service.UserService.Me.LastName}";
                    Hide();
                    Clear();
                    new Main().ShowDialog();
                    Show();
                    break;
                case -1:
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = @"نام کاربری/ رمز عبور وارد شده صحیح نمی باشد";
                    break;
                case -2:
                    lblResult.ForeColor = Color.DarkOrange;
                    lblResult.Text = @"حساب کاربری شما غیرفعال می باشد";
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
