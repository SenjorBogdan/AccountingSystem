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
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet4.Goods' table. You can move, or remove it, as needed.
            this.goodsTableAdapter.Fill(this.databaseDataSet4.Goods);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
        }
    }
}
