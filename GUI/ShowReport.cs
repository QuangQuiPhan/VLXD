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
    public partial class ShowReport : Form
    {
        public ShowReport()
        {
            InitializeComponent();
            this.Text = string.Empty;
        }

        BUS.Business _business = new BUS.Business();

        DateTime start = Forms.ReportForm.dateStart;
        DateTime end = Forms.ReportForm.dateEnd;
        private void ShowReport_Load(object sender, EventArgs e)
        {
            CrystalReport cr = new CrystalReport();
            cr.SetDataSource(_business.GetData("sp_Report", "@NgayBD", start, "@NgayKT", end));
            crvReport.ReportSource = cr;
        }
    }
}
