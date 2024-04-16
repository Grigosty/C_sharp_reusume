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
    public partial class Shift : Form
    {
        private DateTime dateToday = DateTime.Today;
        
        private BindingSource bindingSource1 = new BindingSource();
        public Shift()
        {
            InitializeComponent();
        }

        private void Shift_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand($"SELECT admin,cooker,officiant as off FROM shifts WHERE date = '{dateToday.ToString("yyyy-MM-dd")}';", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            db.CloseConn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            all_Shifts all_shifts = new all_Shifts();
            all_shifts.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adding_Shift adding_Shift = new Adding_Shift();
            adding_Shift.ShowDialog();
        }
    }
}
