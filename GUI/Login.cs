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
    public partial class Login : Form
    {
        BUS.Business _business = new BUS.Business();
        public Login()
        {
            InitializeComponent();
        }

        public static int res = -1;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            res = _business.login("sp_login", "@username", txtUsername.Text.Trim(), "@password", txtPassword.Text.Trim());
            if (res != -1)
            {
                Home home = new Home();
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
