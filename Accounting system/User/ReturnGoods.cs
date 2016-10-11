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
    public partial class ReturnGoods : Form
    {
        public ReturnGoods()
        {
            InitializeComponent();
        }

        private void ReturnGoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet6.GoodsUser' table. You can move, or remove it, as needed.
            this.goodsUserTableAdapter.Fill(this.databaseDataSet6.GoodsUser);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ReturnGoods(txtID.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
        }
    }
}
