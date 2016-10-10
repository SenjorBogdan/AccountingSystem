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
    public partial class ActionsWithTheGoods : Form
    {
        public ActionsWithTheGoods()
        {
            InitializeComponent();
        }

        private void ActionsWithTheGoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet3.Goods' table. You can move, or remove it, as needed.
            this.goodsTableAdapter.Fill(this.databaseDataSet3.Goods);

        }

        private void btnOrderProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnGoods_Click(object sender, EventArgs e)
        {

        }

        private void btnHistoryShopping_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
        }
    }
}
