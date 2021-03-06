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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
        }

        public static DateTime dateStart, dateEnd;
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            dateStart = dtpDateStart.Value;
            dateEnd = dtpDateEnd.Value;
            ShowReport sr = new ShowReport();
            sr.ShowDialog();
        }
    }
}
