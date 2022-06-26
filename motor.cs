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
        public decimal nRend { get; set; }
        public decimal pAtiva { get; set; }
        public decimal fp { get; set; }
        public decimal pAparente { get; set; }
        public decimal pReativa { get; set; }
        public bool status { get; set; }

    }
}
