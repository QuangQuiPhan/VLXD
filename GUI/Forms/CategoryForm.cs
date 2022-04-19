using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class CategoryForm : Form
    {
        BUS.Business _business = new BUS.Business();
        string _maLoai, _tenLoai;
        public CategoryForm()
        {
            InitializeComponent();
            dgvLoadCategory.DataSource = _business.GetData("sp_Category");
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            _business.AddData("sp_AddCategory", "@MaLoai", _business.RandomID("L"), "@TenLoai", txtCategoryName.Text);
            dgvLoadCategory.DataSource = _business.GetData("sp_Category");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            _business.UpdateData("sp_UpdateCategory", "@MaLoai", txtIDCategory.Text, "@TenLoai", txtCategoryName.Text);
            txtIDCategory.Clear();
            txtCategoryName.Clear();
            txtIDCategory.Focus();
            dgvLoadCategory.DataSource = _business.GetData("sp_Category");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _business.DeleteData("sp_DeleteCategory", "@ID", txtIDCategory.Text);
            dgvLoadCategory.DataSource = _business.GetData("sp_Category");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvLoadCategory.DataSource = _business.GetData("sp_findCategory", "@TuKhoa", txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtIDCategory.Clear();
            txtCategoryName.Clear();

            txtIDCategory.Focus();
            dgvLoadCategory.DataSource = _business.GetData("sp_Category");
        }

        private void dgvLoadCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoadCategory.Rows[e.RowIndex];
                _maLoai = row.Cells["Mã loại"].Value.ToString();
                _tenLoai = row.Cells["Tên loại hàng"].Value.ToString();
            }

            txtIDCategory.Text = _maLoai;
            txtCategoryName.Text = _tenLoai;
        }
    }
}
