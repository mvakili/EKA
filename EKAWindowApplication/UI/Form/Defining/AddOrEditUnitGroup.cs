using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Data;
using Logic.Service;
using Telerik.WinControls;

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

        public Logic.Data.UnitGroup UnitGroup1
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
            throw new NotImplementedException();
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
