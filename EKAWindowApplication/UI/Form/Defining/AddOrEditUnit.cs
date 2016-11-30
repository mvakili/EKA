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
    public partial class AddOrEditUnit : AddOrEditForm, IForm
    {
        private Logic.Data.Unit _unit;
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
            _unit = unit;
            Bind();
        }

        public Logic.Data.Unit UnitGroup
        {
            get
            {
                return _unit;
            }

            set
            {
                _unit = value;
            }
        }

        public Logic.Data.Unit UnitGroup1
        {
            get
            {
                return _unit;
            }

            set
            {
                _unit = value;
            }
        }

        public void Bind()
        {
            if (EditMode)
            {
                txtName.Text = _unit.Name;
                breUnitGroup.Tag = _unit.UnitGroup;
                breUnitGroup.Value = _unit.UnitGroup.Name;
                txtFactor.Text = _unit.Factor.ToString();
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
                double factor = 1;
                double.TryParse(txtFactor.Text, out factor);
                var result = MaterialService.EditUnit(_unit, txtName.Text, (Logic.Data.UnitGroup)breUnitGroup.Tag, factor);
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
                double factor = 1;
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
                breUnitGroup.Value = form.Selected.Name;
            }
        }
    }
}
