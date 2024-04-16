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
    public partial class all_Shifts : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public all_Shifts()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void all_Shifts_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand($"SELECT date, admin, cooker, officiant FROM shifts ORDER BY date;", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            //MessageBox.Show(table.Columns[0].ColumnName);
            for(int i = 1; i < table.Rows.Count; i++)
            {
                try
                {
                    var cell = table.Rows[i-1][0];
                    var lastDate = table.Rows[i][0];
                    if(cell.ToString()==lastDate.ToString())
                    {
                        
                        table.Rows[i][0] = DBNull.Value;
                    }
                    //MessageBox.Show(lastDate);
                }
                catch
                {
                    break;
                }
                
                
            }
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            db.CloseConn();
            this.Close();
        }
    }
}
