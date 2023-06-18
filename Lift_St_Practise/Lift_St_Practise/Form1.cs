namespace Lift_St_Practise
{
    public partial class Form1 : Form
    {
        public Point startPoint;
        public Point endPoint;
        public Point lokationOfRightDoor;
        public Point lokationOfLeftDoor;
        public int i = 1;
        public Form1()
        {
            InitializeComponent();
            panel1.BringToFront();
            panel2.BringToFront();
            panel3.BringToFront();
        }

        //первый таймер, отвечает за движение лифта
        //также контролирует таймеры 2 и 3, которые открывают и закрывают двери соответственно
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1;

            if ((startPoint.Y < endPoint.Y) && (panel1.Location.Y < endPoint.Y))//условие на передвижение лифта
            {
                if (panel2.Width < 25)//условие закрытия дверей перед отправкой
                {
                    timer3.Enabled = true;
                }
                else
                {
                    Point point = new Point(panel1.Location.X, panel1.Location.Y + 1);//передвижение вниз
                    panel1.Location = point;
                }
            }
            else if ((endPoint.Y < startPoint.Y) && (panel1.Location.Y > endPoint.Y))
            {

                if (panel2.Width < 25)//условие закрытия дверей перед отправкой
                {
                    timer3.Enabled = true;
                }
                else
                {
                    Point point = new Point(panel1.Location.X, panel1.Location.Y - 1);//передвижение лифта вверх
                    panel1.Location = point;
                }
            }
            else
            {
                timer2.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startPoint = panel1.Location;//передача значений глобальным переменным
            endPoint = button1.Location;//
            timer1.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            startPoint = panel1.Location;
            endPoint = button2.Location;
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            startPoint = panel1.Location;
            endPoint = button3.Location;
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            startPoint = panel1.Location;
            endPoint = button4.Location;
            timer1.Enabled = true;
        }


        private void timer2_Tick(object sender, EventArgs e)//второй таймер, открывает двери, если они закрыты
        {
            timer2.Interval = 15;
            if ((panel2.Width > 10) && (panel3.Width > 10))
            {
                panel2.Width -= 1;
                panel3.Width -= 1;
                lokationOfRightDoor = panel3.Location;
                lokationOfRightDoor.X += 1;
                panel3.Location = lokationOfRightDoor;
            }
            else
            {
                timer2.Enabled = false;
            }
        }


        private void timer3_Tick(object sender, EventArgs e)//третий таймер, закрывает двери если они открыты
        {
            timer3.Interval = 15;
            if ((panel2.Width <= 25) && (panel3.Width <= 25))
            {
                panel2.Width += 1;
                panel3.Width += 1;
                lokationOfRightDoor = panel3.Location;
                lokationOfRightDoor.X -= 1;
                panel3.Location = lokationOfRightDoor;
            }
            else
            {
                timer3.Enabled = false;
            }
        }
    }
}