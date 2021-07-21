using System;

namespace week2_day3_es1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creare una classe Veicolo con le seguenti proprietà(brand, modello, codice)
            //e poi le seguenti classi derivate
            //Automobile(con proprietà targa e carburante) e
            //bicicletta(con proprietà Elettrica/ Non Elettrica).

            IPrintable v1 = new Automobile("Fiat","500",123,"vkahds","benzina");
        }
    }
}
