using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_system
{
    class CRUD
    {
      public static string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Gitab Project\AccountingSystem\Accounting system\Database.mdf;Integrated Security=True;";

        // Добавлення користувача
        public void AddUser(string id,bool status)
        {
            if (id == "")
            {
                MessageBox.Show("Ведіть ID");
            }
            else
            {

            SqlConnection connect = new SqlConnection(connectionstring);
            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand("UPDATE UserBase SET Status = @Status WHERE Id = @Id", connect);
            cmd.Parameters.Add(new SqlParameter("@Status", status));
            cmd.Parameters.Add(new SqlParameter("@Id", int.Parse(id)));

            connect.Open();
            reader = cmd.ExecuteReader();
            connect.Close();
            MessageBox.Show("Статус користувача добавлений");
            }

        }
        // Добавлення товару
        public void AddGoods(string name, string quantity)
        {
            SqlConnection connect = new SqlConnection(connectionstring);
            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand("INSERT INTO Goods VALUES (@Name,@Quantity)", connect);
            cmd.Parameters.Add(new SqlParameter("@Name", name));
            cmd.Parameters.Add(new SqlParameter("@Quantity", int.Parse(quantity)));

            connect.Open();
            reader = cmd.ExecuteReader();
            connect.Close();

            MessageBox.Show("Товар успішно добавлений");

        }
        // Видалення товару
        public void DeleteGoods(string id)
        {
            SqlConnection connect = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("DELETE Goods WHERE Id = @id", connect);
            cmd.Parameters.Add(new SqlParameter("@id", int.Parse(id)));
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Товар успішно видалений");


        }
        // Блокування користувача
        public void BlockUser(string id)
        {
            SqlConnection connect = new SqlConnection(connectionstring);
            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand("UPDATE UserBase SET Status = @Status WHERE Id = @Id", connect);
            cmd.Parameters.Add(new SqlParameter("@Status", false));
            cmd.Parameters.Add(new SqlParameter("@Id", int.Parse(id)));

            connect.Open();
            reader = cmd.ExecuteReader();
            connect.Close();
            MessageBox.Show("Користувач заблокований");
        }
        public void Registration(string login, string password)
        {
            // Реєстрація
            SqlConnection connect = new SqlConnection(connectionstring);
            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand("INSERT INTO UserBase VALUES (@Login,@Password,@Status,@Privileges)", connect);
            cmd.Parameters.Add(new SqlParameter("@Login", login));
            cmd.Parameters.Add(new SqlParameter("@Password", password));
            cmd.Parameters.Add(new SqlParameter("@Status", false)); // false - заборонені дії в системі , true - дозволені дії в системі
            cmd.Parameters.Add(new SqlParameter("@Privileges", false));


            connect.Open();
            reader = cmd.ExecuteReader();
            connect.Close();

            MessageBox.Show("Успішна реєстрація");

            User.UserLogin userLogin = new User.UserLogin();
            userLogin.Show();

        }
        public void OrderProduct(string id)
        {
            // Питягування даних для подальшого перенесення
            SqlConnection connect = new SqlConnection(connectionstring);
            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand("SELECT Name,Quantity FROM Goods WHERE Id = @Id ", connect);

            cmd.Parameters.Add(new SqlParameter("@Id", int.Parse(id)));
            connect.Open();

            reader = cmd.ExecuteReader();
            reader.Read();

            string name = (string)reader[0];
            int quantity = (int)reader[1];

            reader.Close();
            connect.Close();
            // Перенесення даних з таблиці переліку товарів
            SqlCommand cmd1 = new SqlCommand("INSERT INTO GoodsUser VALUES (@Name,@Quantity)", connect);

            cmd1.Parameters.Add(new SqlParameter("@Name", name));
            cmd1.Parameters.Add(new SqlParameter("@Quantity", quantity));

            connect.Open();
            reader = cmd1.ExecuteReader();
            connect.Close();

            //  Історія покупок(внесення в історію даних)
            SqlCommand cmd2 = new SqlCommand("INSERT INTO HistoryShopping VALUES (@Name,@Quantity)", connect);

            cmd2.Parameters.Add(new SqlParameter("@Name", name));
            cmd2.Parameters.Add(new SqlParameter("@Quantity", quantity));

            connect.Open();
            reader = cmd2.ExecuteReader();
            connect.Close();

            MessageBox.Show("Замовлення успішно виконане");

        }
        // Повернення товару
        public void ReturnGoods(string id)
        {
            SqlConnection connect = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("DELETE GoodsUser WHERE Id = @id", connect);
            cmd.Parameters.Add(new SqlParameter("@id", int.Parse(id)));
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Товар успішно повернено");
        }
        // Історія покупок(видалення історії)
        public void DeleteHistoryShopping()
        {
            SqlConnection connect = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("DELETE FROM HistoryShopping", connect);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Історія успішно очищена");
        }

        public void Ligin(string login, string password)
        {
            SqlConnection connect = new SqlConnection(connectionstring);
            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand("SELECT Login,Password,Privileges FROM UserBase WHERE Login = @Login and Password = @Password ", connect);

            cmd.Parameters.Add(new SqlParameter("@Login", login));
            cmd.Parameters.Add(new SqlParameter("@Password", password));

            connect.Open();
            reader = cmd.ExecuteReader();

            reader.Read();

         

            if (!reader.HasRows)
            {
                MessageBox.Show("Вибачте,ви не зареєстровані", "УПС");
            }
            else
            {
                bool privilege = (bool)reader[2];

                if (privilege == true)
                {
                    Admin.AdminLogin AdminLogin = new Admin.AdminLogin();
                    AdminLogin.Show();
                }
                else
                {
                    User.UserLogin user = new User.UserLogin();
                    user.Show();
                }
            }

            connect.Close();
        }
        // Добавити привілегій користувачу
        public void AddPrivileges(string id, bool privileges)
        {
            if (id == "")
            {
                MessageBox.Show("Введіть ID");
            }
            else
            {

            SqlConnection connect = new SqlConnection(connectionstring);
            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand("UPDATE UserBase SET Privileges = @Privileges WHERE Id = @Id", connect);
            cmd.Parameters.Add(new SqlParameter("@Privileges", privileges));
            cmd.Parameters.Add(new SqlParameter("@Id", int.Parse(id)));


            connect.Open();
            reader = cmd.ExecuteReader();
            connect.Close();

            MessageBox.Show("Статус привілегії добавлений");
                
            }

        }


        public void Exit()
        {

        }
    }
}
