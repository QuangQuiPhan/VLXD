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
    public partial class CustomerForm : Form
    {
        BUS.Business _business = new BUS.Business();
        public CustomerForm()
        {
            InitializeComponent();
            this.Text = string.Empty;

            Display();
        }

        void Display()
        {
            dgvCustomer.DataSource = _business.GetData("sp_Customer");
            txtIDCustomer.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtIDCustomer.Focus();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            _business.AddData("sp_AddCustomer", "@MaKH", _business.RandomID("KH").ToString(), "@HoTen", txtCustomerName.Text,
                "@DienThoai", txtPhone.Text, "@DiaChi", txtAddress.Text);
            Display();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            _business.UpdateData("sp_UpdateCustomer", "@MaKH", _business.RandomID("KH").ToString(), "@HoTen", txtCustomerName.Text,
                "@DienThoai", txtPhone.Text, "@DiaChi", txtAddress.Text);
            Display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _business.DeleteData("sp_DeleteCustomer", "@ID", txtIDCustomer.Text);
            Display();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = _business.GetData("sp_findCustomer", "@TuKhoa", txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                txtIDCustomer.Text = row.Cells["Mã khách hàng"].Value.ToString();
                txtCustomerName.Text = row.Cells["Họ tên"].Value.ToString();
                txtPhone.Text = row.Cells["Điện thoại"].Value.ToString();
                txtAddress.Text = row.Cells["Địa chỉ"].Value.ToString();
            }
        }
    }
}
