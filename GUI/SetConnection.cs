using BUS;
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
    public partial class SetConnection : Form
    {
        BUS.Business _business = new Business();

        public SetConnection()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(_business.CheckConnect(txtServer.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text))
            {
                Load load = new Load();
                load.Show();
                this.Hide();
            }
            else
            {
                txtServer.Clear();
                txtDatabase.Clear();
                txtUser.Clear();
                txtPassword.Clear();
                txtServer.Focus();

                MessageBox.Show("Không thể kết nối với máy chủ");
            }
        }
    }
}
