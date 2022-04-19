using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using GUI.Forms;

namespace GUI
{
    public partial class Home : Form
    {
        private Button btnCurrent;
        private Form curentChildForm;

        public Home()
        {
            InitializeComponent();
            this.Text = string.Empty;
            if(Login.res != 0 && Login.res != 1)
            {
                btnReport.Visible = false;
                btnAccountManagement.Visible = false;
            }
        }

        private void btnProductManagement_Click_1(object sender, EventArgs e)
        {
            ActButton(sender);
            CheckOpenChildForm();
            openChildForm(new ProductManagement());
        }

        private void btnBillManagement_Click_1(object sender, EventArgs e)
        {
            ActButton(sender);
            CheckOpenChildForm();
            openChildForm(new BillManagement());
        }

        private void btnAccountManagement_Click_1(object sender, EventArgs e)
        {
            ActButton(sender);
            CheckOpenChildForm();
            openChildForm(new AccountManagement());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            curentChildForm.Close();
            lblTitle.Text = "Trang chủ";
            DisButton();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActButton(sender);
            CheckOpenChildForm();
            openChildForm(new ReportForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openChildForm(Form childForm)
        {
            curentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisButton();
                btnCurrent = (Button)btnSender;
                btnCurrent.BackColor = Color.FromArgb(0, 154, 205);
                btnCurrent.ForeColor = Color.FromArgb(255, 255, 255);
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                btnCurrent.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void DisButton()
        {
            if (btnCurrent != null)
            {
                btnCurrent.BackColor = Color.FromArgb(0, 191, 255);
                btnCurrent.ForeColor = Color.White;
                btnCurrent.TextAlign = ContentAlignment.MiddleLeft;
                btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void CheckOpenChildForm()
        {
            if (curentChildForm != null)
                curentChildForm.Close();
            lblTitle.Text = btnCurrent.Text;
        }
    }
}
