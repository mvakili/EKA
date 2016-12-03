using System;
using System.Windows.Forms;
using EKAWindowApplication.UI.Form.Defining;
using EKAWindowApplication.UI.Form.WareHouse;
using Logic.Service;
using Telerik.WinControls.UI;

namespace EKAWindowApplication.UI.Form
{
    public partial class Main : RadForm, IForm
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

        private void ShowForm(object sender, RadForm frm)
        {
            try
            {
                foreach (var t in radPageView1.Pages)
                {
                    if (string.Compare(t.Tag.ToString(), frm.Text, StringComparison.Ordinal) != 0) continue;
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
                page.Tag = frm.Text;
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
            ShowForm(this, new Material());
        }

        private void btnUnitGroup_Click(object sender, EventArgs e)
        {
            ShowForm(this, new UnitGroup());
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            ShowForm(this, new Unit());
        }

        private void btnMaterialGroup_Click(object sender, EventArgs e)
        {
            ShowForm(this, new MaterialGroup());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ShowForm(this, new User.User());
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            ShowForm(this,new Defining.WareHouse());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            new AddOrder().ShowDialog();
        }

        private void btnMaterialExistance_Click(object sender, EventArgs e)
        {
            ShowForm(this, new MaterialExistance());
        }

        private void btnOrderReport_Click(object sender, EventArgs e)
        {
            ShowForm(this, new Order());
        }
    }
}
