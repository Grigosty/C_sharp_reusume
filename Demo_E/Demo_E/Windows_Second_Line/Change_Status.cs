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

namespace Demo_E.Windows_Second_Line
{
    public partial class Change_Status : Form
    {
        int working_id;
        string status;
        public Change_Status(int id, string lastStatus)
        {
            InitializeComponent();
            working_id = id;
            status = lastStatus;
            
        }

        private void Change_Status_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string value;
            DBConnection db = new DBConnection();
           
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.getConnection().Open();

            if ((radioButton1.Checked == true)&&(status!="работает"))
            {
                value = "работает";
                MySqlCommand command = new MySqlCommand($"UPDATE `cafe`.`users` SET `status_worker` = '{value}' WHERE (`id` = '{working_id+1}');", db.getConnection());
                adapter.SelectCommand = command;
                command.ExecuteNonQuery();
                db.CloseConn();
                
                this.Close();
            }
            else if((radioButton2.Checked == true)&&(status!="уволен"))
            {
                value = "уволен";

                MySqlCommand command = new MySqlCommand($"UPDATE `cafe`.`users` SET `status_worker` = '{value}' WHERE (`id` = '{working_id + 1}');", db.getConnection());
                adapter.SelectCommand = command;
                command.ExecuteNonQuery();
                db.CloseConn();
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Выбранное значение совпадает с изначальным");
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
