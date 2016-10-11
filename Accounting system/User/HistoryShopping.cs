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
    public partial class HistoryShopping : Form
    {
        public HistoryShopping()
        {
            InitializeComponent();
        }

        private void HistoryShopping_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet7.HistoryShopping' table. You can move, or remove it, as needed.
            this.historyShoppingTableAdapter.Fill(this.databaseDataSet7.HistoryShopping);

        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.HistoryShopping();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
        }

    }
}
