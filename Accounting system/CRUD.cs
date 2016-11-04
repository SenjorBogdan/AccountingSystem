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
        public static int userId;
        public static string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Gitab Project\AccountingSystem\Accounting system\Database.mdf;Integrated Security=True;";
        // Добавлення користувача
        public void AddUser(string id, bool status)
        {
            if (id == "")
            {
                MessageBox.Show("Ведіть ID");
            }
            else
            {
                SqlConnection connect = new SqlConnection(connectionstring);
                SqlDataReader reader;
                SqlCommand cmd1 = new SqlCommand("Select Id FROM UserBase WHERE Id = @id", connect);

                cmd1.Parameters.Add(new SqlParameter("@id", int.Parse(id)));

                connect.Open();
                reader = cmd1.ExecuteReader();
                reader.Read();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Введений невірний ID");
                    reader.Close();
                    connect.Close();
                }
                else
                {
                    reader.Close();
                    connect.Close();
                    SqlCommand cmd = new SqlCommand("UPDATE UserBase SET Status = @Status WHERE Id = @Id", connect);
                    cmd.Parameters.Add(new SqlParameter("@Status", status));
                    cmd.Parameters.Add(new SqlParameter("@Id", int.Parse(id)));

                    connect.Open();
                    reader = cmd.ExecuteReader();
                    connect.Close();

                    MessageBox.Show("Статус користувача добавлений");
                }
            }
        }
        // Добавлення товару
        public void AddGoods(string name, string quantity)
        {
            if (name == "" | quantity == "")
            {
                MessageBox.Show("Введіть назву товару і кількість товару");
            }
            else
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
        }
        // Видалення товару
        public void DeleteGoods(string id, string quantity)
        {
            if (id == "" | quantity == "")
            {
                MessageBox.Show("Введіть ID і кількість товару");
            }
            else
            {
                SqlConnection connect = new SqlConnection(connectionstring);
                SqlDataReader reader;
                SqlCommand cmd1 = new SqlCommand("Select Quantity FROM Goods WHERE Id = @id", connect);

                cmd1.Parameters.Add(new SqlParameter("@id", int.Parse(id)));

                connect.Open();
                reader = cmd1.ExecuteReader();
                reader.Read();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Введений невірний ID");
                    reader.Close();
                    connect.Close();
                }
                else
                {
                    int quantit = (int)reader[0] - int.Parse(quantity);

                    reader.Close();
                    connect.Close();

                    if (quantit <= 0)
                    {
                        SqlCommand cmd = new SqlCommand("DELETE Goods WHERE Id = @id", connect);
                        cmd.Parameters.Add(new SqlParameter("@id", int.Parse(id)));

                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();

                        MessageBox.Show("Товар успішно видалений");
                    }
                    else
                    {
                        SqlCommand cmd2 = new SqlCommand("UPDATE Goods SET Quantity = @Quantity WHERE Id = @Id", connect);
                        cmd2.Parameters.Add(new SqlParameter("@Id", int.Parse(id)));
                        cmd2.Parameters.Add(new SqlParameter("@Quantity", quantit));

                        connect.Open();
                        reader = cmd2.ExecuteReader();
                        connect.Close();

                        MessageBox.Show("Товар успішно видалений");
                    }
                }
            }
        }
        // Блокування користувача
        public void BlockUser(string id)
        {
            if (id == "")
            {
                MessageBox.Show("Введіть ID");
            }
            else
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
        }
        // Реєстрація
        public bool Registration(string login, string password)
        {
            if (login == "" | password == "")
            {
                MessageBox.Show("Введіть логін і пароль");
                return false;
            }
            else
            {
                SqlConnection connect = new SqlConnection(connectionstring);
                SqlDataReader reader;

                SqlCommand cmd1 = new SqlCommand("SELECT Login FROM UserBase WHERE Login = @Login", connect);
                cmd1.Parameters.Add(new SqlParameter("@Login", login));

                connect.Open();
                reader = cmd1.ExecuteReader();
                reader.Read();

                if (!reader.HasRows)
                {
                    // Реєстрація
                    connect.Close();
                    reader.Close();

                    SqlCommand cmd = new SqlCommand("INSERT INTO UserBase VALUES (@Login,@Password,@Status,@Privileges)", connect);
                    cmd.Parameters.Add(new SqlParameter("@Login", login));
                    cmd.Parameters.Add(new SqlParameter("@Password", password.GetHashCode()));
                    cmd.Parameters.Add(new SqlParameter("@Status", false)); // false - заборонені дії в системі , true - дозволені дії в системі
                    cmd.Parameters.Add(new SqlParameter("@Privileges", false));

                    connect.Open();
                    reader = cmd.ExecuteReader();
                    connect.Close();

                    User.UserLogin userLogin = new User.UserLogin();
                    userLogin.Show();

                    MessageBox.Show("Успішна реєстрація");
                    return true;
                }
                MessageBox.Show("Цей Логін вже занятий");
                return false;
            }
        }
        // Замовлення товару
        public void OrderProduct(string id, string quantity)
        {
            SqlConnection connect = new SqlConnection(connectionstring);
            SqlDataReader reader;
            SqlCommand cmd11 = new SqlCommand("Select Status FROM UserBase WHERE Id = @id", connect);
            cmd11.Parameters.Add(new SqlParameter("@id", userId));

            connect.Open();
            reader = cmd11.ExecuteReader();
            reader.Read();

            bool statusRead = (bool)reader[0];

            if (statusRead == false)
            {
                MessageBox.Show("Статус активності відсутній, очікуйте підтвердження зі сторони адміністратора");
            }

            else
            {
                if (id == "" | quantity == "")
                {
                    MessageBox.Show("Введіть ID і кількість");
                }
                else
                {
                    reader.Close();
                    connect.Close();
                    // Пергляд даних для подальшого перенесення
                    SqlCommand cmd = new SqlCommand("SELECT Name,Quantity FROM Goods WHERE Id = @Id ", connect);
                    cmd.Parameters.Add(new SqlParameter("@Id", int.Parse(id)));

                    connect.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Введений невірний ID");
                        reader.Close();
                        connect.Close();
                    }
                    else
                    {
                        string name = (string)reader[0];
                        int quantit = (int)reader[1] - int.Parse(quantity);
                        reader.Close();
                        connect.Close();
                        if (quantit > 0)
                        {
                            reader.Close();
                            connect.Close();
                            // Перенесення даних з таблиці переліку товарів в таблицю користувача
                            SqlCommand cmd1 = new SqlCommand("INSERT INTO GoodsUser VALUES (@Name,@Quantity,@UserId)", connect);
                            cmd1.Parameters.Add(new SqlParameter("@Name", name));
                            cmd1.Parameters.Add(new SqlParameter("@Quantity", quantity));
                            cmd1.Parameters.Add(new SqlParameter("@UserId", userId));

                            // Занесення кількості товарів в загальну таблицю товарів
                            SqlCommand cmd3 = new SqlCommand("UPDATE Goods SET Quantity = @Quantity WHERE Id = @Id", connect);
                            cmd3.Parameters.Add(new SqlParameter("@Id", int.Parse(id)));
                            cmd3.Parameters.Add(new SqlParameter("@Quantity", quantit));

                            connect.Open();
                            reader = cmd1.ExecuteReader();
                            connect.Close();


                            connect.Open();
                            reader = cmd3.ExecuteReader();
                            connect.Close();

                            // внесення даних в історію покупок
                            SqlCommand cmd2 = new SqlCommand("INSERT INTO HistoryShopping VALUES (@Name,@Quantity,@IdUser)", connect);
                            cmd2.Parameters.Add(new SqlParameter("@Name", name));
                            cmd2.Parameters.Add(new SqlParameter("@Quantity", quantity));
                            cmd2.Parameters.Add(new SqlParameter("@IdUser", CRUD.userId));

                            connect.Open();
                            reader = cmd2.ExecuteReader();
                            connect.Close();

                            MessageBox.Show("Замовлення успішно виконане");
                        }
                        else if (quantit == 0)
                        {
                            reader.Close();
                            connect.Close();

                            // Занесення даних в історію покупок
                            SqlCommand cmd6 = new SqlCommand("INSERT INTO HistoryShopping VALUES (@Name,@Quantity,@IdUser)", connect);
                            cmd6.Parameters.Add(new SqlParameter("@Name", name));
                            cmd6.Parameters.Add(new SqlParameter("@Quantity", quantity));
                            cmd6.Parameters.Add(new SqlParameter("@IdUser", CRUD.userId));

                            connect.Open();
                            reader = cmd6.ExecuteReader();
                            connect.Close();

                            // Видалення товару з основної таблиці 
                            SqlCommand cmd4 = new SqlCommand("DELETE Goods WHERE Id = @id", connect);
                            cmd4.Parameters.Add(new SqlParameter("@id", int.Parse(id)));

                            connect.Open();
                            cmd4.ExecuteNonQuery();
                            connect.Close();

                            // Занесення даних в таблицю користувача
                            SqlCommand cmd5 = new SqlCommand("INSERT INTO GoodsUser VALUES (@Name,@Quantity,@UserId)", connect);
                            cmd5.Parameters.Add(new SqlParameter("@Name", name));
                            cmd5.Parameters.Add(new SqlParameter("@Quantity", int.Parse(quantity)));
                            cmd5.Parameters.Add(new SqlParameter("@UserId", userId));

                            connect.Open();
                            reader = cmd5.ExecuteReader();
                            connect.Close();

                            MessageBox.Show("Товар успішно замовлено");
                        }
                        else
                        {
                            reader.Close();
                            connect.Close();

                            MessageBox.Show("Кількість замовлення перевищує кількість товару яка є в наявності на складі");
                        }
                    }
                    //  Історія покупок(внесення в історію даних)
                }
            }
        }
        // Повернення товару
        public void ReturnGoods(string id, string quantity)
        {
            SqlConnection connect = new SqlConnection(connectionstring);
            SqlDataReader reader;

            SqlCommand cmd11 = new SqlCommand("Select Status FROM UserBase WHERE Id = @id", connect);
            cmd11.Parameters.Add(new SqlParameter("@id", userId));

            connect.Open();
            reader = cmd11.ExecuteReader();
            reader.Read();

            bool statusRead = (bool)reader[0];

            if (statusRead == false)
            {
                MessageBox.Show("Статус активності відсутній, очікуйте підтвердження зі сторони адміністратора");
            }
            else
            {
                if (id == "" | quantity == "")
                {
                    MessageBox.Show("Введіть ID");
                }
                else
                {
                    connect.Close();
                    reader.Close();
                    // Перегляд даних для подальшого перенесення

                    SqlCommand cmd1 = new SqlCommand("SELECT Name,Quantity FROM GoodsUser WHERE Id = @Id ", connect);
                    cmd1.Parameters.Add(new SqlParameter("@id", int.Parse(id)));

                    connect.Open();
                    reader = cmd1.ExecuteReader();
                    reader.Read();
                    if (!reader.HasRows)
                    {
                        connect.Close();
                        reader.Close();

                        MessageBox.Show("Введений невірний ID");
                    }
                    else
                    {
                        string name = (string)reader[0];
                        int quantit = (int)reader[1] - int.Parse(quantity);
                        connect.Close();

                        if (quantit > 0)
                        {
                            connect.Close();
                            reader.Close();
                            // Занесення кількості товарів користувачу
                            SqlCommand cmd3 = new SqlCommand("UPDATE GoodsUser SET Quantity = @Quantity WHERE Id = @Id", connect);
                            cmd3.Parameters.Add(new SqlParameter("@Id", int.Parse(id)));
                            cmd3.Parameters.Add(new SqlParameter("@Quantity", quantit));

                            connect.Open();
                            reader = cmd3.ExecuteReader();
                            connect.Close();

                            // Занесення кількості товарів в загальну таблицю
                            SqlCommand cmd2 = new SqlCommand("INSERT INTO Goods VALUES (@Name,@Quantity)", connect);
                            cmd2.Parameters.Add(new SqlParameter("@Name", name));
                            cmd2.Parameters.Add(new SqlParameter("@Quantity", quantity));

                            connect.Open();
                            reader = cmd2.ExecuteReader();
                            connect.Close();

                            MessageBox.Show("Товар успішно повернено");
                        }
                        else if (quantit == 0)
                        {
                            connect.Close();
                            reader.Close();

                            // Видалення товару з таблиці користувача 
                            SqlCommand cmd = new SqlCommand("DELETE GoodsUser WHERE Id = @id", connect);
                            cmd.Parameters.Add(new SqlParameter("@id", int.Parse(id)));

                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();

                            SqlCommand cmd4 = new SqlCommand("INSERT INTO Goods VALUES (@Name,@Quantity)", connect);
                            cmd4.Parameters.Add(new SqlParameter("@Name", name));
                            cmd4.Parameters.Add(new SqlParameter("@Quantity", quantity));

                            connect.Open();
                            reader = cmd4.ExecuteReader();
                            connect.Close();

                            MessageBox.Show("Товар успішно повернено");
                        }
                        else
                        {
                            connect.Close();
                            reader.Close();

                            MessageBox.Show("Перевищена кількість товару повернення");
                        }
                    }
                }
            }
        }
        // Історія покупок(видалення історії)
        public void DeleteHistoryShopping()
        {
            SqlConnection connect = new SqlConnection(connectionstring);
            SqlDataReader reader;

            SqlCommand cmd11 = new SqlCommand("Select Status FROM UserBase WHERE Id = @id", connect);
            cmd11.Parameters.Add(new SqlParameter("@id", userId));

            connect.Open();
            reader = cmd11.ExecuteReader();
            reader.Read();

            bool statusRead = (bool)reader[0];

            if (statusRead == false)
            {
                MessageBox.Show("Статус активності відсутній, очікуйте підтвердження зі сторони адміністратора");
            }
            else
            {
                connect.Close();
                reader.Close();

                SqlCommand cmd = new SqlCommand("DELETE FROM HistoryShopping WHERE IdUser = @Id ", connect);
                cmd.Parameters.Add(new SqlParameter("@Id", CRUD.userId));

                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("Історія успішно очищена");
            }
        }
        public bool Login(string login, string password)
        {
            if (login == "" | password == "")
            {
                MessageBox.Show("Введіть логін і пароль");
                return false;
            }
            else
            {
                SqlConnection connect = new SqlConnection(connectionstring);
                SqlDataReader reader;

                SqlCommand cmd = new SqlCommand("SELECT Login,Password,Privileges,Id FROM UserBase WHERE Login = @Login and Password = @Password ", connect);
                cmd.Parameters.Add(new SqlParameter("@Login", login));
                cmd.Parameters.Add(new SqlParameter("@Password", password.GetHashCode().ToString()));

                connect.Open();
                reader = cmd.ExecuteReader();
                reader.Read();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Вибачте,ви не зареєстровані", "УПС");
                    return false;
                }
                else
                {
                    bool privilege = (bool)reader[2];
                    CRUD.userId = (int)reader[3];
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
                return true;
            }
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
                SqlCommand cmd1 = new SqlCommand("Select Id FROM UserBase WHERE Id = @id", connect);
                cmd1.Parameters.Add(new SqlParameter("@id", int.Parse(id)));

                connect.Open();
                reader = cmd1.ExecuteReader();
                reader.Read();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Введений невірний ID");
                    reader.Close();
                    connect.Close();
                }

                else
                {
                    reader.Close();
                    connect.Close();

                    SqlCommand cmd = new SqlCommand("UPDATE UserBase SET Privileges = @Privileges WHERE Id = @Id", connect);
                    cmd.Parameters.Add(new SqlParameter("@Privileges", privileges));
                    cmd.Parameters.Add(new SqlParameter("@Id", int.Parse(id)));

                    connect.Open();
                    reader = cmd.ExecuteReader();
                    connect.Close();

                    MessageBox.Show("Статус привілегії добавлений");
                }
            }
        }
    }
}
