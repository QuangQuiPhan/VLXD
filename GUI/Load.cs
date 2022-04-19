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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            timeLoad.Start();
        }

        private void timeLoad_Tick(object sender, EventArgs e)
        {
            myProgress.Value += 1;
            lblLoad.Text = (myProgress.Value + "%").ToString();
            if (myProgress.Value == 100)
            {
                timeLoad.Stop();
                Login login = new Login();
                this.Close();
                login.ShowDialog();
            }
        }
    }
}
