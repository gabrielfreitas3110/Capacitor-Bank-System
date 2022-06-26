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
        public float nRend { get; set; }
        public float pAtiva { get; set; }
        public float fp { get; set; }
        public float pAparente { get; set; }
        public float pReativa { get; set; }
        public bool status { get; set; }

    }
}
