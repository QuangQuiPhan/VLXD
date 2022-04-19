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
    public partial class EmployeeForm : Form
    {
        BUS.Business _business = new BUS.Business();
        public EmployeeForm()
        {
            InitializeComponent();
            this.Text = string.Empty;

            Display();
        }

        void Display()
        {
            txtIDEmployee.Clear();
            txtEmployeeName.Clear();
            txtAddress.Clear();
            txtSex.Clear();
            txtPhone.Clear();
    
            dgvEmployee.DataSource = _business.GetData("sp_Employee");
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            _business.AddData("sp_AddEmployee", "@MaNV", _business.RandomID("NV"), "HoTen", txtEmployeeName.Text, 
                "NgaySinh", dtbDateOfBirth.Value, "@Phai", txtSex.Text, "@DienThoai", txtPhone.Text, "@DiaChi", txtAddress.Text);
            Display();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            _business.UpdateData("sp_UpdateEmployee", "@MaNV", txtIDEmployee.Text, "HoTen", txtEmployeeName.Text,
                "NgaySinh", dtbDateOfBirth.Value, "@Phai", txtSex.Text, "@DienThoai", txtPhone.Text, "@DiaChi", txtAddress.Text);
            Display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _business.DeleteData("sp_DeleteEmployee", "@ID", txtIDEmployee.Text);

            Display();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = _business.GetData("sp_findEmployee", "@TuKhoa", txtSearch.Text);
        }

        string id, fullName, phone, address, sex;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Display();
        }

        DateTime dateOfBirth;
        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
                id = row.Cells["Mã nhân viên"].Value.ToString();
                fullName = row.Cells["Họ tên nhân viên"].Value.ToString();
                dateOfBirth = (DateTime)row.Cells["Ngày sinh"].Value;
                sex = row.Cells["Giới tính"].Value.ToString();
                phone = row.Cells["Điện thoại"].Value.ToString();
                address = row.Cells["Địa chỉ"].Value.ToString();
            }

            txtIDEmployee.Text = id.ToString();
            txtEmployeeName.Text = fullName.ToString();
            dtbDateOfBirth.Value = dateOfBirth;
            txtSex.Text = sex.ToString();
            txtPhone.Text = phone.ToString();
            txtAddress.Text = address.ToString();
        }
    }
}
