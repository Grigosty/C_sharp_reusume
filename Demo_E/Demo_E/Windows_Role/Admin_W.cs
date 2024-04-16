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

namespace Demo_E
{
    public partial class Admin_W : Form
    {
        public string name;
        public string sername;
        public Admin_W(string fname, string fsername)
        {
            InitializeComponent();
            this.name = fname;
            this.sername = fsername;
        }

        private void Admin_W_Load(object sender, EventArgs e)
        {
            
            label2.Text = this.name;
            label3.Text = this.sername;

        }

        private void button1_Click(object sender, EventArgs e)//сотрудники
        {
            this.Hide();

            Staff staff = new Staff();
            staff.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)//заказы
        {
            this.Hide();
            Orders order = new Orders();
            order.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)//смены
        {
            this.Hide();
            Shift sh = new Shift();
            sh.ShowDialog();
        }
    }
}
