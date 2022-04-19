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
    public partial class BillDetail : Form
    {
        BUS.Business _business = new BUS.Business();
        public BillDetail()
        {
            InitializeComponent();

            Display();
        }

        public void Display()
        {
            txtIDOrder.Enabled = false;
            dgvBillDetail.DataSource = _business.GetData("sp_BillDetail", "@ID", BillForm.idOrder);

            txtIDOrder.Clear();
            txtQuantity.Clear();
            txtIDOrder.Focus();
        }

        private void dgvBillDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBillDetail.Rows[e.RowIndex];
                txtIDOrder.Text = row.Cells["Mã mặt hàng"].Value.ToString();
                txtQuantity.Text = ((int)row.Cells["Số lượng"].Value).ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _business.DeleteData("sp_DeleteBillDetail", "@ID", txtIDOrder.Text);
            Display();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            _business.UpdateData("sp_UpdateBillDetails", "@SoDH", BillForm.idOrder, "@MaMatHang", txtIDOrder.Text, "@SoLuong", txtQuantity.Text);
            Display();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvBillDetail.DataSource = _business.GetData("sp_findBillDetail", "@TuKhoa", txtSearch.Text);
        }
    }
}
