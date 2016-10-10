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
        public void OrderProduct()
        {

        }
        public void ReturnGoods()
        {

        }
        public void HistoryShopping()
        {

        }
    }
}
