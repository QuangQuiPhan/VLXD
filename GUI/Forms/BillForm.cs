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
    public partial class BillForm : Form
    {
        BUS.Business _business = new BUS.Business();
        public BillForm()
        {
            InitializeComponent();
            this.Text = string.Empty;

            Display();
        }

        public void Display()
        {
            //Display on combobox
            cmbCustomer.DisplayMember = "Họ tên";
            cmbCustomer.ValueMember = "Mã khách hàng";
            cmbCustomer.DataSource = _business.GetData("sp_Customer");

            cmbEmployee.DisplayMember = "Họ tên nhân viên";
            cmbEmployee.ValueMember = "Mã nhân viên";
            cmbEmployee.DataSource = _business.GetData("sp_Employee");

            cmbProduct.DisplayMember = "Tên mặt hàng";
            cmbProduct.ValueMember = "Mã mặt hàng";
            cmbProduct.DataSource = _business.GetData("sp_products");

            //Display on datagridview
            dgvBill.DataSource = _business.GetData("sp_Bill");
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            _business.AddData("sp_AddBill", "@NgayDat", dtpBookingDate.Value, "@NgayGiao", dtpReceivedDate.Value, 
                "@DiaChiGiao", txtAddress.Text, "@MaNV", cmbEmployee.SelectedIndex, "@MaKH", cmbCustomer.SelectedIndex);
            dgvBill.DataSource = _business.GetData("sp_Bill");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _business.AddData("sp_AddBillDetails", "@SoDH", txtIDOrder.Text, "@MaMatHang", cmbProduct.SelectedIndex, "@SoLuong", txtQuantity.Text);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            _business.UpdateData("sp_UpdateBill", "@SoHD", txtIDOrder.Text, "@NgayDat", dtpBookingDate.Value, "@NgayGiao", dtpReceivedDate.Value.ToString(),
                "@DiaChiGiao", txtAddress.Text, "@MaNV", cmbEmployee.SelectedValue.ToString(), "@MaKH", cmbCustomer.SelectedValue.ToString());
            dgvBill.DataSource = _business.GetData("sp_Bill");
            txtIDOrder.Clear();
            txtAddress.Clear();
            dtpBookingDate.Value = DateTime.Now;
            dtpReceivedDate.Value = DateTime.Now;
            txtIDOrder.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _business.DeleteData("sp_DeleteBill", "@ID", txtIDOrder.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvBill.DataSource = _business.GetData("sp_Bill", "@TuKhoa", txtSearch.Text);
        }

        string address, idCustomer, idEmployee;
        public static int idOrder;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtIDOrder.Clear();
            txtQuantity.Clear();
            txtAddress.Focus();

            Display();
        }

        private void btnupbill_Click(object sender, EventArgs e)
        {
            _business.UpdateData("sp_UpdatePrice", "@ID", txtIDOrder.Text);
            dgvBill.DataSource = _business.GetData("sp_Bill");
        }

        private void btndetail_Click(object sender, EventArgs e)
        {
            if (idOrder > 0)
            {
                BillDetail billDetail = new BillDetail();
                billDetail.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng chọn đơn hàng!!!", "Thông báo");
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice();
            inv.ShowDialog();
        }

        DateTime booking, received;
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBill.Rows[e.RowIndex];
                idOrder = (int)row.Cells["Số đơn hàng"].Value;
                booking = (DateTime)row.Cells["Ngày đặt"].Value;
                received = (DateTime)row.Cells["Ngày giao"].Value;
                address = row.Cells["Địa chỉ giao"].Value.ToString();
                idCustomer = row.Cells["Mã khách hàng"].Value.ToString();
                idEmployee = row.Cells["Mã nhân viên"].Value.ToString();
            }

            txtIDOrder.Text = idOrder.ToString();
            txtAddress.Text = address.ToString();
            dtpBookingDate.Value = booking;
            dtpReceivedDate.Value = received;

            cmbCustomer.SelectedValue = idCustomer.ToString();
            
            cmbEmployee.SelectedValue = idEmployee.ToString();
        }
    }
}
