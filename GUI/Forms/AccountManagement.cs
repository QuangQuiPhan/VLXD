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
    public partial class AccountManagement : Form
    {
        public AccountManagement()
        {
            InitializeComponent();
        }

        private void btnEmploy_Click(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm();
            emp.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountForm acc = new AccountForm();
            acc.ShowDialog();
        }

        private void btnAccountGroup_Click(object sender, EventArgs e)
        {
            AccountGroupForm group = new AccountGroupForm();
            group.ShowDialog();
        }
    }
}
