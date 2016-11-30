using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EKAWindowApplication.UI.Template;
using Logic.Service;
using Telerik.WinControls;

namespace EKAWindowApplication.UI.Form.Defining
{
    public partial class Material : ListForm, IForm
    {
        public Material()
        {
            InitializeComponent();
            Bind();
        }

        public void Bind()
        {
            var data = Logic.Service.MaterialService.GetMaterials();
            if (data.Status != ResultStatus.Ok)
            {
                MessageBox.Show(@"خطایی در دریافت اظلاعات رخ داد");
                return;
            }

            int materialID;
            int.TryParse(txtMaterialID.Text,out materialID);

            rgvList.DataSource = data.Result
                .Where(r =>  
                    materialID == 0 || r.MaterialID == materialID
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
            throw new NotImplementedException();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Bind();
        }
    }
}
