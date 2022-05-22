using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BD_Olympiad
{
    public partial class Аuthentication : Form
    {
        public Аuthentication()
        {
            InitializeComponent();
            //this.PasswordBox.AutoSize = false;
            // this.PasswordBox.Size = new Size(this.PasswordBox.Size.Width, 28);

            LoginBox.Text = "Введите Email";
            LoginBox.ForeColor = Color.Gray;
           /* PasswordBox.Text = "Введите пароль";
            PasswordBox.ForeColor = Color.Gray;*/
        }

        private void Аuthentication_Load(object sender, EventArgs e)
        {

        }

        private void Entrance_Click(object sender, EventArgs e)
        {
            String loginUser = LoginBox.Text;
            String passUser = PasswordBox.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Profile` = @uA OR `Email` = @uL AND `Password` = @uP;", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            command.Parameters.Add("@uA", MySqlDbType.Enum).Value = "Администратор";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                if (loginUser == "Admin")
                {
                   MessageBox.Show("Вы зашли под профилем Администратора.");
                }
                Hide();
                MainMenu mainMenu = new MainMenu();
                //mainMenu.MdiParent = mainMenu.ActiveForm;
                mainMenu.ShowDialog();
                this.Close();
            } 
            else if ((LoginBox.Text == "Введите Email") || (PasswordBox.Text == "Введите пароль"))
            { 
                MessageBox.Show("Введите email и пароль");
            }
            else
            {
                MessageBox.Show("Неправильный email или пароль");

                LoginBox.Clear();
                PasswordBox.Clear();

                if (LoginBox.Text == "")
                {
                    LoginBox.Text = "Введите Email";
                    LoginBox.ForeColor = Color.Gray;
                }

               /* if (PasswordBox.Text == "")
                {
                    PasswordBox.Text = "Введите пароль";
                    PasswordBox.ForeColor = Color.Gray;
                }*/
            }
        }

        //Кнопка "Зарегистрироваться"
        private void RegistButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();

            LoginBox.Clear();
            PasswordBox.Clear();

            if (LoginBox.Text == "")
            {
                LoginBox.Text = "Введите Email";
                LoginBox.ForeColor = Color.Gray;
            }

           /*if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Введите пароль";
                PasswordBox.ForeColor = Color.Gray;
            }*/
        }

        //Невидимая подсказка
        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Введите Email")
            {
                LoginBox.Text = "";
                LoginBox.ForeColor = Color.Black;
            }
        }

        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                LoginBox.Text = "Введите Email";
                LoginBox.ForeColor = Color.Gray;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            /*if (PasswordBox.Text == "Введите пароль")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.Black;
            }*/
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            /*if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Введите пароль";
                PasswordBox.ForeColor = Color.Gray;
            }*/
        }
        
        //Показывать пароль
        private void checkBox1_CheckedChanged(object sender, EventArgs e) 
        {
            if (checkBox1.Checked == true)
                PasswordBox.UseSystemPasswordChar = false;
            else
                PasswordBox.UseSystemPasswordChar = true;
        }
    }
}
