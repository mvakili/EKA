using System;
using System.Linq;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Form.Defining;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.User
{
    public partial class User : ListForm, IListForm<Logic.Data.User>
    {
        private ServiceResult<IQueryable<Logic.Data.User>> _data;
        public Logic.Data.User Selected
        {
            get
            {
                try
                {
                    int id;
                    int.TryParse(rgvList.SelectedRows[0].Cells["UserID"].Value.ToString(), out id);
                    return _data.Result.FirstOrDefault(r => r.UserID == id);
                }
                catch
                {
                    return null;
                }

            }
        }
        public User()
        {
            InitializeComponent();
            Bind();
        }

        public void Bind()
        {
            _data = UserService.GetUsers();
            if (_data.Status != ResultStatus.Ok)
            {
                MessageBox.Show(Resources.BindingError);
                return;
            }
            var userName = txtUserName.Text.Trim();
            var isAdmin = rbIsAdmin.IsChecked;
            var isActive = rbIsActive.IsChecked;
            rgvList.DataSource = _data.Result
                .Where(r =>  
                    userName == "" || r.UserName.StartsWith(userName)
                )
                .Where(r =>
                    r.IsActive == isActive    
                )
                .Where(r =>
                    r.IsAdmin == isAdmin
                )
                .ToList()
                .Select(r => new
                {
                    r.UserID,
                    r.UserName,
                    r.FirstName,
                    r.LastName,
                    IsActive = r.IsActive ? @"بله" : @"خیر",
                    IsAdmin = r.IsAdmin ? @"بله" : @"خیر",
                    InsertDate = PersianDate.ConvertDate.ToFa(r.InsertDate)

                }).ToList();
            rgvList.BestFitColumns();
        }

        public void Clear()
        {
            
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddOrEditUser().ShowDialog() == DialogResult.OK)
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
            if (new AddOrEditUser(Selected).ShowDialog() == DialogResult.OK)
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
            var result = UserService.RemoveUser(Selected);

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

        public void btnSearch_Click(object sender, EventArgs e)
        {
            Bind();
        }
    }
}
