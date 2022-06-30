using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;
using Font = iTextSharp.text.Font;
using iTextSharp.text.pdf;
using iTextSharp.text;

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
            c.tipo = txtTipo.Text;
            c.capacitancia = Convert.ToInt32(txtCapacitancia.Text);
            c.tensao = Convert.ToInt32(txtTensao.Text);
            string sql = string.Format("Insert into tb_capacitores(tipo, capacitancia, tensao) " +
                "values(@tipo, @capacitancia, @tensao)");
            command.Parameters.Clear();
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
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
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

        private void capacitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void projetarBancoDeCapacitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmCapacitorProjection frmCapacitorProjection = new FrmCapacitorProjection();
            frmCapacitorProjection.ShowDialog();
        }
    }
}
