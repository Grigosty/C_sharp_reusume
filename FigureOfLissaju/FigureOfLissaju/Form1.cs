using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureOfLissaju
{
    
    public partial class Form1 : Form
    {
        public static double X = 0;
        public static double Y = 0; 
        public int A = 5;
        public int W = 1;
        public double fi0 = 0;
        
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            
            try
            {
                W = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                W = 1;
            }
            try
            {
                fi0 = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                fi0 = 0;
            }


           
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                timer1.Start();
            }
            else
            {
                timer1.Start();
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            

            Graphics g = pictureBox1.CreateGraphics();
            g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
            g.ScaleTransform(1, -1);
            g.DrawLine(new Pen(Color.Black, 1), (float)(10 *A * Math.Cos(W * X))/* x1 */, (float)(10 *  A * Math.Sin(W * X))/* y1 */, (float)(10 * A * Math.Cos(W * X + 0.5))/* x2 */, (float)(10 * A * Math.Sin(W * X + 0.5))/* y2 */);
            switch (checkedListBox1.SelectedItem)
            {
                case "sin":
                    switch (checkedListBox2.SelectedItem)
                    {
                        case "sin":
                            g.DrawLine(new Pen(Color.Red, 10), (float)(10 * A * Math.Sin(W * Y + fi0))/* x1 */, (float)(10 * A * Math.Sin(W * Y + fi0))/* y1 */, (float)(10 * A * Math.Sin(W * Y + fi0) + 0.5)/* x2 */, (float)(10 * A * Math.Sin(W * Y + fi0) + 0.05)/* y2 */);
                            break;
                        case "cos":
                            g.DrawLine(new Pen(Color.Red, 10), (float)(10 * A * Math.Sin(W * Y + fi0))/* x1 */, (float)(10 * A * Math.Cos(W * Y + fi0))/* y1 */, (float)(10 * A * Math.Sin(W * Y + fi0) + 0.5)/* x2 */, (float)(10 * A * Math.Cos(W * Y + fi0) + 0.05)/* y2 */);
                            break;
                        case "tan":
                            g.DrawLine(new Pen(Color.Red, 10), (float)(10 * A * Math.Sin(W * Y + fi0))/* x1 */, (float)(10 * A * Math.Tan(W * Y + fi0))/* y1 */, (float)(10 * A * Math.Sin(W * Y + fi0) + 0.5)/* x2 */, (float)(10 * A * Math.Tan(W * Y + fi0) + 0.05)/* y2 */);
                            break;
                        default:
                            g.DrawLine(new Pen(Color.Red, 10), (float)(10 * A * Math.Sin(W * Y + fi0))/* x1 */, (float)(10 * A * Math.Sin(W * Y + fi0))/* y1 */, (float)(10 * A * Math.Sin(W * Y + fi0) + 0.5)/* x2 */, (float)(10 * A * Math.Sin(W * Y + fi0) + 0.05)/* y2 */);
                            break;
                    }
                    break;

                case "cos":
                    switch (checkedListBox2.SelectedItem)
                    {
                        case "sin":
                            g.DrawLine(new Pen(Color.Red, 10), (float)(10 * A * Math.Cos(W * Y + fi0))/* x1 */, (float)(10 * A * Math.Sin(W * Y + fi0))/* y1 */, (float)(10 * A * Math.Cos(W * Y + fi0) + 0.5)/* x2 */, (float)(10 * A * Math.Sin(W * Y + fi0) + 0.05)/* y2 */);
                            break;
                        case "cos":
                            g.DrawLine(new Pen(Color.Red, 10), (float)(10 * A * Math.Cos(W * Y + fi0))/* x1 */, (float)(10 * A * Math.Cos(W * Y + fi0))/* y1 */, (float)(10 * A * Math.Cos(W * Y + fi0) + 0.5)/* x2 */, (float)(10 * A * Math.Cos(W * Y + fi0) + 0.05)/* y2 */);
                            break;
                        case "tan":
                            g.DrawLine(new Pen(Color.Red, 10), (float)(10 * A * Math.Cos(W * Y + fi0))/* x1 */, (float)(10 * A * Math.Tan(W * Y + fi0))/* y1 */, (float)(10 * A * Math.Cos(W * Y + fi0) + 0.5)/* x2 */, (float)(10 * A * Math.Tan(W * Y + fi0) + 0.05)/* y2 */);
                            break;
                        default:
                            g.DrawLine(new Pen(Color.Red, 10), (float)(10 * A * Math.Cos(W * Y + fi0))/* x1 */, (float)(10 * A * Math.Cos(W * Y + fi0))/* y1 */, (float)(10 * A * Math.Cos(W * Y + fi0) + 0.5)/* x2 */, (float)(10 * A * Math.Cos(W * Y + fi0) + 0.05)/* y2 */);
                            break;
                    }
                    break;

                case "tan":
                    switch (checkedListBox2.SelectedItem)
                    {
                        case "sin":
                            g.DrawLine(new Pen(Color.Red, 10), (float)(10 * A * Math.Tan(W * Y + fi0))/* x1 */, (float)(10 * A * Math.Sin(W * Y + fi0))/* y1 */, (float)(10 * A * Math.Tan(W * Y + fi0) + 0.5)/* x2 */, (float)(10 * A * Math.Sin(W * Y + fi0) + 0.05)/* y2 */);
                            break;
                        case "cos":
                            g.DrawLine(new Pen(Color.Red, 10), (float)(10 * A * Math.Tan(W * Y + fi0))/* x1 */, (float)(10 * A * Math.Cos(W * Y + fi0))/* y1 */, (float)(10 * A * Math.Tan(W * Y + fi0) + 0.5)/* x2 */, (float)(10 * A * Math.Cos(W * Y + fi0) + 0.05)/* y2 */);
                            break;
                        case "tan":
                            g.DrawLine(new Pen(Color.Red, 10), (float)(10 * A * Math.Tan(W * Y + fi0))/* x1 */, (float)(10 * A * Math.Tan(W * Y + fi0))/* y1 */, (float)(10 * A * Math.Tan(W * Y + fi0) + 0.5)/* x2 */, (float)(10 * A * Math.Tan(W * Y + fi0) + 0.05)/* y2 */);
                            break;
                        default:
                            g.DrawLine(new Pen(Color.Red, 10), (float)(10 * A * Math.Tan(W * Y + fi0))/* x1 */, (float)(10 * A * Math.Tan(W * Y + fi0))/* y1 */, (float)(10 * A * Math.Tan(W * Y + fi0) + 0.5)/* x2 */, (float)(10 * A * Math.Tan(W * Y + fi0) + 0.05)/* y2 */);
                            break;
                    }
                    break;

                default: 
                    break;
            }
          //  g.DrawLine(new Pen(Color.Red, 10), (float)(10 * A * Math.Cos(W * Y + fi0) )/* x1 */, (float)(10 * A * Math.Sin(W * Y + fi0) )/* y1 */, (float)(10 * A * Math.Cos(W * Y + fi0)  + 1)/* x2 */, (float)(10 * A * Math.Sin(W * Y + fi0)  + 1)/* y2 */);
            X += 0.05;
            Y += 0.05;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(SystemColors.ActiveCaption);
        }
    }
}
