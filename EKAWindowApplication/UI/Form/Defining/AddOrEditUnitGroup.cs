using System;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class AddOrEditUnitGroup : AddOrEditForm, IForm
    {
        public Logic.Data.UnitGroup Selected { get; }

        public AddOrEditUnitGroup()
        {
            InitializeComponent();
            EditMode = false;
            Bind();
        }

        public AddOrEditUnitGroup(Logic.Data.UnitGroup unitGroup)
        {
            InitializeComponent();
            EditMode = true;
            Selected = unitGroup;
            Bind();
        }

        public void Bind()
        {
            if (EditMode)
            {
                txtName.Text = Selected.Name;
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
                var result = MaterialService.EditUnitGroup(Selected, txtName.Text);
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
                var result = MaterialService.CreateUnitGroup(txtName.Text);
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
    }
}
