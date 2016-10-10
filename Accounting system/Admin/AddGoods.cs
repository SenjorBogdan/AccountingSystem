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
            Admin admin = new Admin();
            admin.AddGoods(txtName.Text,txtQuantity.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }
    }
}
