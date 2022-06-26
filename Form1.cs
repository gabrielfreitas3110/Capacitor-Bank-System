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
        Boolean statusM1 = false, statusM2 = false, statusM3 = false, statusM4 = false, statusM5 = false, statusM6 = false, statusM7 = false, statusM8 = false,
            statusM9 = false, statusM10 = false, statusM11 = false, statusM12 = false, statusM13 = false, statusM14 = false, statusM15 = false, statusM16 = false,
            statusM17 = false, statusM18 = false, statusM19 = false, statusM20 = false, statusM21 = false, statusM22 = false, statusM23 = false, statusM24 = false;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btn_play.Enabled = false;
            btn_stop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btn_play.Enabled = true;
            btn_stop.Enabled = false;
            stopAll();
            stopAllMotor();
        }

        private void stopAll()
        {
            statusM1 = false;
            statusM2 = false;
            statusM3 = false;
            statusM4 = false;
            statusM5 = false;
            statusM6 = false;
            statusM7 = false;
            statusM8 = false;
            statusM9 = false;
            statusM10 = false;
            statusM11 = false;
            statusM12 = false;
            statusM13 = false;
            statusM14 = false;
            statusM15 = false;
            statusM16 = false;
            statusM17 = false;
            statusM18 = false;
            statusM19 = false;
            statusM20 = false;
            statusM21 = false;
            statusM22 = false;
            statusM23 = false;
            statusM24 = false;
            liga_desliga_motor(1);
            liga_desliga_motor(2);
            liga_desliga_motor(3);
            liga_desliga_motor(4);
            liga_desliga_motor(5);
            liga_desliga_motor(6);
            liga_desliga_motor(7);
            liga_desliga_motor(8);
            liga_desliga_motor(9);
            liga_desliga_motor(10);
            liga_desliga_motor(11);
            liga_desliga_motor(12);
            liga_desliga_motor(13);
            liga_desliga_motor(14);
            liga_desliga_motor(15);
            liga_desliga_motor(16);
            liga_desliga_motor(17);
            liga_desliga_motor(18);
            liga_desliga_motor(19);
            liga_desliga_motor(20);
            liga_desliga_motor(21);
            liga_desliga_motor(22);
            liga_desliga_motor(23);
            liga_desliga_motor(24);
        }
        private void motor_on_1_Click(object sender, EventArgs e)
        {
            statusM1 = false;
            liga_desliga_motor(1);
        }
        private void motor_on_2_Click(object sender, EventArgs e)
        {
            statusM2 = false;
            liga_desliga_motor(2);
        }
        private void motor_on_3_Click(object sender, EventArgs e)
        {
            statusM3 = false;
            liga_desliga_motor(3);
        }
        private void motor_on_4_Click(object sender, EventArgs e)
        {
            statusM4 = false;
            liga_desliga_motor(4);
        }
        private void motor_on_5_Click(object sender, EventArgs e)
        {
            statusM5 = false;
            liga_desliga_motor(5);
        }

        private void motor_on_6_Click(object sender, EventArgs e)
        {
            statusM6 = false;
            liga_desliga_motor(6);
        }

        private void motor_on_7_Click(object sender, EventArgs e)
        {
            statusM7 = false;
            liga_desliga_motor(7);
        }

        private void motor_on_8_Click(object sender, EventArgs e)
        {
            statusM8 = false;
            liga_desliga_motor(8);
        }

        private void motor_on_9_Click(object sender, EventArgs e)
        {
            statusM9 = false;
            liga_desliga_motor(9);
        }

        private void motor_on_10_Click(object sender, EventArgs e)
        {
            statusM10 = false;
            liga_desliga_motor(10);
        }

        private void motor_on_11_Click(object sender, EventArgs e)
        {
            statusM11 = false;
            liga_desliga_motor(11);
        }

        private void motor_on_12_Click(object sender, EventArgs e)
        {
            statusM12 = false;
            liga_desliga_motor(12);
        }

        private void motor_on_13_Click(object sender, EventArgs e)
        {
            statusM13 = false;
            liga_desliga_motor(13);
        }

        private void motor_on_14_Click(object sender, EventArgs e)
        {
            statusM14 = false;
            liga_desliga_motor(14);
        }

        private void motor_on_15_Click(object sender, EventArgs e)
        {
            statusM15 = false;
            liga_desliga_motor(15);
        }

        private void motor_on_16_Click(object sender, EventArgs e)
        {
            statusM16 = false;
            liga_desliga_motor(16);
        }

        private void motor_on_17_Click(object sender, EventArgs e)
        {
            statusM17 = false;
            liga_desliga_motor(17);
        }

        private void motor_on_18_Click(object sender, EventArgs e)
        {
            statusM18 = false;
            liga_desliga_motor(18);
        }

        private void motor_on_19_Click(object sender, EventArgs e)
        {
            statusM19 = false;
            liga_desliga_motor(19);
        }

        private void motor_on_20_Click(object sender, EventArgs e)
        {
            statusM20 = false;
            liga_desliga_motor(20);
        }

        private void motor_on_21_Click(object sender, EventArgs e)
        {
            statusM21 = false;
            liga_desliga_motor(21);
        }

        private void motor_on_22_Click(object sender, EventArgs e)
        {
            statusM22 = false;
            liga_desliga_motor(22);
        }

        private void motor_on_23_Click(object sender, EventArgs e)
        {
            statusM23 = false;
            liga_desliga_motor(23);
        }

        private void motor_on_24_Click(object sender, EventArgs e)
        {
            statusM24 = false;
            liga_desliga_motor(24);
        }

        private void motor_off_1_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM1 = true;
                liga_desliga_motor(1);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 1;
                frmMotor1.ShowDialog();
            }
        }
        private void motor_off_2_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM2 = true;
                liga_desliga_motor(2);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 2;
                frmMotor1.ShowDialog();
            }
        }
        private void motor_off_3_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM3 = true;
                liga_desliga_motor(3);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 3;
                frmMotor1.ShowDialog();
            }
        }
        private void motor_off_4_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM4 = true;
                liga_desliga_motor(4);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 4;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_5_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM5 = true;
                liga_desliga_motor(5);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 5;
                frmMotor1.ShowDialog();
            }
        }
        private void motor_off_6_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM6 = true;
                liga_desliga_motor(6);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 6;
                frmMotor1.ShowDialog();
            }
        }
        private void motor_off_7_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM7 = true;
                liga_desliga_motor(7);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 7;
                frmMotor1.ShowDialog();
            }
        }
        private void motor_off_8_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM8 = true;
                liga_desliga_motor(8);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 8;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_9_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM9 = true;
                liga_desliga_motor(9);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 9;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_10_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM10 = true;
                liga_desliga_motor(10);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 10;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_11_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM11 = true;
                liga_desliga_motor(11);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 11;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_12_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM12 = true;
                liga_desliga_motor(12);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 12;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_13_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM13 = true;
                liga_desliga_motor(13);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 13;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_14_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM14 = true;
                liga_desliga_motor(14);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 14;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_15_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM15 = true;
                liga_desliga_motor(15);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 15;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_16_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM16 = true;
                liga_desliga_motor(16);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 16;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_17_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM17 = true;
                liga_desliga_motor(17);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 17;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_18_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM18 = true;
                liga_desliga_motor(18);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 18;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_19_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM19 = true;
                liga_desliga_motor(19);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 19;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_20_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM20 = true;
                liga_desliga_motor(20);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 20;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_21_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM21 = true;
                liga_desliga_motor(21);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 21;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_22_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM22 = true;
                liga_desliga_motor(22);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 22;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_23_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM23 = true;
                liga_desliga_motor(23);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 23;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_24_Click(object sender, EventArgs e)
        {
            if (!btn_play.Enabled)
            {
                statusM24 = true;
                liga_desliga_motor(24);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 24;
                frmMotor1.ShowDialog();
            }
        }

        private void liga_desliga_motor(int id)
        {
            switch(id)
            {
                case 1:
                    motor_on_1.Visible = statusM1;
                    motor_off_1.Visible = !statusM1;
                    updateStatusMotor(id, statusM1);
                    break;
                case 2:
                    motor_on_2.Visible = statusM2;
                    motor_off_2.Visible = !statusM2;
                    updateStatusMotor(id, statusM2);
                    break;
                case 3:
                    motor_on_3.Visible = statusM3;
                    motor_off_3.Visible = !statusM3;
                    updateStatusMotor(id, statusM3);
                    break;
                case 4:
                    motor_on_4.Visible = statusM4;
                    motor_off_4.Visible = !statusM4;
                    updateStatusMotor(id, statusM4);
                    break;
                case 5:
                    motor_on_5.Visible = statusM5;
                    motor_off_5.Visible = !statusM5;
                    updateStatusMotor(id, statusM5);
                    break;
                case 6:
                    motor_on_6.Visible = statusM6;
                    motor_off_6.Visible = !statusM6;
                    updateStatusMotor(id, statusM6);
                    break;
                case 7:
                    motor_on_7.Visible = statusM7;
                    motor_off_7.Visible = !statusM7;
                    updateStatusMotor(id, statusM7);
                    break;
                case 8:
                    motor_on_8.Visible = statusM8;
                    motor_off_8.Visible = !statusM8;
                    updateStatusMotor(id, statusM8);
                    break;
                case 9:
                    motor_on_9.Visible = statusM9;
                    motor_off_9.Visible = !statusM9;
                    updateStatusMotor(id, statusM9);
                    break;
                case 10:
                    motor_on_10.Visible = statusM10;
                    motor_off_10.Visible = !statusM10;
                    updateStatusMotor(id, statusM10);
                    break;
                case 11:
                    motor_on_11.Visible = statusM11;
                    motor_off_11.Visible = !statusM11;
                    updateStatusMotor(id, statusM11);
                    break;
                case 12:
                    motor_on_12.Visible = statusM12;
                    motor_off_12.Visible = !statusM12;
                    updateStatusMotor(id, statusM12);
                    break;
                case 13:
                    motor_on_13.Visible = statusM13;
                    motor_off_13.Visible = !statusM13;
                    updateStatusMotor(id, statusM13);
                    break;
                case 14:
                    motor_on_14.Visible = statusM14;
                    motor_off_14.Visible = !statusM14;
                    updateStatusMotor(id, statusM14);
                    break;
                case 15:
                    motor_on_15.Visible = statusM15;
                    motor_off_15.Visible = !statusM15;
                    updateStatusMotor(id, statusM15);
                    break;
                case 16:
                    motor_on_16.Visible = statusM16;
                    motor_off_16.Visible = !statusM16;
                    updateStatusMotor(id, statusM16);
                    break;
                case 17:
                    motor_on_17.Visible = statusM17;
                    motor_off_17.Visible = !statusM17;
                    updateStatusMotor(id, statusM17);
                    break;
                case 18:
                    motor_on_18.Visible = statusM18;
                    motor_off_18.Visible = !statusM18;
                    updateStatusMotor(id, statusM18);
                    break;
                case 19:
                    motor_on_19.Visible = statusM19;
                    motor_off_19.Visible = !statusM19;
                    updateStatusMotor(id, statusM19);
                    break;
                case 20:
                    motor_on_20.Visible = statusM20;
                    motor_off_20.Visible = !statusM20;
                    updateStatusMotor(id, statusM20);
                    break;
                case 21:
                    motor_on_21.Visible = statusM21;
                    motor_off_21.Visible = !statusM21;
                    updateStatusMotor(id, statusM21);
                    break;
                case 22:
                    motor_on_22.Visible = statusM22;
                    motor_off_22.Visible = !statusM22;
                    updateStatusMotor(id, statusM22);
                    break;
                case 23:
                    motor_on_23.Visible = statusM23;
                    motor_off_23.Visible = !statusM23;
                    updateStatusMotor(id, statusM23);
                    break;
                case 24:
                    motor_on_24.Visible = statusM24;
                    motor_off_24.Visible = !statusM24;
                    updateStatusMotor(id, statusM24);
                    break;
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
    }
}