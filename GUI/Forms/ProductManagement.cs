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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void btnProductType_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForm pro = new ProductForm();
            pro.ShowDialog();
        }
    }
}
