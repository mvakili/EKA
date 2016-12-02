using System;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class AddOrEditUnit : AddOrEditForm, IForm
    {
        public Logic.Data.Unit Selected { get; }

        public AddOrEditUnit()
        {
            InitializeComponent();
            EditMode = false;
            Bind();
        }

        public AddOrEditUnit(Logic.Data.Unit unit)
        {
            InitializeComponent();
            EditMode = true;
            Selected = unit;
            Bind();
        }

        public void Bind()
        {
            if (EditMode)
            {
                txtName.Text = Selected.Name;
                breUnitGroup.Tag = Selected.UnitGroup;
                breUnitGroup.Value = Selected.UnitGroup.Name;
                txtFactor.Text = Selected.Factor.ToString();
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
                double factor = 1;
                double.TryParse(txtFactor.Text, out factor);
                var result = MaterialService.EditUnit(Selected, txtName.Text, (Logic.Data.UnitGroup)breUnitGroup.Tag, factor);
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
                double factor;
                double.TryParse(txtFactor.Text, out factor);
                var result = MaterialService.CreateUnit(txtName.Text, (Logic.Data.UnitGroup)breUnitGroup.Tag, factor);
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

        private void breUnitGroup_Click(object sender, EventArgs e)
        {
            var form = new UnitGroup {SelectMode = true};
            if (form.ShowDialog() == DialogResult.OK)
            {
                breUnitGroup.Tag = form.Selected;
                breUnitGroup.Value = form.Selected?.Name;
            }
        }
    }
}
