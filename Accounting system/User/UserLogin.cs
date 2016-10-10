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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void btnControlPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActionsWithTheGoods actionsWithTheGoods = new ActionsWithTheGoods();
            actionsWithTheGoods.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }
    }
}
