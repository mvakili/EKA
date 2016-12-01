using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKAWindowApplication.UI
{
    internal interface IForm
    {
        void Clear();
        void Bind();
    }

    internal interface IListForm<out T> : IForm
    {
        T Selected { get; }

        void btnAdd_Click(object sender, EventArgs e);
        void btnEdit_Click(object sender, EventArgs e);
        void btnRemove_Click(object sender, EventArgs e);
        void btnSearch_Click(object sender, EventArgs e);
    }
}
