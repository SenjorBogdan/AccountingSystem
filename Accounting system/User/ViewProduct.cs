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

namespace Accounting_system.User
{
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
            Refresh();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            UserLogin userLogin = new UserLogin();
            userLogin.Show();

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
    }
}
