using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_system.Admin
{
    class Admin
    {
        // Прописати свій connectionstring
        public static string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Orion\Documents\Visual Studio 2015\Projects\Accounting system\Accounting system\Database.mdf;Integrated Security = True;";

        public void AddUser(string id)
        {
            SqlConnection connect = new SqlConnection(Admin.connectionstring);
            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand("UPDATE UserBase SET Status = @Status WHERE Id = @Id", connect);
            cmd.Parameters.Add(new SqlParameter("@Status", true));
            cmd.Parameters.Add(new SqlParameter("@Id", int.Parse(id)));

            connect.Open();
            reader = cmd.ExecuteReader();
            connect.Close();
            MessageBox.Show("Користувач добавлений");

        }
        public void AddGoods(string name,string quantity )
        {
            SqlConnection connect = new SqlConnection(Admin.connectionstring);
            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand("INSERT INTO Goods VALUES (@Name,@Quantity)", connect);
            cmd.Parameters.Add(new SqlParameter("@Name", name));
            cmd.Parameters.Add(new SqlParameter("@Quantity", int.Parse(quantity)));

            connect.Open();
            reader = cmd.ExecuteReader();
            connect.Close();

            MessageBox.Show("Товар успішно добавлений");

        }
        public void DeleteGoods(string id)
        {
            SqlConnection connect = new SqlConnection(Admin.connectionstring);
            SqlCommand cmd = new SqlCommand("DELETE Goods WHERE Id = @id", connect);
            cmd.Parameters.Add(new SqlParameter("@id", int.Parse(id)));
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Товар успішно видалений");




        }
        public void BlockUser(string id)
        {
            SqlConnection connect = new SqlConnection(Admin.connectionstring);
            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand("UPDATE UserBase SET Status = @Status WHERE Id = @Id", connect);
            cmd.Parameters.Add(new SqlParameter("@Status", false));
            cmd.Parameters.Add(new SqlParameter("@Id", int.Parse(id)));

            connect.Open();
            reader = cmd.ExecuteReader();
            connect.Close();
            MessageBox.Show("Користувач заблокований");
        }
        public void Exit()
        {

        }
    }
}
