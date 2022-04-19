using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
            this.Text = string.Empty;
        }

        BUS.Business _business = new BUS.Business();
        private void Invoice_Load(object sender, EventArgs e)
        {
            CrystalReportInvoice crv = new CrystalReportInvoice();
            crv.SetDataSource(_business.GetData("sp_Invoice", "@ID", Forms.BillForm.idOrder));
            crvinvoice.ReportSource = crv;
        }
    }
}
