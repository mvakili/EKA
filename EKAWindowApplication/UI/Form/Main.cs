﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logic.Service;
using Telerik.WinControls.UI;

namespace EKAWindowApplication.UI.Form
{
    public partial class Main : Telerik.WinControls.UI.RadForm, IForm
    {
        public Main()
        {
            InitializeComponent();
            Clear();
        }

        public void Clear()
        {
            lblUserDetails.Text = $@"{UserService.Me.FirstName} {UserService.Me.LastName}";
        }

        public void Bind()
        {

        }

        private void ShowForm(object sender, System.Windows.Forms.Form frm)
        {
            try
            {
                foreach (var t in radPageView1.Pages)
                {
                    if (t.Tag.ToString().CompareTo(frm.Name) != 0) continue;
                    t.Select();
                    radPageView1.SelectedPage = t;
                    return;
                }
                var page = new RadPageViewPage();
                radPageView1.Pages.Add(page);

                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                page.Controls.Add(frm);
                page.Tag = frm.Name;
                page.Text = frm.Text;
                frm.Show();
                radPageView1.SelectedPage = page;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            ShowForm(this, new Main());
        }
    }
}
