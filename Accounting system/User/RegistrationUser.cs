using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_system.User
{
    public partial class RegistrationUser : Form
    {
        public RegistrationUser()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            if (crud.Registration(txtLogin.Text, txtPassword.Text) == true)
            {
                this.Hide();
            }
            txtLogin.Text = "";
            txtPassword.Text = "";
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }
    }
}
