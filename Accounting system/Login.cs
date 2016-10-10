using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.AdminLogin adminLogin = new Admin.AdminLogin();
            adminLogin.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            User.UserLogin userLogin = new User.UserLogin();
            userLogin.Show();
        }
    }
}
