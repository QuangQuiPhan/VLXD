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
    public partial class AccountForm : Form
    {
        BUS.Business _business = new BUS.Business();
        public AccountForm()
        {
            InitializeComponent();
            this.Text = string.Empty;

            Display();
        }

        public void Display()
        {
            //Display on combobox
            cmbEmploy.DisplayMember = "Họ tên nhân viên";
            cmbEmploy.ValueMember = "Mã nhân viên";
            cmbEmploy.DataSource = _business.GetData("sp_Employee");

            cmbAccountGroup.DisplayMember = "Tên loại tài khoản";
            cmbAccountGroup.ValueMember = "Mã loại";
            cmbAccountGroup.DataSource = _business.GetData("sp_AccountGroup");


            dgvAccount.DataSource = _business.GetData("sp_Account");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _business.AddData("sp_AddAccount", "@TenDangNhap", txtUsername.Text, "@MatKhau", txtPassword.Text,
                "@LoaiTK", cmbAccountGroup.SelectedValue.ToString(), "@MaNV", cmbEmploy.SelectedValue.ToString());

            dgvAccount.DataSource = _business.GetData("sp_Account");
            txtUsername.Clear();
            txtUsername.Focus();
            txtPassword.Clear();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            _business.UpdateData("sp_UpdateAccount", "@TenDangNhap", txtUsername.Text, "@MatKhau", txtPassword.Text,
                "@LoaiTK", cmbAccountGroup.SelectedValue.ToString(), "@MaNV", cmbEmploy.SelectedValue.ToString());

            dgvAccount.DataSource = _business.GetData("sp_Account");
            txtUsername.Clear();
            txtUsername.Focus();
            txtPassword.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _business.DeleteData("sp_DeleteAccount", "@ID", txtUsername.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvAccount.DataSource = _business.GetData("sp_findAccount", "@TuKhoa", txtSearch.Text);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            Display();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string accountType, idEmployee;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccount.Rows[e.RowIndex];
                txtUsername.Text = row.Cells["Tên đăng nhập"].Value.ToString();
                txtPassword.Text = row.Cells["Mật khẩu"].Value.ToString();
                accountType = row.Cells["Loại tài khoản"].Value.ToString();
                idEmployee = row.Cells["Nhân viên"].Value.ToString();

                //Display on combobox
                cmbEmploy.SelectedValue = idEmployee;

                cmbAccountGroup.SelectedValue = accountType;
            }
        }

    }
}
