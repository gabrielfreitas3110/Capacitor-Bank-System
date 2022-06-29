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
        Motor m = new Motor();
        private void btnInserir_Click(object sender, EventArgs e)
        {
            con.Open();
            m.id = Convert.ToInt32(txtId.Text);
            m.localizacao = txtLocal.Text;
            m.tensao = Convert.ToInt32(txtTensao.Text);
            m.potenciaCv = Convert.ToInt32(txtPotCV.Text);
            m.nRend = decimal.Parse(txtRendimento.Text)/100;
            m.pAtiva = decimal.Parse(txtPotAtiv.Text);
            m.fp = decimal.Parse(txtFP.Text)/100;
            m.pAparente = decimal.Parse(txtPotApar.Text);
            m.pReativa = decimal.Parse(txtPotReat.Text);
            m.status = false;
            string sql = string.Format("Insert into tb_motores(id, localizacao, tensao, p_cv, nRend, p_ativa, fp, p_aparente, p_reativa, status) " +
                "values(@id, @local, @tensao, @pCv, @nRend, @pAtiva, @fp, @pAparente, @pReativa, @status)");
            command.Parameters.AddWithValue("@id", m.id);
            command.Parameters.AddWithValue("@local", m.localizacao);
            command.Parameters.AddWithValue("@tensao", m.tensao);
            command.Parameters.AddWithValue("@pCv", m.potenciaCv);
            command.Parameters.AddWithValue("@nRend", m.nRend);
            command.Parameters.AddWithValue("@pAtiva", m.pAtiva);
            command.Parameters.AddWithValue("@fp", m.fp);
            command.Parameters.AddWithValue("@pAparente", m.pAparente);
            command.Parameters.AddWithValue("@pReativa", m.pReativa);
            command.Parameters.AddWithValue("@status", m.status);
            command.CommandText = sql;
            command.Connection = con;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso.");
            } catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar salvar os dados no banco.");
                throw new Exception(ex.ToString());
            } finally
            {
                con.Close();
            }
        }   

        private void txtRendimento_Leave(object sender, EventArgs e)
        {
            decimal potSaida = 0;
            txtRendimento.Text = txtRendimento.Text.Replace(",", ".");
            if (txtPotCV.Text.Length > 0)
                potSaida = decimal.Parse(txtPotCV.Text) * 746;
            if(txtRendimento.Text.Length > 0)
            {
                m.pAtiva = potSaida / (decimal.Parse(txtRendimento.Text) / 10000);
                txtPotAtiv.Text = m.pAtiva.ToString();
            }
        }

        private void txtFP_Leave(object sender, EventArgs e)
        {
            txtFP.Text = txtFP.Text.Replace(",", ".");
            double teta = Math.Acos(double.Parse(txtFP.Text)/100);
            m.pAparente = (m.pAtiva / Convert.ToDecimal(Math.Cos(teta)));
            m.pReativa = (m.pAparente * Convert.ToDecimal(Math.Sin(teta)));
            txtPotApar.Text = m.pAparente.ToString();
            txtPotReat.Text = m.pReativa.ToString();
        }

        private void FrmMotor1_Load(object sender, EventArgs e)
        {
            txtId.Text = motorId.ToString();
            con.Open();
            string sql = string.Format("Select * from tb_motores Where id = '{0}'", motorId);
            command.CommandText = sql;
            command.Connection = con;
            SqlDataReader reader = command.ExecuteReader();
            try 
            {
                if (reader.Read())
                {
                    txtLocal.Text = reader["localizacao"].ToString();
                    txtTensao.Text = reader["tensao"].ToString();
                    txtPotCV.Text = reader["p_cv"].ToString();
                    txtRendimento.Text = reader["nRend"].ToString();
                    txtPotAtiv.Text = reader["p_ativa"].ToString();
                    txtFP.Text = reader["fp"].ToString();
                    txtPotApar.Text = reader["p_aparente"].ToString();
                    txtPotReat.Text = reader["p_reativa"].ToString();
                }
            }
            catch (Exception ex) { } 
            finally { con.Close(); }    
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            con.Open();
            m.id = Convert.ToInt32(txtId.Text);
            m.localizacao = txtLocal.Text;
            m.tensao = Convert.ToInt32(txtTensao.Text);
            m.potenciaCv = Convert.ToInt32(txtPotCV.Text);
            m.nRend = decimal.Parse(txtRendimento.Text)/100;
            m.pAtiva = decimal.Parse(txtPotAtiv.Text);
            m.fp = decimal.Parse(txtFP.Text)/100;
            m.pAparente = decimal.Parse(txtPotApar.Text);
            m.pReativa = decimal.Parse(txtPotReat.Text);
            m.status = false;
            string sql = string.Format("Update tb_motores set localizacao=@local, tensao=@tensao, p_cv=@pCv, nRend=@nRend, p_ativa=@pAtiva, " +
                "fp=@fp, p_aparente=@pAparente, p_reativa=@pReativa Where id=@id");
            command.Parameters.AddWithValue("@local", m.localizacao);
            command.Parameters.AddWithValue("@tensao", m.tensao);
            command.Parameters.AddWithValue("@pCv", m.potenciaCv);
            command.Parameters.AddWithValue("@nRend", m.nRend);
            command.Parameters.AddWithValue("@pAtiva", m.pAtiva);
            command.Parameters.AddWithValue("@fp", m.fp);
            command.Parameters.AddWithValue("@pAparente", m.pAparente);
            command.Parameters.AddWithValue("@pReativa", m.pReativa);
            command.Parameters.AddWithValue("@id", m.id);
            command.CommandText = sql;
            command.Connection = con;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar atualizados os dados no banco.");
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            con.Open();
            m.id = Convert.ToInt32(txtId.Text);
            m.localizacao = txtLocal.Text;
            m.tensao = Convert.ToInt32(txtTensao.Text);
            m.potenciaCv = Convert.ToInt32(txtPotCV.Text);
            m.nRend = decimal.Parse(txtRendimento.Text) / 100;
            m.pAtiva = decimal.Parse(txtPotAtiv.Text);
            m.fp = decimal.Parse(txtFP.Text) / 100;
            m.pAparente = decimal.Parse(txtPotApar.Text);
            m.pReativa = decimal.Parse(txtPotReat.Text);
            m.status = false;
            string sql = string.Format("Delete tb_motores Where id=@id");
            command.Parameters.AddWithValue("@id", m.id);
            command.CommandText = sql;
            command.Connection = con;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Dado apagado com sucesso.");
                this.Visible = false;
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar atualizados os dados no banco.");
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
