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
    public partial class BlockUser : Form
    {
        public BlockUser()
        {
            InitializeComponent();
        }

        private void btnBlockUser_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            crud.BlockUser(txtId.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

        private void BlockUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet2.UserBase' table. You can move, or remove it, as needed.
            this.userBaseTableAdapter.Fill(this.databaseDataSet2.UserBase);

        }
    }
}
