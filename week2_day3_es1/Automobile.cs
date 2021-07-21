using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3_es1
{
    class Automobile:Veicolo
    {
        public string Targa { get; set; }
        public string Carburante { get; set; }

        public Automobile(string brand, string modello, int codice, string targa, string carburante)
            :base(brand,modello,codice)
        {
            Targa = targa;
            Carburante = carburante;
        }

        public override void GetInfo()
        {
            Console.WriteLine(Brand+" "+Modello+" "+Codice+" "+Targa + " " + Carburante);
        }
    }
}
