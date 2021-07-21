using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3_es1
{
    class Bicicletta:Veicolo
    {
        public bool Elettrica { get; set; }

        public Bicicletta(string brand, string modello, int codice, bool elettrica)
            :base(brand, modello, codice)
        {
            Elettrica = elettrica;
        }

        public override void GetInfo()
        {
            Console.WriteLine(Elettrica);
        }
    }
}
