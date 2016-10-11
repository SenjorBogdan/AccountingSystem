using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_system.User
{
    class User
    {
        public void Registration(string name, string lastName)
        {
            SqlConnection connect = new SqlConnection(Admin.Admin.connectionstring);
            SqlDataReader reader;

            string Name = name;
            string LastName = lastName;


            SqlCommand cmd = new SqlCommand("INSERT INTO UserBase VALUES (@Name,@LastName,@Status)", connect);
            cmd.Parameters.Add(new SqlParameter("@Name", Name));
            cmd.Parameters.Add(new SqlParameter("@LastName", LastName));
            cmd.Parameters.Add(new SqlParameter("@Status", false)); // false - заборонені дії в системі , true - дозволені дії в системі

            connect.Open();
            reader = cmd.ExecuteReader();
            connect.Close();

            MessageBox.Show("Успішна реєстрація");

        }
        public void OrderProduct(string id)
        {
            SqlConnection connect = new SqlConnection(Admin.Admin.connectionstring);
            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand("SELECT Name,Quantity FROM Goods WHERE Id = @Id ", connect);
            
            cmd.Parameters.Add(new SqlParameter("@Id",int.Parse(id)));
            connect.Open();

            reader = cmd.ExecuteReader();
            reader.Read();

            string name = reader[0].ToString();
            string quantity = reader[1].ToString();

            reader.Close();
            connect.Close();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO GoodsUser VALUES (@Name,@Quantity)", connect);

            cmd1.Parameters.Add(new SqlParameter("@Name", name));
            cmd1.Parameters.Add(new SqlParameter("@Quantity", int.Parse(quantity)));

            connect.Open();
            reader = cmd1.ExecuteReader();
            connect.Close();

            MessageBox.Show("Успішна реєстрація");

        }
        public void ReturnGoods()
        {

        }
        public void HistoryShopping()
        {

        }
    }
}
