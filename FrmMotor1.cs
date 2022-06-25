using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capacitor_Bank_System
{
    public partial class FrmMotor1 : Form
    {
        public FrmMotor1()
        {
            InitializeComponent();
        }

        motor m = new motor();
        CultureInfo CI = CultureInfo.InvariantCulture;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            double potSaida = Convert.ToDouble(txtPotCV.Text) * 746.0;
            double teta = Math.Acos(Convert.ToDouble(txtFP.Text));
            m.pAtiva = potSaida / Convert.ToDouble(txtRendimento.Text);
            m.pAparente = m.pAtiva / Math.Cos(teta);
            m.pReativa = m.pAparente * Math.Sin(teta);

            txtPotAtiv.Text = m.pAtiva.ToString("F2", CI);
            txtPotApar.Text = m.pAparente.ToString("F2", CI);
            txtPotReat.Text = m.pReativa.ToString("F2", CI);
        }

        private void txtRendimento_Leave(object sender, EventArgs e)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double potSaida = Convert.ToDouble(txtPotCV.Text) * 746.0;
            m.pAtiva = potSaida / Convert.ToDouble(txtRendimento.Text);
            txtPotAtiv.Text = m.pAtiva.ToString("F2", CI);
        }

        private void txtFP_Leave(object sender, EventArgs e)
        {
            double teta = Math.Acos(Convert.ToDouble(txtFP.Text));
            m.pAparente = m.pAtiva / Math.Cos(teta);
            m.pReativa = m.pAparente * Math.Sin(teta);
            txtPotApar.Text = m.pAparente.ToString("F2", CI);
            txtPotReat.Text = m.pReativa.ToString("F2", CI);
        }
    }
}
