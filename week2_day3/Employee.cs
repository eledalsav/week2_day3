using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3
{
    class Employee : Person//significa che impiegato eredita da persona
        //eredita firstname e lastname 
        //posso anche fare ered il costruttore
        //Oss: si può ereditare da un'UNICA classe
    {
        public RolesEnum Role { get; set; }
        public Employee(string firstname, string lastname, RolesEnum role)
            :base(firstname, lastname)//gli passo questi due param e gli assegno role
            //base non serve se il costr è vuoto
        {
            Role = role;
        }

        public new int Myproperty { get; set; }//per nascondere alla classe figlia

        public Employee(string firstname, string lastname, RolesEnum role, int age)
            :base(firstname, lastname, age)
        {
            Role = role;
        }

        public Employee()
        {

        }

        public override void PrintInfo()//significa fornire una propria def ed implementazione
        {
            Console.WriteLine(FirstName + " " + LastName + " " + Age+Role);

            //posso richiamare il metodo della classe base con la keyword base
            //base.PrintInfo();
            //Console.WriteLine(" " + Role);
        }
    }
    public enum RolesEnum
    {
        Technician,
        Manager
    }
}
