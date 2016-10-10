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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGoods addGoods = new AddGoods();
            addGoods.Show();
        }

        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteGoods deleteGoods = new DeleteGoods();
            deleteGoods.Show();
        }

        private void btnBlockUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            BlockUser blockUser = new BlockUser();
            blockUser.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }
    }
}
