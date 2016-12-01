using System;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class AddOrEditUnitGroup : AddOrEditForm, IForm
    {
        private Logic.Data.UnitGroup _unitGroup;
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
            _unitGroup = unitGroup;
            Bind();
        }

        public Logic.Data.UnitGroup UnitGroup
        {
            get
            {
                return _unitGroup;
            }

            set
            {
                _unitGroup = value;
            }
        }

        public void Bind()
        {
            if (EditMode)
            {
                txtName.Text = _unitGroup.Name;
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
                var result = MaterialService.EditUnitGroup(_unitGroup, txtName.Text);
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
