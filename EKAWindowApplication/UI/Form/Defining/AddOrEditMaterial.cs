using System;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class AddOrEditMaterial : AddOrEditForm, IForm
    {
        private Logic.Data.Material _material;
        public AddOrEditMaterial()
        {
            InitializeComponent();
            EditMode = false;
            Bind();
        }

        public AddOrEditMaterial(Logic.Data.Material material)
        {
            InitializeComponent();
            EditMode = true;
            _material = material;
            Bind();
        }

        public Logic.Data.Material Material
        {
            get
            {
                return _material;
            }

            set
            {
                _material = value;
            }
        }

        public void Bind()
        {
            if (EditMode)
            {
                txtQty.Text = _material.Qty.ToString();
                breMaterialGroup.Tag = _material.MaterialGroup;
                breMaterialGroup.Value = _material.MaterialGroup.Name;
                lblUnitName.Text = Material.MaterialGroup.Unit.Name;
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
            decimal qty;
            decimal.TryParse(txtQty.Text, out qty);
            if (EditMode)
            {
                
                var result = MaterialService.EditMaterial(_material, (Logic.Data.MaterialGroup)breMaterialGroup.Tag, qty);
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
                var result = MaterialService.CreateMaterial((Logic.Data.MaterialGroup)breMaterialGroup.Tag, qty);
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

        private void breMaterialGroup_Click(object sender, EventArgs e)
        {
            var form = new MaterialGroup() {SelectMode = true};
            if (form.ShowDialog() == DialogResult.OK)
            {
                breMaterialGroup.Tag = form.Selected;
                breMaterialGroup.Value = form.Selected.Name;
                lblUnitName.Text = form.Selected.Unit.Name;
                txtQty.Text = @"0";
            }
        }
    }
}
