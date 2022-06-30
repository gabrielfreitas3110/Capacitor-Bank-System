using System.Data.SqlClient;

namespace Capacitor_Bank_System
{
    public partial class FrmCapacitorProjection : Form
    {
        public FrmCapacitorProjection()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HJ62HDV; integrated security=SSPI; initial catalog=db_industria");
        SqlCommand command = new SqlCommand();
        private void motoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        private void capacitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmCapacitor frmCapacitor = new FrmCapacitor();
            frmCapacitor.ShowDialog();
        }

        private void FrmCapacitorProjection_Load(object sender, EventArgs e)
        {
            List<Motor> motors = getAllDataMotors();
            List<Capacitor> capacitors = getAllDataCapacitors();
            decimal totalPotAtiva = 0;
            decimal totalPotAparente = 0;
            decimal totalPotReativa = 0;
            decimal fp = 0;

            foreach(Motor m in motors)
            {
                totalPotAtiva += m.pAtiva;
                totalPotAparente += m.pAparente;
                totalPotReativa += m.pReativa;
            }
            fp = totalPotAtiva / totalPotAparente;
            lbPotAtiv.Text = totalPotAtiva.ToString() + " Watts";
            lbPotAp.Text = totalPotAparente.ToString() + " Volt-Ampere";
            lbPotReat.Text = totalPotReativa.ToString() + " Volt-Ampere Reativo";
            lbFP.Text = String.Format("{0:0.00}", fp); 

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbPotAtiv_Click(object sender, EventArgs e)
        {

        }

        private void lbFP_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbPotReat_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbPotAp_Click(object sender, EventArgs e)
        {

        }
    }
}
