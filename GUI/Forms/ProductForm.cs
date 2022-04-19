using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI.Forms
{
    public partial class ProductForm : Form
    {
        Business _business = new Business();
        string _maMH, _tenMH, _donViTinh, _maLoai;
        double _donGia;
        
        public ProductForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            Display();
        }

        public void Display()
        {
            txtIDProduct.Clear();
            txtProductName.Clear();
            txtUnit.Clear();
            txtUnitPrice.Clear();
            txtIDProduct.Focus();
            cmbProductType.DisplayMember = "Tên loại hàng";
            cmbProductType.ValueMember = "Mã loại";
            cmbProductType.DataSource = _business.GetData("sp_Category");
            dgvLoadProducts.DataSource = _business.GetData("sp_products");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _business.AddData("sp_AddProduct", "@MaMH", _business.RandomID("MH"), "@TenMatHang", txtProductName.Text,
                "@DonViTinh", txtUnit.Text, "@DonGia", txtUnitPrice.Text, "@MaLoai", cmbProductType.SelectedValue.ToString());
            Display();
            dgvLoadProducts.DataSource = _business.GetData("sp_products");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            _business.UpdateData("sp_UpdateProduct", "@MaMH", txtIDProduct.Text, "@TenMatHang", txtProductName.Text,
                "@DonViTinh", txtUnit.Text, "@DonGia", txtUnitPrice.Text, "@MaLoai", cmbProductType.SelectedValue.ToString());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _business.DeleteData("sp_DeleteProduct", "@ID", txtIDProduct.Text);
            Display();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvLoadProducts.DataSource = _business.GetData("sp_findProduct", "@TuKhoa", txtSearch.Text);
        }

        private void dgvLoadProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoadProducts.Rows[e.RowIndex];
                _maMH = row.Cells["Mã mặt hàng"].Value.ToString();
                _tenMH = row.Cells["Tên mặt hàng"].Value.ToString();
                _donViTinh = row.Cells["Đơn vị tính"].Value.ToString();
                _donGia = (double)row.Cells["Đơn giá"].Value;
                _maLoai = row.Cells["Mã loại"].Value.ToString();
            }
            txtIDProduct.Text = _maMH;
            txtProductName.Text = _tenMH;
            txtUnit.Text = _donViTinh;
            txtUnitPrice.Text = _donGia.ToString();

            cmbProductType.SelectedValue = _maLoai.ToString();
        }
    }
}
