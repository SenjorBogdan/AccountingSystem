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


        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProduct viewProduct = new ViewProduct();
            viewProduct.Show();
        }

        private void btnOrderProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderProduct orderProduct = new OrderProduct();
            orderProduct.Show();
        }

        private void btnReturnGoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnGoods returnGoods = new ReturnGoods();
            returnGoods.Show();
        }

        private void btnHistoryShopping_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoryShopping historyShopping = new HistoryShopping();
            historyShopping.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }
    }
}
