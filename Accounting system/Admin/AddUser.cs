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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.UserBase' table. You can move, or remove it, as needed.
            this.userBaseTableAdapter.Fill(this.databaseDataSet1.UserBase);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.AddUser(txtId.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }
    }
}
