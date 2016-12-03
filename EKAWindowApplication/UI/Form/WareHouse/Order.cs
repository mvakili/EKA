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
    public partial class Order : ListForm, IListForm<Logic.Data.Order>
    {
        private ServiceResult<IQueryable<Logic.Data.Order>> _data;
        public Logic.Data.Order Selected
        {
            get
            {
                try
                {
                    int id;
                    int.TryParse(rgvList.SelectedRows[0].Cells["OrderID"].Value.ToString(), out id);
                    return _data.Result.FirstOrDefault(r => r.OrderID == id);
                }
                catch
                {
                    return null;
                }

            }
        }
        public Order()
        {
            InitializeComponent();
            Bind();
        }

        public void Bind()
        {
            _data = WareHouseService.GetOrders();
            if (_data.Status != ResultStatus.Ok)
            {
                MessageBox.Show(Resources.BindingError);
                return;
            }
            var materialId = ((Material) breMaterialGroup.Tag)?.MaterialID ?? 0;
            var wareHouseId = ((Logic.Data.WareHouse)breWareHouse.Tag)?.WareHouseID ?? 0;
            rgvList.DataSource = _data.Result
                .Where(r =>
                    materialId == 0 || r.MaterialID == materialId
                )
                .Where(r =>
                    wareHouseId == 0 || r.ToWareHouseID == wareHouseId
                )
                .ToList()
                .Select(r => new
                {
                    r.OrderID,
                    WareHouseName = r.WareHouse.Name,
                    MaterialGroupName = r.Material.MaterialGroup.Name,
                    r.Material.Qty,
                    UnitName = r.Material.MaterialGroup.Unit.Name,
                    ActorName = r.User.FirstName + " " + r.User.LastName,
                    DateTime = PersianDate.ConvertDate.ToFaWithTime(r.DateTime)

                }).OrderByDescending(u => u.DateTime).Take(100).ToList();
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

        private void breMaterial_Click(object sender, EventArgs e)
        {
            var form = new Defining.Material() { SelectMode = true };
            if (form.ShowDialog() == DialogResult.OK)
            {
                breMaterialGroup.Tag = form.Selected;
                breMaterialGroup.Value = form.Selected?.MaterialGroup.Name + " " + form.Selected?.Qty + " " + form.Selected?.MaterialGroup.Unit.Name;
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
