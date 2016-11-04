using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_system.Admin
{
    public partial class AddGoods : Form
    {
        public AddGoods()
        {
            InitializeComponent();
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            
            CRUD crud = new CRUD();
            crud.AddGoods(txtName.Text, txtQuantity.Text);
            txtName.Text = "";
            txtQuantity.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
