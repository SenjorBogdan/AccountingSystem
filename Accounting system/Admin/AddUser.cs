using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Accounting_system.Admin
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            Refresh();
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            crud.AddUser(txtId.Text, statusCheckBox.Checked);
            Refresh();
            Refresh();
            txtId.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }
        private void AddPrivileges_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            crud.AddPrivileges(txtId.Text, privilegeCheckBox.Checked);
            Refresh();
            txtId.Text = "";


        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {

            IDRichTextBox.Clear();
            loginRichTextBox.Clear();
            statusRichTextBox.Clear();
            privilegesRichTextBox.Clear();
            SqlConnection connection = new SqlConnection(CRUD.connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM UserBase", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"UserBase");
            foreach (DataRow dr in ds.Tables["UserBase"].Rows)
            {

                IDRichTextBox.Text += dr["Id"] + "\n";
                loginRichTextBox.Text += dr["Login"] + "\n";
                statusRichTextBox.Text += dr["Status"] + "\n";
                privilegesRichTextBox.Text += dr["Privileges"] + "\n";

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
