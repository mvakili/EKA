using System;
using System.Linq;
using System.Windows.Forms;
using EKAWindowApplication.Properties;
using EKAWindowApplication.UI.Template;
using Logic.Service;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class Material : ListForm, IForm
    {
        private ServiceResult<IQueryable<Logic.Data.Material>> _data;
        public Logic.Data.Material Selected
        {
            get
            {
                int id;
                int.TryParse(rgvList.SelectedRows[0].Cells["UnitGroupID"].Value.ToString(), out id);
                return _data.Result.FirstOrDefault(r => r.MaterialID == id);

            }
        }
        public Material()
        {
            InitializeComponent();
            Bind();
        }

        public void Bind()
        {
            _data = MaterialService.GetMaterials();
            if (_data.Status != ResultStatus.Ok)
            {
                MessageBox.Show(Resources.BindingError);
                return;
            }

            int materialId;
            int.TryParse(txtMaterialID.Text,out materialId);

            rgvList.DataSource = _data.Result
                .Where(r =>  
                    materialId == 0 || r.MaterialID == materialId
                )
                .Select(r => new
                {
                    r.MaterialID,
                    GroupName = r.MaterialGroup.Name,
                    r.Qty,
                    Unit = r.MaterialGroup.Unit.Name

                }).ToList();
        }

        public void Clear()
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Bind();
        }
    }
}
