using Demo_E.Windows_Third_Line;
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
    public partial class Staff : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public Staff()
        {
            
            InitializeComponent();
            
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand($"SELECT id, name, sername, status_worker FROM users;", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            db.CloseConn();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string lastStatus = dataGridView1[(int)e.ColumnIndex, (int)e.RowIndex].Value.ToString();
            int id = (int)e.RowIndex;
            Change_Status cs = new Change_Status(id, lastStatus);
            this.Hide();
            cs.ShowDialog();
            this.Show();
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adding_Staff adding_Staff = new Adding_Staff();
            adding_Staff.ShowDialog();
        }

        private void Staff_VisibleChanged(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand($"SELECT id, name, sername, status_worker FROM users;", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            db.CloseConn();
        }
    }
}
