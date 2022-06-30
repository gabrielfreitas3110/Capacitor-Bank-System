using System.Diagnostics;
using System.Data.SqlClient;
using Font = iTextSharp.text.Font;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Capacitor_Bank_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HJ62HDV; integrated security=SSPI; initial catalog=db_industria");
        SqlCommand command = new SqlCommand();
        decimal potAtivaTotal = 0;
        decimal potAparenteTotal = 0;
        decimal potReativaTotal = 0;
        decimal fp = 0;
        decimal capacitanciaMax = 0;
        decimal reatCapMax = 0;
        decimal fpDesejado = 0; 
        decimal pAparenteNova = 0;
        private void btnDisable_Click(object sender, EventArgs e)
        {
                if (btn_enable.Enabled)
                {
                    btn_enable.BackColor = SystemColors.ActiveCaption;
                    btn_disable.BackColor = SystemColors.ControlLight;
                }
                else
                {
                    btn_enable.BackColor = SystemColors.ControlLight;
                    btn_disable.BackColor = SystemColors.ActiveCaption;
                }
                btn_disable.Enabled = false;
            btn_enable.Enabled = true;
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (btn_enable.Enabled) { 
                btn_enable.BackColor = SystemColors.ActiveCaption;
                btn_disable.BackColor = SystemColors.Window;
            }
            else
            {
                btn_enable.BackColor = SystemColors.Window;
                btn_disable.BackColor = SystemColors.ActiveCaption;
            }
            btn_disable.Enabled = true;
            btn_enable.Enabled = false;
        }

        private void motor_on_1_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(1, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 1;
                frmMotor1.ShowDialog();
            }
        }
        private void motor_on_2_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(2, false);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(3, false);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(4, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 4;
                frmMotor1.ShowDialog();
            }
        }
        private void motor_on_5_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(5, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 5;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_6_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(6, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 6;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_7_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(7, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 7;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_8_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(8, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 8;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_9_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(9, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 9;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_10_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(10, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 10;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_11_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(11, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 11;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_12_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(12, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 12;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_13_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(13, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 13;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_14_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(14, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 14;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_15_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(15, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 15;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_16_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(16, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 16;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_17_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(17, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 17;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_18_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(18, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 18;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_19_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(19, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 19;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_20_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(20, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 20;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_21_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(21, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 21;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_22_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(22, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 22;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_23_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(23, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 23;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_on_24_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(24, false);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 24;
                frmMotor1.ShowDialog();
            }
        }

        private void motor_off_1_Click(object sender, EventArgs e)
        {
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(1, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(2, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(3, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(4, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(5, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(6, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(7, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(8, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(9, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(10, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(11, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(12, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(13, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(14, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(15, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(16, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(17, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(18, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(19, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(20, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(21, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(22, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(23, true);
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
            if (!btn_disable.Enabled)
            {
                liga_desliga_motor(24, true);
            }
            else
            {
                FrmMotor1 frmMotor1 = new FrmMotor1();
                frmMotor1.motorId = 24;
                frmMotor1.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Motor> motors = getAllDataMotors();
            for (int i = 0; i < motors.Count; i++)
            {
                liga_desliga_motor(motors[i].id, motors[i].status);
            }
            calculateAllData();
        }

        private List<Motor> getAllDataMotors()
        {
            List<Motor> motors = new List<Motor>();
            con.Open();
            string sql = string.Format("Select * from tb_motores");
            command.CommandText = sql;
            command.Connection = con;
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Motor m = new Motor();
                    m.id = Convert.ToInt32(reader["id"]);
                    m.localizacao = reader["localizacao"].ToString();
                    m.tensao = Convert.ToInt32(reader["tensao"]);
                    m.potenciaCv = Convert.ToInt32(reader["p_cv"]);
                    m.nRend = Convert.ToDecimal(reader["nRend"]);
                    m.pAtiva = Convert.ToDecimal(reader["p_ativa"]);
                    m.fp = Convert.ToDecimal(reader["fp"]);
                    m.pAparente = Convert.ToDecimal(reader["p_aparente"]);
                    m.pReativa = Convert.ToDecimal(reader["p_reativa"]);
                    m.status = Convert.ToBoolean(reader["status"]);
                    motors.Add(m);
                }
            }
            catch (Exception ex) { }
            finally { con.Close(); }
            return motors;
        }

        private void liga_desliga_motor(int id, bool status)
        {
            updateStatusMotor(id, status);
            switch (id)
            {
                case 1:
                    motor_on_1.Visible = status;
                    motor_off_1.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 2:
                    motor_on_2.Visible = status;
                    motor_off_2.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 3:
                    motor_on_3.Visible = status;
                    motor_off_3.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 4:
                    motor_on_4.Visible = status;
                    motor_off_4.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 5:
                    motor_on_5.Visible = status;
                    motor_off_5.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 6:
                    motor_on_6.Visible = status;
                    motor_off_6.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 7:
                    motor_on_7.Visible = status;
                    motor_off_7.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 8:
                    motor_on_8.Visible = status;
                    motor_off_8.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 9:
                    motor_on_9.Visible = status;
                    motor_off_9.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 10:
                    motor_on_10.Visible = status;
                    motor_off_10.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 11:
                    motor_on_11.Visible = status;
                    motor_off_11.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 12:
                    motor_on_12.Visible = status;
                    motor_off_12.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 13:
                    motor_on_13.Visible = status;
                    motor_off_13.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 14:
                    motor_on_14.Visible = status;
                    motor_off_14.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 15:
                    motor_on_15.Visible = status;
                    motor_off_15.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 16:
                    motor_on_16.Visible = status;
                    motor_off_16.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 17:
                    motor_on_17.Visible = status;
                    motor_off_17.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 18:
                    motor_on_18.Visible = status;
                    motor_off_18.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 19:
                    motor_on_19.Visible = status;
                    motor_off_19.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 20:
                    motor_on_20.Visible = status;
                    motor_off_20.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 21:
                    motor_on_21.Visible = status;
                    motor_off_21.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 22:
                    motor_on_22.Visible = status;
                    motor_off_22.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 23:
                    motor_on_23.Visible = status;
                    motor_off_23.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
                case 24:
                    motor_on_24.Visible = status;
                    motor_off_24.Visible = !status;
                    updateStatusMotor(id, status);
                    break;
            }
            calculateAllData();
        }

        
        private void updateStatusMotor(int id, bool status)
        {
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

        private void capacitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmCapacitor frmCapacitor= new FrmCapacitor();
            frmCapacitor.ShowDialog();
        }

        private void relatórioDeMotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Globais.path + @"\Relatorio_Motores.pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }
            FileStream arq = new FileStream(path, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, arq);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.pathImages + @"\images\IFG-Logo.png");
            logo.ScaleToFit(250f, 380f);
            logo.Alignment = Element.ALIGN_CENTER;
            logo.SetAbsolutePosition(20, 700f);

            PdfPTable tabela = new PdfPTable(9);
            tabela.DefaultCell.FixedHeight = 45;
            tabela.TotalWidth = 550f;
            tabela.LockedWidth = true;
            tabela.SetWidths(new float[] { 25f, 65f, 70f, 60f, 65f, 60f, 60f, 55f, 60f });

            Paragraph spacing = new Paragraph("\n\n\n\n\n\n");
            Font fontTitle = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 16);
            Font fontColumn = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 12);
            Font fontData = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 12);
            Paragraph titulo = new Paragraph("Tabela de Motores Instalados", fontTitle);
            Paragraph coluna1 = new Paragraph("Id", fontColumn);
            Paragraph coluna2 = new Paragraph("Localização", fontColumn);
            Paragraph coluna3 = new Paragraph("Potência (cv)", fontColumn);
            Paragraph coluna4 = new Paragraph("Rendimento(%)", fontColumn);
            Paragraph coluna5 = new Paragraph("Potência Ativa (Kw)", fontColumn);
            Paragraph coluna6 = new Paragraph("Potência Aparente (KVA)", fontColumn);
            Paragraph coluna7 = new Paragraph("Potência Reativa (KVAr)", fontColumn);
            Paragraph coluna8 = new Paragraph("Fator de Potência", fontColumn);
            Paragraph coluna9 = new Paragraph("Status do Motor", fontColumn);

            PdfPCell celulaTitulo = new PdfPCell(titulo);
            PdfPCell celula1 = new PdfPCell(coluna1);
            PdfPCell celula2 = new PdfPCell(coluna2);
            PdfPCell celula3 = new PdfPCell(coluna3);
            PdfPCell celula4 = new PdfPCell(coluna4);
            PdfPCell celula5 = new PdfPCell(coluna5);
            PdfPCell celula6 = new PdfPCell(coluna6);
            PdfPCell celula7 = new PdfPCell(coluna7);
            PdfPCell celula8 = new PdfPCell(coluna8);
            PdfPCell celula9 = new PdfPCell(coluna9);

            celulaTitulo.HorizontalAlignment = Element.ALIGN_CENTER;
            celulaTitulo.Colspan = 9;
            celula1.HorizontalAlignment = Element.ALIGN_CENTER;
            celula1.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula2.HorizontalAlignment = Element.ALIGN_CENTER;
            celula2.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula3.HorizontalAlignment = Element.ALIGN_CENTER;
            celula3.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula4.HorizontalAlignment = Element.ALIGN_CENTER;
            celula4.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula5.HorizontalAlignment = Element.ALIGN_CENTER;
            celula5.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula6.HorizontalAlignment = Element.ALIGN_CENTER;
            celula6.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula7.HorizontalAlignment = Element.ALIGN_CENTER;
            celula7.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula8.HorizontalAlignment = Element.ALIGN_CENTER;
            celula8.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula9.HorizontalAlignment = Element.ALIGN_CENTER;
            celula9.VerticalAlignment = Element.ALIGN_MIDDLE;

            tabela.AddCell(celulaTitulo);
            tabela.AddCell(celula1);
            tabela.AddCell(celula2);
            tabela.AddCell(celula3);
            tabela.AddCell(celula4);
            tabela.AddCell(celula5);
            tabela.AddCell(celula6);
            tabela.AddCell(celula7);
            tabela.AddCell(celula8);
            tabela.AddCell(celula9);

            List<Motor> motors = getAllDataMotors();
            foreach (Motor motor in motors)
            {
                Paragraph id = new Paragraph(motor.id.ToString(), fontData);
                Paragraph local = new Paragraph(motor.localizacao.ToString(), fontData);
                Paragraph potCv = new Paragraph(motor.potenciaCv.ToString(), fontData);
                Paragraph nRend = new Paragraph(motor.nRend.ToString(), fontData);
                Paragraph pAtiva = new Paragraph(motor.pAtiva.ToString(), fontData);
                Paragraph pAparente = new Paragraph(motor.pAparente.ToString(), fontData);
                Paragraph pReativa = new Paragraph(motor.pReativa.ToString(), fontData);
                Paragraph fp = new Paragraph(motor.fp.ToString(), fontData);
                Paragraph status = new Paragraph((motor.status) ? "Ligado" : "Desligado");
                PdfPCell cell = new PdfPCell(id);
                cell.FixedHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                tabela.AddCell(cell);
                cell = new PdfPCell(local);
                tabela.AddCell(cell);
                cell = new PdfPCell(potCv);
                tabela.AddCell(cell);
                cell = new PdfPCell(nRend);
                tabela.AddCell(cell);
                cell = new PdfPCell(pAtiva);
                tabela.AddCell(cell);
                cell = new PdfPCell(pAparente);
                tabela.AddCell(cell);
                cell = new PdfPCell(pReativa);
                tabela.AddCell(cell);
                cell = new PdfPCell(fp);
                tabela.AddCell(cell);
                cell = new PdfPCell(status);
                tabela.AddCell(cell);
            }
            doc.Open();
            doc.Add(spacing);
            doc.Add(logo);
            doc.Add(tabela);
            doc.Close();

            MessageBox.Show("Relatório gerado com sucesso!", "Info", MessageBoxButtons.OK);
            DialogResult res = MessageBox.Show("Deseja abrir o Relatório?", "Abrir Relatório", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Process.Start(new ProcessStartInfo(path)
                {
                    UseShellExecute = true
                });
            }
        }
        private List<Capacitor> getAllDataCapacitors()
        {
            List<Capacitor> capacitors = new List<Capacitor>();
            con.Open();
            string sql = string.Format("Select * from tb_capacitores");
            command.CommandText = sql;
            command.Connection = con;
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Capacitor c = new Capacitor();
                    c.id = Convert.ToInt32(reader["id"]);
                    c.tipo = reader["tipo"].ToString();
                    c.capacitancia = Convert.ToInt32(reader["capacitancia"]);
                    c.tensao = Convert.ToInt32(reader["tensao"]);
                    capacitors.Add(c);
                }
            }
            catch (Exception ex) { }
            finally { con.Close(); }
            return capacitors;
        }
        private void relatórioDeCapacitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Globais.path + @"\Relatorio_Motores.pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }
            FileStream arq = new FileStream(path, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, arq);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.pathImages + @"\images\IFG-Logo.png");
            logo.ScaleToFit(250f, 380f);
            logo.Alignment = Element.ALIGN_CENTER;
            logo.SetAbsolutePosition(20, 700f);

            PdfPTable tabela = new PdfPTable(4);
            tabela.DefaultCell.FixedHeight = 45;
            tabela.TotalWidth = 550f;
            tabela.LockedWidth = true;
            tabela.SetWidths(new float[] { 25f, 65f, 70f, 60f });

            Paragraph spacing = new Paragraph("\n\n\n\n\n\n");
            Font fontTitle = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 16);
            Font fontColumn = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 12);
            Font fontData = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 12);
            Paragraph titulo = new Paragraph("Tabela de Capacitores Disponíveis", fontTitle);
            Paragraph coluna1 = new Paragraph("Id", fontColumn);
            Paragraph coluna2 = new Paragraph("Tipo", fontColumn);
            Paragraph coluna3 = new Paragraph("Capacitância (uF)", fontColumn);
            Paragraph coluna4 = new Paragraph("Tensão de Operação (V)", fontColumn);

            PdfPCell celulaTitulo = new PdfPCell(titulo);
            PdfPCell celula1 = new PdfPCell(coluna1);
            PdfPCell celula2 = new PdfPCell(coluna2);
            PdfPCell celula3 = new PdfPCell(coluna3);
            PdfPCell celula4 = new PdfPCell(coluna4);

            celulaTitulo.HorizontalAlignment = Element.ALIGN_CENTER;
            celulaTitulo.Colspan = 4;
            celula1.HorizontalAlignment = Element.ALIGN_CENTER;
            celula1.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula2.HorizontalAlignment = Element.ALIGN_CENTER;
            celula2.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula3.HorizontalAlignment = Element.ALIGN_CENTER;
            celula3.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula4.HorizontalAlignment = Element.ALIGN_CENTER;
            celula4.VerticalAlignment = Element.ALIGN_MIDDLE;

            tabela.AddCell(celulaTitulo);
            tabela.AddCell(celula1);
            tabela.AddCell(celula2);
            tabela.AddCell(celula3);
            tabela.AddCell(celula4);

            List<Capacitor> capacitors = getAllDataCapacitors();
            foreach (Capacitor capacitor in capacitors)
            {
                Paragraph id = new Paragraph(capacitor.id.ToString(), fontData);
                Paragraph tipo = new Paragraph(capacitor.tipo.ToString(), fontData);
                Paragraph capacitancia = new Paragraph(capacitor.capacitancia.ToString(), fontData);
                Paragraph tensao = new Paragraph(capacitor.tensao.ToString(), fontData);
                PdfPCell cell = new PdfPCell(id);
                cell.FixedHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                tabela.AddCell(cell);
                cell = new PdfPCell(tipo);
                tabela.AddCell(cell);
                cell = new PdfPCell(capacitancia);
                tabela.AddCell(cell);
                cell = new PdfPCell(tensao);
                tabela.AddCell(cell);
            }
            doc.Open();
            doc.Add(spacing);
            doc.Add(logo);
            doc.Add(tabela);
            doc.Close();

            MessageBox.Show("Relatório gerado com sucesso!", "Info", MessageBoxButtons.OK);
            DialogResult res = MessageBox.Show("Deseja abrir o Relatório?", "Abrir Relatório", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Process.Start(new ProcessStartInfo(path)
                {
                    UseShellExecute = true
                });
            }
        }

        private void motoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                Console.WriteLine(path);
            }
        }

        private void projetarBancoDeCapacitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmCapacitorProjection frmCapacitorProjection = new FrmCapacitorProjection();
            frmCapacitorProjection.ShowDialog();
        }
        List<Motor> motors;
        List<Capacitor> capacitors;
        private void calculateAllData()
        {
            motors = getAllDataMotors();
            capacitors = getAllDataCapacitors();
            potAtivaTotal = 0;
            potAparenteTotal = 0;
            potReativaTotal = 0;
            fp = 0;
            capacitanciaMax = 0;
            reatCapMax = 0;
            pAparenteNova = 0;

            foreach (Motor m in motors)
            {
                if (m.status)
                {
                    potAtivaTotal += m.pAtiva;
                    potAparenteTotal += m.pAparente;
                    potReativaTotal += m.pReativa;
                }
            }
            foreach (Capacitor c in capacitors)
            {
                capacitanciaMax += c.capacitancia;
                decimal aux1 = (decimal) (2 * Math.PI * 60 * Math.Pow(c.tensao, 2));
                reatCapMax += (c.capacitancia * Convert.ToDecimal(Math.Pow(10, -6))) * aux1;
                int x = 0;
            }
            fp = potAparenteTotal == 0 ? 0 : potAtivaTotal / potAparenteTotal;
            lbPotAtiv.Text = String.Format("{0:0.00}", (potAtivaTotal / 1000)) + " kW";
            lbPotAp.Text = String.Format("{0:0.00}", (potAparenteTotal / 1000)) + " kVA";
            lbPotReat.Text = String.Format("{0:0.00}", (potReativaTotal / 1000)) + " kVAr";
            lbFP.Text = String.Format("{0:0.00}", fp);
            if(capacitanciaMax < 1000)
                lbCapacitMax.Text = String.Format("{0:0.00}", capacitanciaMax) + " uF";
            if(capacitanciaMax >= 1000)
                lbCapacitMax.Text = String.Format("{0:0.00}", capacitanciaMax/1000) + " mF";
            lbReatCapMax.Text = String.Format("{0:0.00}", reatCapMax / 1000) + " kVAr";
            double teta = Math.Acos((double)fpDesejado);
            decimal qF = 0;
            decimal qC = 0;
            if (fpDesejado != 0)
                pAparenteNova = potAtivaTotal / fpDesejado;
            qF = pAparenteNova * Convert.ToDecimal(Math.Sin(teta));
            if(qF != 0)
                qC = potReativaTotal - qF;

            capacitors = getAllDataCapacitors();
            decimal aux2 = (decimal)(2 * Math.PI * 60 * Math.Pow(capacitors[0].tensao, 2));
            decimal capNec = qC / aux2;
            lbCapNecessaria.Text = string.Format("{0:0.000}", capNec*1000) + " mF";
            lbPotReatNecessaria.Text = string.Format("{0:0.000}", qC/1000) + " kVAr";
        }

        private void txtFP_Leave(object sender, EventArgs e)
        {
            txtFP.Text = txtFP.Text.Replace(",", ".");
            fpDesejado = decimal.Parse(txtFP.Text) / 100;
            calculateAllData();
        }
    }
}