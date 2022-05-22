using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BD_Olympiad
{
    public partial class Registration : Form
    {

        //private object email;

        public Registration()
        {
            InitializeComponent();

            //ProfileEnum.Text = "Организатор";
            FullNameBox.Text = "Введите данные";
            EmailBox.Text = "Введите Email";
            PhoneBox.Text = "Введите номер телефона";
            PasswordBox.Text = "Введите пароль";
        }

        private void RegisrButton_Click(object sender, EventArgs e)
        {
            int i = 3;
            i++;

            //IsValidEmail maskEmail = new IsValidEmail();
            /* Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
             if (!reg.IsMatch(EmailBox.Text))
             {
                 MessageBox.Show("yes");
             }
             else
             {
                 MessageBox.Show("no");
             }*/

            // Провека на все поля
            if (ProfileEnum.Text == "")
            {
                MessageBox.Show("Eror: 121 (Выберите профиль)");
            }
            else if (FullNameBox.Text == "Введите данные")
            {
                MessageBox.Show("Eror: 122 (Введите данные в поле 'ФИО')");
            }
            else if (EmailBox.Text == "Введите Email")
            {
                MessageBox.Show("Eror: 123 (Введите данные в поле 'Email')");
            }
            else if (PhoneBox.Text == "Введите номер телефона")
            {
                MessageBox.Show("Eror: 124 (Введите данные в поле 'Телефон')");
            }
            else if (PasswordBox.Text == "Введите пароль")
            {
                MessageBox.Show("Eror: 125 (Введите пароль)");
            }
            



            if (isUsersExists()) // Проверка на повторного пользователя
            {
                return;
                //ProfileEnum.Text = "Организатор";
                FullNameBox.Text = "Введите данные";
                EmailBox.Text = "Введите Email";
                PhoneBox.Text = "Введите номер телефона";
                PasswordBox.Text = "Введите пароль";
            }


            
            DB db = new DB();

            //Заносим данные в таблицу users
            MySqlCommand commandUsers = new MySqlCommand("INSERT INTO `users` (`id`,`Profile`, `Email`, `Password`) VALUES (@id,@Profile, @Email, @Pass)", db.getConnection());

            commandUsers.Parameters.Add("@id", MySqlDbType.Int32).Value = i;
            commandUsers.Parameters.Add("@Profile", MySqlDbType.Enum).Value = ProfileEnum.Text;
            commandUsers.Parameters.Add("@Email", MySqlDbType.VarChar).Value = EmailBox.Text;
            commandUsers.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = PasswordBox.Text;       
            

            db.openConnection();

            //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE id = ;", db.getConnection());

            // Проверяем на организатора и заносим данные в таблицу организоторов
            if (ProfileEnum.Text == "Организатор") 
            {
                MySqlCommand commandProfile = new MySqlCommand("INSERT INTO `organizer` (`id`,`FullName`, `Birthday`, `Phone`, `Email`) VALUES (@idOr, @FullName, @Birthday, @Phone, @Email)", db.getConnection());
                
                commandProfile.Parameters.Add("@idOr", MySqlDbType.Int32).Value = i;
                commandProfile.Parameters.Add("@FullName", MySqlDbType.VarChar).Value = FullNameBox.Text;
                commandProfile.Parameters.Add("@Birthday", MySqlDbType.Date).Value = DateOfBirth.Value;
                commandProfile.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = PhoneBox.Text;
                commandProfile.Parameters.Add("@Email", MySqlDbType.VarChar).Value = EmailBox.Text;


            }
            // Проверяем на участника и заносим данные в таблицу участников
            else if (ProfileEnum.Text == "Участник") 
            {
                MySqlCommand commandProfile = new MySqlCommand("INSERT INTO `member` (`id`,`FullName`, `Birthday`, `Phone`, `Email`) VALUES (@idMem, @FullName, @Birthday, @Phone, @Email)", db.getConnection());
                
                commandProfile.Parameters.Add("@idMem", MySqlDbType.Int32).Value = i;
                commandProfile.Parameters.Add("@FullName", MySqlDbType.VarChar).Value = FullNameBox.Text;
                commandProfile.Parameters.Add("@Birthday", MySqlDbType.Date).Value = DateOfBirth.Value;
                commandProfile.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = PhoneBox.Text;
                commandProfile.Parameters.Add("@Email", MySqlDbType.VarChar).Value = EmailBox.Text;


            }
            else
            {
                MessageBox.Show("Error: 121 (Выберите профиль)");
            }




            db.CloseConnection();
        }

        //Невидимая подсказка
        private void FullNameBox_Enter(object sender, EventArgs e)
        {
            if (FullNameBox.Text == "Введите данные")
            {
                FullNameBox.Text = "";
                FullNameBox.ForeColor = Color.Black;
            }

        }

        private void FullNameBox_Leave(object sender, EventArgs e)
        {
            if (FullNameBox.Text == "")
            {
                FullNameBox.Text = "Введите данные";
                FullNameBox.ForeColor = Color.Gray;
            }

        }

        private void EmailBox_Enter(object sender, EventArgs e)
        {
            if (EmailBox.Text == "Введите Email")
            {
                EmailBox.Text = "";
                EmailBox.ForeColor = Color.Black;
            }
        }

        private void EmailBox_Leave(object sender, EventArgs e)
        {
            if (EmailBox.Text == "")
            {
                EmailBox.Text = "Введите Email";
                EmailBox.ForeColor = Color.Gray;
            }
        }

        private void PhoneBox_Enter(object sender, EventArgs e)
        {
            if (PhoneBox.Text == "Введите номер телефона")
            {
                PhoneBox.Text = "";
                PhoneBox.ForeColor = Color.Black;
            }
        }

        private void PhoneBox_Leave(object sender, EventArgs e)
        {
            if (PhoneBox.Text == "")
            {
                PhoneBox.Text = "Введите номер телефона";
                PhoneBox.ForeColor = Color.Gray;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Введите пароль")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.Black;
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Введите пароль";
                PasswordBox.ForeColor = Color.Gray;
            }
        }

        public Boolean isUsersExists() // Проверка на повторного пользователя
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Email` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = EmailBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Eror: 514 (Такой пользователь уже существует)");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            ProfileEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }
    }
}
