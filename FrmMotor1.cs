using System.Globalization;
using System.Data.SqlClient;

namespace Capacitor_Bank_System
{
    public partial class FrmMotor1 : Form
    {
        public FrmMotor1()
        {
            InitializeComponent();
        }

        public int motorId { get; set; }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HJ62HDV; integrated security=SSPI; initial catalog=db_industria");
        SqlCommand command = new SqlCommand();
        motor m = new motor();
        CultureInfo CI = CultureInfo.InvariantCulture;        
        private void btnInserir_Click(object sender, EventArgs e)
        {
            con.Open();
            m.id = Convert.ToInt32(txtId.Text);
            m.localizacao = txtLocal.Text;
            m.tensao = Convert.ToInt32(txtTensao.Text);
            m.potenciaCv = Convert.ToInt32(txtPotCV.Text);
            m.nRend = float.Parse(txtRendimento.Text);
            m.pAtiva = float.Parse(txtPotAtiv.Text);
            m.fp = float.Parse(txtFP.Text);
            m.pAparente = float.Parse(txtPotApar.Text);
            m.pReativa = float.Parse(txtPotReat.Text);
            m.status = false;
            string sql = string.Format("Insert into tb_motores(id, localizacao, tensao, p_cv, nRend, p_ativa, fp, p_aparente, p_reativa, status) " +
                "values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", 
                m.id, m.localizacao, m.tensao, m.potenciaCv, m.nRend, m.pAtiva, m.fp, m.pAparente, m.pReativa, m.status);
            command.CommandText = sql;
            command.Connection = con;
            try
            {
                command.ExecuteNonQuery();
            } catch (Exception ex)
            {
                throw new Exception(ex.ToString()); 
            } finally
            {
                con.Close();
            }

        }   

        private void txtRendimento_Leave(object sender, EventArgs e)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            float potSaida = 0;
            if (txtPotCV.Text.Length > 0)
                potSaida = float.Parse(txtPotCV.Text) * 746;
            if(txtRendimento.Text.Length > 0)
                m.pAtiva = potSaida / (float.Parse(txtRendimento.Text)/100);
            txtPotAtiv.Text = m.pAtiva.ToString("F2", CI);
        }

        private void txtFP_Leave(object sender, EventArgs e)
        {
            Double teta = Math.Acos(Convert.ToDouble(txtFP.Text)/100);
            m.pAparente = (float)(m.pAtiva / Convert.ToDouble(Math.Cos(teta)));
            m.pReativa = (float)(m.pAparente * Convert.ToDouble(Math.Sin(teta)));
            txtPotApar.Text = m.pAparente.ToString("F2", CI);
            txtPotReat.Text = m.pReativa.ToString("F2", CI);
        }

        private void FrmMotor1_Load(object sender, EventArgs e)
        {
            txtId.Text = motorId.ToString();
        }
    }
}
