using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capacitor_Bank_System
{
    internal class motor
    {
        public int id { get; set; }
        public string localizacao { get; set; }
        public int tensao { get; set; }
        public int potenciaCv { get; set; }
        public double nRend { get; set; }
        public double pAtiva { get; set; }
        public double fp { get; set; }
        public double pAparente { get; set; }
        public double pReativa { get; set; }
        public bool status { get; set; }

    }
}
