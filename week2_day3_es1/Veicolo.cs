using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3_es1
{
    abstract class Veicolo:IPrintable
    {
        public string Brand { get; set; }
        public string Modello { get; set; }
        public int Codice { get; set; }

        public Veicolo(string brand, string modello, int codice)
        {
            Brand = brand;
            Modello = modello;
            Codice = codice;
        }

        //Metodo è ereditato dalle classi der
        public void GetBrand()
        {
            Console.WriteLine(Brand);
        }

        //metod che DEVE essere implementato dalle cl der
        //Nella classe astratta, ho solo fimra non implementazione
        public abstract void GetInfo();

        public string PrintInfo()
        {
           string info=Brand+" "+Modello;
            return info;
        }

        //se uso virtual posso modificare
    }
}
