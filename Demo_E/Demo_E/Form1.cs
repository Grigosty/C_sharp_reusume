using Demo_E.Windows_Role;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 DBConnection dbC = new DBConnection();
 textBox3.Text = dbC.authCheck(script).ToString();
string script = $"SELECT login,password FROM cafe.users WHERE login = '{login}' AND password = '{password}'";
 */

namespace Demo_E
{
    public partial class Authorization : Form
    {

        
        

        public Authorization()
        {
            InitializeComponent();
            passBox.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string login = loginBox.Text;
                string password = passBox.Text;
                DBConnection db = new DBConnection();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand($"SELECT groupNumber, login,password, name, sername FROM users WHERE login = '{login}' AND password = '{password}';", db.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                string name = Convert.ToString(table.Rows[0][3]);
                string sername = Convert.ToString(table.Rows[0][4]);

                if (table.Rows.Count > 0 )
                {
                    string op = Convert.ToString(table.Rows[0][0]);
                    switch (op)
                    {
                        case "1":
                            Admin_W aw = new Admin_W(name, sername);
                            db.CloseConn();
                            this.Hide();
                            aw.ShowDialog();
                            break;
                        case "2":
                            Coocer_W cw = new Coocer_W();
                            db.CloseConn();
                            this.Hide();
                            cw.ShowDialog();
                            break;
                        case "3":
                            Of_W of_W = new Of_W();
                            db.CloseConn();
                            this.Hide();
                            of_W.ShowDialog();
                            break;
                        default:
                            MessageBox.Show("Упс, что-то пошло не так, попробуйте еще раз");
                            break;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Некорректные логинй/пароль");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
