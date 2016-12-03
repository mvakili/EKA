using System;
using System.Linq;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Form.User;
using EKAWindowApplication.UI.Template;
using Logic.Data;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.WareHouse
{
    public partial class MaterialExistance : ListForm, IListForm<Logic.Data.MaterialExistance>
    {
        private ServiceResult<IQueryable<Logic.Data.MaterialExistance>> _data;
        public Logic.Data.MaterialExistance Selected
        {
            get
            {
                try
                {
                    int id;
                    int.TryParse(rgvList.SelectedRows[0].Cells["MaterialExistanceID"].Value.ToString(), out id);
                    return _data.Result.FirstOrDefault(r => r.MaterialExistanceID == id);
                }
                catch
                {
                    return null;
                }

            }
        }
        public MaterialExistance()
        {
            InitializeComponent();
            Bind();
        }

        public void Bind()
        {
            _data = WareHouseService.GetMaterialExistances();
            if (_data.Status != ResultStatus.Ok)
            {
                MessageBox.Show(Resources.BindingError);
                return;
            }
            var materialGroupId = ((MaterialGroup) breMaterialGroup.Tag)?.MaterialGroupID ?? 0;
            var wareHouseId = ((Logic.Data.WareHouse)breWareHouse.Tag)?.WareHouseID ?? 0;
            rgvList.DataSource = _data.Result
                .Where(r =>
                    materialGroupId == 0 || r.MaterialGroupID == materialGroupId
                )
                .Where(r =>
                    wareHouseId == 0 || r.WareHouseID == wareHouseId
                )
                .ToList()
                .Select(r => new
                {
                    r.MaterialExistanceID,
                    WareHouseName = r.WareHouse.Name,
                    MaterialGroupName = r.MaterialGroup.Name,
                    r.Qty,
                    UnitName = r.MaterialGroup.Unit.Name

                }).OrderByDescending(u => u.MaterialExistanceID).Take(100).ToList();
            rgvList.BestFitColumns();
        }

        public void Clear()
        {
            
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public void btnRemove_Click(object sender, EventArgs e)
        {
            
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            Bind();
        }

        private void breMaterialGroup_Click(object sender, EventArgs e)
        {
            var form = new Defining.MaterialGroup() { SelectMode = true };
            if (form.ShowDialog() == DialogResult.OK)
            {
                breMaterialGroup.Tag = form.Selected;
                breMaterialGroup.Value = form.Selected?.Name;
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
