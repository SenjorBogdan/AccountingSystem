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
            crud.AddUser(txtId.Text,statusCheckBox.Checked);
            Refresh();

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
            crud.AddPrivileges(txtId.Text,privilegeCheckBox.Checked);
            Refresh();

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        public void Refresh()
        {
            baseUserRichTextBox.Clear();
            SqlConnection connection = new SqlConnection(CRUD.connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM UserBase", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"UserBase");
            baseUserRichTextBox.Text += "ID" + "\t" + "Логін" + "\t\t" + "Статус" + "\t" + "Привілегії" + "\n " + new string('-',90) + "\n";

            foreach (DataRow dr in ds.Tables["UserBase"].Rows)
            {
                baseUserRichTextBox.Text += dr["Id"] + "\t" + dr["Login"] + "\t\t" + dr["Status"] + "\t" + dr["Privileges"] + "\n";
            }
        }
    }
}
