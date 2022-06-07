namespace Capacitor_Bank_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled) timer1.Stop();
            else timer1.Start();
            motorOff.Visible = motorOff.Visible ? false : true;
            motorOn1.Visible = motorOn1.Visible ? false : false;
            motorOn2.Visible = motorOn2.Visible ? false : false;
            motorOn3.Visible = motorOn3.Visible ? false : false;
            motorOn4.Visible = motorOn4.Visible ? false : false;
            motorOn5.Visible = motorOn5.Visible ? false : false;
            motorOn6.Visible = motorOn6.Visible ? false : false;
            motorOn7.Visible = motorOn7.Visible ? false : false;
            motorOn8.Visible = motorOn8.Visible ? false : false;
        }

        int i = 1;
        int speed = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
                switch (i)
                {
                    case 1:
                        motorOn1.Visible = true;
                        motorOn2.Visible = false;
                        motorOn3.Visible = false;
                        motorOn4.Visible = false;
                        motorOn5.Visible = false;
                        motorOn6.Visible = false;
                        motorOn7.Visible = false;
                        motorOn8.Visible = false;
                        break;
                    case 2:
                        motorOn1.Visible = false;
                        motorOn2.Visible = true;
                        motorOn3.Visible = false;
                        motorOn4.Visible = false;
                        motorOn5.Visible = false;
                        motorOn6.Visible = false;
                        motorOn7.Visible = false;
                        motorOn8.Visible = false;
                        break;
                    case 3:
                        motorOn1.Visible = false;
                        motorOn2.Visible = false;
                        motorOn3.Visible = true;
                        motorOn4.Visible = false;
                        motorOn5.Visible = false;
                        motorOn6.Visible = false;
                        motorOn7.Visible = false;
                        motorOn8.Visible = false;
                        break;
                    case 4:
                        motorOn1.Visible = false;
                        motorOn2.Visible = false;
                        motorOn3.Visible = false;
                        motorOn4.Visible = true;
                        motorOn5.Visible = false;
                        motorOn6.Visible = false;
                        motorOn7.Visible = false;
                        motorOn8.Visible = false;
                        break;
                    case 5:
                        motorOn1.Visible = false;
                        motorOn2.Visible = false;
                        motorOn3.Visible = false;
                        motorOn4.Visible = false;
                        motorOn5.Visible = true;
                        motorOn6.Visible = false;
                        motorOn7.Visible = false;
                        motorOn8.Visible = false;
                        break;
                    case 6:
                        motorOn1.Visible = false;
                        motorOn2.Visible = false;
                        motorOn3.Visible = false;
                        motorOn4.Visible = false;
                        motorOn5.Visible = false;
                        motorOn6.Visible = true;
                        motorOn7.Visible = false;
                        motorOn8.Visible = false;
                        break;
                    case 7:
                        motorOn1.Visible = false;
                        motorOn2.Visible = false;
                        motorOn3.Visible = false;
                        motorOn4.Visible = false;
                        motorOn5.Visible = false;
                        motorOn6.Visible = false;
                        motorOn7.Visible = true;
                        motorOn8.Visible = false;
                        break;
                    case 8:
                        motorOn1.Visible = false;
                        motorOn2.Visible = false;
                        motorOn3.Visible = false;
                        motorOn4.Visible = false;
                        motorOn5.Visible = false;
                        motorOn6.Visible = false;
                        motorOn7.Visible = false;
                        motorOn8.Visible = true;
                        break;
            }
            i++;
            if (i == 9) i = 0;
        }
    }
}