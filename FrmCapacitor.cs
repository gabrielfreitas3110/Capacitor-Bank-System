using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Capacitor_Bank_System
{
    public partial class FrmCapacitor : Form
    {
        public FrmCapacitor()
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            con.Open();
            Capacitor c = new Capacitor();
            c.id = Convert.ToInt32(txtId.Text);
            c.tipo = txtTipo.Text;
            c.capacitancia = Convert.ToInt32(txtCapacitancia.Text);
            c.tensao = Convert.ToInt32(txtTensao.Text);
            string sql = string.Format("Insert into tb_capacitores(id, tipo, capacitancia, tensao) " +
                "values(@id, @tipo, @capacitancia, @tensao)");
            command.Parameters.AddWithValue("@id", c.id);
            command.Parameters.AddWithValue("@tipo", c.tipo);
            command.Parameters.AddWithValue("@capacitancia", c.capacitancia);
            command.Parameters.AddWithValue("@tensao", c.tensao);
            command.CommandText = sql;
            command.Connection = con;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar salvar os dados no banco.");
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            updateTable();
        }

        private void updateTable()
        {
            List<Capacitor> capacitors = new List<Capacitor>();
            int i = 0;
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
                    c.id = Convert.ToInt32(reader["id"].ToString());
                    c.tipo = reader["tipo"].ToString();
                    c.capacitancia = Convert.ToInt32(reader["capacitancia"].ToString());
                    c.tensao = Convert.ToInt32(reader["tensao"].ToString());
                    capacitors.Add(c);
                }
            }
            catch (Exception ex) { }
            finally { con.Close(); }

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Capacitancia");
            dt.Columns.Add("Tensão");

                if(capacitors != null)
            {
                for (i = 0; i < capacitors.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    row["id"] = capacitors[i].id;
                    row["Tipo"] = capacitors[i].tipo;
                    row["Capacitancia"] = capacitors[i].capacitancia;
                    row["Tensão"] = capacitors[i].tensao;
                    dt.Rows.Add(row);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    int num = dataGridView1.Rows.Add();
                    dataGridView1.Rows[num].Cells[0].Value = dr["id"].ToString();
                    dataGridView1.Rows[num].Cells[1].Value = dr["Tipo"].ToString();
                    dataGridView1.Rows[num].Cells[2].Value = dr["Capacitancia"].ToString();
                    dataGridView1.Rows[num].Cells[3].Value = dr["Tensão"].ToString();
                }
            }
        }

        private void FrmCapacitor_Load(object sender, EventArgs e)
        {
            updateTable();
        }
    }
}
