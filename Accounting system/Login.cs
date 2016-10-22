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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            crud.Ligin(txtLogin.Text,txtPassword.Text);
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            User.RegistrationUser registration = new User.RegistrationUser();
            registration.Show();
        }
    }
}
