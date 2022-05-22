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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            string scriptUsers = "SELECT * FROM users;";
            string scriptOrganizer = "SELECT * FROM organizer;";
            string scriptMember = "SELECT * FROM member;";
            string scriptResult = "SELECT * FROM results";
            string scriptOlympiad = "SELECT * FROM olympiad";


            db.openConnection();
            if (SelectGrid.SelectedItem == "Пользователи")
            {
                dataGridView1.ClearSelection();
                MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(scriptUsers, db.getConnection());

                DataTable table = new DataTable();

                mySql_dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else if (SelectGrid.SelectedItem == "Организаторы")
            {
                dataGridView1.ClearSelection();
                MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(scriptOrganizer, db.getConnection());

                DataTable table = new DataTable();

                mySql_dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else if (SelectGrid.SelectedItem == "Участники")
            {
                dataGridView1.ClearSelection();
                MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(scriptMember, db.getConnection());

                DataTable table = new DataTable();

                mySql_dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else if (SelectGrid.SelectedItem == "Олимпиады")
            {
                dataGridView1.ClearSelection();
                MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(scriptOlympiad, db.getConnection());

                DataTable table = new DataTable();

                mySql_dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else if (SelectGrid.SelectedItem == "Результаты")
            {
                dataGridView1.ClearSelection();
                MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(scriptResult, db.getConnection());

                DataTable table = new DataTable();

                mySql_dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {
                dataGridView1.ClearSelection();
                MessageBox.Show("Eror: Select for table");
            }


                db.CloseConnection();



        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            /*DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO @title", db.getConnection());
            

            db.openConnection();

            if (SelectGrid.SelectedItem == "Пользователи")
            {
                command.Parameters.Add("@title", MySqlDbType.Enum).Value = "Users";
                MySqlCommand command = new MySqlCommand("INSERT INTO @title", db.getConnection());
            }
            else if (SelectGrid.SelectedItem == "Организаторы")
            {
                command.Parameters.Add("@title", MySqlDbType.Enum).Value = "Organizer";
                
            }
            else if (SelectGrid.SelectedItem == "Участники")
            {
                command.Parameters.Add("@title", MySqlDbType.Enum).Value = "Member";
               
            }
            else if (SelectGrid.SelectedItem == "Олимпиады")
            {
                command.Parameters.Add("@title", MySqlDbType.Enum).Value = "Olympiad";
                
            }
            else if (SelectGrid.SelectedItem == "Результаты")
            {
                command.Parameters.Add("@title", MySqlDbType.Enum).Value = "Results";
                
            }
            else
            {
                dataGridView1.ClearSelection();
                MessageBox.Show("Eror: Select for table");
            }




            db.CloseConnection();*/



        }
    }
}


