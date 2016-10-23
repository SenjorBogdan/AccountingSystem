using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Refresh();
        }

        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            crud.DeleteGoods(txtId.Text);
            Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

        public void Refresh()
        {
            IDRichTextBox.Clear();
            NameRichTextBox.Clear();
            quantityRichTextBox.Clear();
           SqlConnection connection = new SqlConnection(CRUD.connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Goods", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Goods");
            foreach (DataRow dr in ds.Tables["Goods"].Rows)
            {
                IDRichTextBox.Text += dr["Id"] + "\n";
                NameRichTextBox.Text += dr["Name"] + "\n";
                quantityRichTextBox.Text += dr["Quantity"] + "\n";

            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
