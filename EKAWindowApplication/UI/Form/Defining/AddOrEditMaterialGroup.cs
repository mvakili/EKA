using System;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class AddOrEditMaterialGroup : AddOrEditForm, IForm
    {
        public Logic.Data.MaterialGroup Selected { get; }

        public AddOrEditMaterialGroup()
        {
            InitializeComponent();
            EditMode = false;
            Bind();
        }

        public AddOrEditMaterialGroup(Logic.Data.MaterialGroup materialGroup)
        {
            InitializeComponent();
            EditMode = true;
            Selected = materialGroup;
            Bind();
        }

        public void Bind()
        {
            if (EditMode)
            {
                txtName.Text = Selected.Name;
                breUnit.Tag = Selected.Unit;
                breUnit.Value = Selected.Unit.Name;
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
            if (EditMode)
            {
                var result = MaterialService.EditMaterialGroup(Selected, txtName.Text, (Logic.Data.Unit)breUnit.Tag);
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
                var result = MaterialService.CreateMaterialGroup(txtName.Text, (Logic.Data.Unit)breUnit.Tag);
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

        private void breUnit_Click(object sender, EventArgs e)
        {
            var form = new Unit {SelectMode = true};
            if (form.ShowDialog() == DialogResult.OK)
            {
                breUnit.Tag = form.Selected;
                breUnit.Value = form.Selected?.Name;
            }
        }
    }
}
