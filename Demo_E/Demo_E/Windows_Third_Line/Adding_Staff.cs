using Demo_E.Windows_Second_Line;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_E.Windows_Third_Line
{
    public partial class Adding_Staff : Form
    {
        public Adding_Staff()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string name = textBox3.Text;
            string sername = textBox4.Text;
            string op = comboBox1.Text;
            int groupNum = 1;
            switch (op)
            {
                case "Администратор":
                    groupNum = 1;
                    break;

                case "Повар":
                    groupNum = 2;
                    break;

                case "Официант":
                    groupNum = 3;
                    break;

                default:
                    MessageBox.Show("Выберите значение профессии");
                    break;
            }
            try
            {
                DBConnection db = new DBConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand commandChecker = new MySqlCommand($"SELECT login FROM users WHERE login = '{login}'", db.getConnection());
                MySqlCommand command = new MySqlCommand($"INSERT INTO `cafe`.`users` (`login`, `password`, `name`, `sername`, `groupNumber`, `status_worker`) VALUES ('{login}', '{password}', '{name}', '{sername}', '{groupNum}', 'работает');", db.getConnection());
                adapter.SelectCommand = command;
                db.getConnection().Open();
                if (commandChecker.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Такой логин уже есть в системе!");
                }
                else
                {
                    command.ExecuteNonQuery();
                    
                }
                db.CloseConn();
            }
            catch(Exception) 
            { 
                
            }

           
        }

        private void Adding_Staff_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff st = new Staff();
            st.ShowDialog();
        }
    }
}
