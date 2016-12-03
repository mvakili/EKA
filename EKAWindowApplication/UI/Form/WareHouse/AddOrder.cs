using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Form.Defining;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.WareHouse
{
    public partial class AddOrder : AddOrEditForm, IForm
    {
        public Logic.Data.User Selected { get; }

        public AddOrder()
        {
            InitializeComponent();
            EditMode = false;
            Bind();
        }


        public void Bind()
        {
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

            var result = WareHouseService.CreateNewOrder((Logic.Data.Material) breMaterial.Tag, (Logic.Data.WareHouse) breWareHouse.Tag );
            switch (result.Status)
            {
                case ResultStatus.Ok:
                    MessageBox.Show(Resources.SuccessfulOperation);
                    break;
                case ResultStatus.AccessFail:
                    MessageBox.Show(Resources.AccessFail);
                    break;
                default:
                    MessageBox.Show(Resources.UnknownError);
                    break;
            }
            Close();
        }


        private void breMaterial_Click(object sender, EventArgs e)
        {
            var form = new Material() { SelectMode = true };
            if (form.ShowDialog() == DialogResult.OK)
            {
                breMaterial.Tag = form.Selected;
                breMaterial.Value = form.Selected?.MaterialGroup.Name;
                lblQty.Text = $@"{form.Selected?.Qty}  {form.Selected?.MaterialGroup.Unit.Name}";
                lblFromWareHouse.Text =
                    form.Selected?.Orders.OrderByDescending(u => u.DateTime).ThenBy(u => u.OrderID)
                        .FirstOrDefault()?.WareHouse.Name ?? "بدون انبار";
            }
        }

        private void breWareHouse_Click(object sender, EventArgs e)
        {
            var form = new Defining.WareHouse() { SelectMode = true };
            if (form.ShowDialog() == DialogResult.OK)
            {
                breWareHouse.Tag = form.Selected;
                breWareHouse.Value = form.Selected?.Name;
            }
        }
    }
}
