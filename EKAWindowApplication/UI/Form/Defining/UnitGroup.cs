using System;
using System.Linq;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class UnitGroup : ListForm, IForm
    {
        private ServiceResult<IQueryable<Logic.Data.UnitGroup>> _data;

        public Logic.Data.UnitGroup Selected
        {
            get
            {
                int id;
                int.TryParse(rgvList.SelectedRows[0].Cells["UnitGroupID"].Value.ToString(), out id);
                return _data.Result.FirstOrDefault(r => r.UnitGroupID == id);
                
            }
        }
        public UnitGroup()
        {
            InitializeComponent();
            Bind();
        }

        public void Bind()
        {
            _data = MaterialService.GetUnitGroups();
            if (_data.Status != ResultStatus.Ok)
            {
                MessageBox.Show(Resources.BindingError);
                return;
            }

            rgvList.DataSource = _data.Result
                .Where(r =>  
                    true
                )
                .Select(r => new
                {
                    r.UnitGroupID,
                    r.Name

                }).ToList();
        }

        public void Clear()
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Bind();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddOrEditUnitGroup().ShowDialog() == DialogResult.OK)
            {
                Bind();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Selected == null)
            {
                MessageBox.Show(Resources.NoRowSelected);
                return;
            }

            int id;
            int.TryParse(rgvList.SelectedRows[0].Cells["UnitGroupID"].Value.ToString(), out id);
            if (new AddOrEditUnitGroup(_data.Result.FirstOrDefault(r => r.UnitGroupID == id)).ShowDialog() == DialogResult.OK)
            {
                Bind();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (rgvList.SelectedRows.Count == 0)
            {
                MessageBox.Show(Resources.NoRowSelected);
                return;
            }
            var result = MaterialService.RemoveUnitGroup(Selected);

            switch (result.Status)
            {
                case ResultStatus.Ok:
                    MessageBox.Show(Resources.SuccessfulOperation);
                    Bind();
                    break;
                case ResultStatus.AccessFail:
                    MessageBox.Show(Resources.AccessFail);
                    break;
                default:
                    MessageBox.Show(Resources.UnknownError);
                    break;
            }
        }
    }
}
