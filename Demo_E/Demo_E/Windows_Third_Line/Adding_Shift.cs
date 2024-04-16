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
    public partial class Adding_Shift : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();
        private string[] arrayOfRow = new string[4];
        private List<string> listOfRows = new List<string>();
        DataTable table2 = new DataTable();
        string dateOfShift = "2023-12-20";

        public Adding_Shift()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Adding_Shift_Load(object sender, EventArgs e)
        {
            table2.Columns.Add("id");
            table2.Columns.Add("name");
            table2.Columns.Add("sername");
            table2.Columns.Add("groupNumber");
            DBConnection db = new DBConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand($"SELECT id, name, sername, groupNumber FROM users;", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            db.CloseConn();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            DataGridViewRow rightRow = dataGridView1.Rows[e.RowIndex];
            arrayOfRow[0] = $"{rightRow.Cells["id"].Value}";
            arrayOfRow[1] = $"{rightRow.Cells["name"].Value}";
            arrayOfRow[2] = $"{rightRow.Cells["sername"].Value}";
            string op = $"{rightRow.Cells["groupNumber"].Value}";
            switch (op)
            {
                case "1":
                    arrayOfRow[3] = "Администратор";
                    break;
                case "2":
                    arrayOfRow[3] = "Повар";
                    break;
                case "3":
                    arrayOfRow[3] = "Официант";
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
            listOfRows.AddRange(arrayOfRow);
            
            textBox1.Text = $"Вы выбрали {rightRow.Cells["sername"].Value} {rightRow.Cells["name"].Value}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = table2.NewRow();
                row["id"] = arrayOfRow[0];
                row["name"] = arrayOfRow[1];
                row["sername"] = arrayOfRow[2];
                row["groupNumber"] = arrayOfRow[3];
                table2.Rows.Add(row);
                bindingSource2.DataSource = table2;
                dataGridView2.DataSource = bindingSource2;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listOfRows.Count; i++)
            {
                MessageBox.Show(listOfRows[i]);
            }
            try
            {
                DBConnection db = new DBConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    if (dataGridView2.RowCount > 0)
                    {
                        MySqlCommand command = new MySqlCommand($"INSERT INTO `cafe`.`shifts` (`date`, `admin`, `cooker`, `officiant`) VALUES ('{dateOfShift}', '{dataGridView2.Rows[i].Cells[1]}', '{dataGridView2.Rows[i].Cells[2]}', '{dataGridView2.Rows[i].Cells[3]}');", db.getConnection());
                        adapter.SelectCommand = command;
                        db.getConnection().Open();
                        command.ExecuteNonQuery();
                        
                    }
                    
                }
                
                db.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Value);
                dateOfShift = dateTime.ToString("yyyy-MM-dd");
                
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
            
        }
    }
}
