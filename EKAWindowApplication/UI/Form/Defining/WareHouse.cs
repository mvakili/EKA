using System;
using System.Linq;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class WareHouse : ListForm, IListForm<Logic.Data.WareHouse>
    {
        private ServiceResult<IQueryable<Logic.Data.WareHouse>> _data;

        public Logic.Data.WareHouse Selected
        {
            get
            {
                try
                {
                    int id;
                    int.TryParse(rgvList.SelectedRows[0].Cells["WareHouseID"].Value.ToString(), out id);
                    return _data.Result.FirstOrDefault(r => r.WareHouseID == id);
                }
                catch
                {
                    return null;
                }

            }
        }
        public WareHouse()
        {
            InitializeComponent();
            Bind();
        }

        public void Bind()
        {
            _data = WareHouseService.GetWareHouses();
            if (_data.Status != ResultStatus.Ok)
            {
                MessageBox.Show(Resources.BindingError);
                return;
            }

            var wareHouseName = txtWareHouseName.Text.Trim();
            rgvList.DataSource = _data.Result
                .Where(r =>  
                    wareHouseName == "" || r.Name.StartsWith(wareHouseName)
                )
                .Select(r => new
                {
                   r.WareHouseID,
                   r.Name,
                   AllowSend = r.AllowSend ? @"بله" : @"خیر",
                   AllowReceive = r.AllowReceive ? @"بله" : @"خیر",
                   ManagerName = (r.User != null) ? r.User.FirstName + " " + r.User.LastName : "بدون مسئول",
                   IsCountable = r.IsCountable ? @"بله" : @"خیر",
                }).ToList();
            rgvList.BestFitColumns();
        }

        public void Clear()
        {
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            Bind();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddOrEditWareHouse().ShowDialog() == DialogResult.OK)
            {
                Bind();
            }
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            if (Selected == null)
            {
                MessageBox.Show(Resources.NoRowSelected);
                return;
            }
            if (new AddOrEditWareHouse(Selected).ShowDialog() == DialogResult.OK)
            {
                Bind();
            }
        }

        public void btnRemove_Click(object sender, EventArgs e)
        {
            if (Selected == null)
            {
                MessageBox.Show(Resources.NoRowSelected);
                return;
            }
            var result = WareHouseService.RemoveWareHouse(Selected);

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
