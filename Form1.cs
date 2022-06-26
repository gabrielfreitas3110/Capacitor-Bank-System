using System.Data.SqlClient;

namespace Capacitor_Bank_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        Boolean statusM1 = false;
        Boolean statusM2 = false;
        Boolean statusM3 = false;
        Boolean statusM4 = false;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btn_play.Enabled = false;
            btn_stop.Enabled = true;
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btn_play.Enabled = true;
            btn_stop.Enabled = false;
            timer1.Enabled = false;
            stopAll();
        }

        private void stopAll()
        {
            statusM1 = false;
            statusM2 = false;
            statusM3 = false;
            statusM4 = false;
            motor_on_1.Visible = statusM1;
            motor_on_2.Visible = statusM2;
            motor_on_3.Visible = statusM3;
            motor_on_4.Visible = statusM4;
            motor_off_1.Visible = !statusM1;
            motor_off_2.Visible = !statusM2;
            motor_off_3.Visible = !statusM3;
            motor_off_4.Visible = !statusM4;
            statusMotor1.Text = statusM1.ToString();
            statusMotor2.Text = statusM2.ToString();
            statusMotor3.Text = statusM3.ToString();
            statusMotor4.Text = statusM4.ToString();
            stopAllMotor();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = i.ToString();
            i++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = timer1.Enabled ? false : true;
        }
        private void motor_on_1_Click(object sender, EventArgs e)
        {
            statusM1 = false;
            liga_desliga_motor();
            updateStatusMotor(1, false);
        }
        private void motor_off_1_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM1 = true;
                liga_desliga_motor();
                updateStatusMotor(1, true);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 1;
                frmMotor1.ShowDialog();
            }
        }

        private void updateStatusMotor(int id, bool status)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HJ62HDV; integrated security=SSPI; initial catalog=db_industria");
            SqlCommand command = new SqlCommand();
            con.Open();
            string sql = string.Format("Update tb_motores Set status = '{0}' Where id = '{1}'", status, id);
            command.CommandText = sql;
            command.Connection = con;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void stopAllMotor()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HJ62HDV; integrated security=SSPI; initial catalog=db_industria");
            SqlCommand command = new SqlCommand();
            con.Open();
            string sql = string.Format("Update tb_motores Set status = '{0}'", false);
            command.CommandText = sql;
            command.Connection = con;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void motor_on_2_Click(object sender, EventArgs e)
        {
            statusM2 = false;
            liga_desliga_motor();
        }
        private void motor_off_2_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM2 = true;
                liga_desliga_motor();
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 2;
                frmMotor1.ShowDialog();
            }
        }
        private void motor_on_3_Click(object sender, EventArgs e)
        {
            statusM3 = false;
            liga_desliga_motor();
        }
        private void motor_off_3_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM3 = true;
                liga_desliga_motor();
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 3;
                frmMotor1.ShowDialog();
            }
        }
        private void motor_on_4_Click(object sender, EventArgs e)
        {
            statusM4 = false;
            liga_desliga_motor();
        }
        private void motor_off_4_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM4 = true;
                liga_desliga_motor();
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 4;
                frmMotor1.ShowDialog();
            }
        }
        private void liga_desliga_motor()
        {
            motor_on_1.Visible = statusM1;
            motor_off_1.Visible = !statusM1;
            statusMotor1.Text = statusM1.ToString();

            motor_on_2.Visible = statusM2;
            motor_off_2.Visible = !statusM2;
            statusMotor2.Text = statusM2.ToString();
                 
            motor_on_3.Visible = statusM3;
            motor_off_3.Visible = !statusM3;
            statusMotor3.Text = statusM3.ToString();
                 
            motor_on_4.Visible = statusM4;
            motor_off_4.Visible = !statusM4;
            statusMotor4.Text = statusM4.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}