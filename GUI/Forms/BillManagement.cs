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
    public partial class BillManagement : Form
    {
        public BillManagement()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cus = new CustomerForm();
            cus.ShowDialog();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            BillForm bill = new BillForm();
            bill.ShowDialog();
        }
    }
}
