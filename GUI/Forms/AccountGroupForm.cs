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
    public partial class AccountGroupForm : Form
    {
        BUS.Business _business = new BUS.Business();
        public AccountGroupForm()
        {
            InitializeComponent();
            this.Text = string.Empty;

            dgvAccountGroup.DataSource = _business.GetData("sp_AccountGroup");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _business.AddData("sp_AddAccountGroup", "@MaLoai", _business.RandomID("G").ToString(), "@TenLoai", txtAccountGroupName.Text);
            dgvAccountGroup.DataSource = _business.GetData("sp_AccountGroup");
            txtIDAccountGroup.Clear();
            txtAccountGroupName.Clear();
            txtIDAccountGroup.Focus();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            _business.AddData("sp_UpdateAccountGroup", "@MaLoai", txtIDAccountGroup.Text, "@TenLoai", txtAccountGroupName.Text);
            dgvAccountGroup.DataSource = _business.GetData("sp_AccountGroup");
            txtIDAccountGroup.Clear();
            txtAccountGroupName.Clear();
            txtIDAccountGroup.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _business.DeleteData("sp_DeleteAccountGR", "@ID", txtIDAccountGroup.Text);
            dgvAccountGroup.DataSource = _business.GetData("sp_AccountGroup");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvAccountGroup.DataSource = _business.GetData("sp_findAccountGroup", "@TuKhoa", txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtIDAccountGroup.Clear();
            txtIDAccountGroup.Focus();

            txtAccountGroupName.Clear();
            txtAccountGroupName.Focus();

            dgvAccountGroup.DataSource = _business.GetData("sp_AccountGroup");
        }

        private void dgvAccountGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccountGroup.Rows[e.RowIndex];
                txtIDAccountGroup.Text = row.Cells["Mã loại"].Value.ToString();
                txtAccountGroupName.Text = row.Cells["Tên loại tài khoản"].Value.ToString();
            }
        }
    }
}
