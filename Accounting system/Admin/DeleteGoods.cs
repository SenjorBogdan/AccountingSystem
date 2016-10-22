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
    public partial class DeleteGoods : Form
    {
        public DeleteGoods()
        {
            InitializeComponent();
        }

        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            crud.DeleteGoods(txtId.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

        private void DeleteGoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Goods' table. You can move, or remove it, as needed.
            this.goodsTableAdapter.Fill(this.databaseDataSet.Goods);

        }
    }
}
