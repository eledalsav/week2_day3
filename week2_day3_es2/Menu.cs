using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3_es2
{
    class Menu
    {
        internal void Start()
        {
            Console.WriteLine("Benvenuto!");
            Console.WriteLine("Crea il tuo primo team.");
            CreaTeam();
        }

        Dictionary<string, Athlete> Team1 = new Dictionary<string, Athlete>();
        ////List<Athlete> Team1 = new List<Athlete>();

        private Athlete AddAthlete(string firstname, string lastname, int age,string tipologia)
        {
            Athlete athlete = new Athlete(firstname, lastname, age);
            Team1.Add(tipologia, athlete);

            return athlete;
        }

        private bool GetByLastName(string lastname)
        {
            foreach(KeyValuePair<string, Athlete> athlete in Team1)
            {
                if ('athlete.Value.LastName == lastname && athlete.Key) ;
            }
        }

        private void CreaTeam()
        {
            Console.WriteLine("Ecco gli atleti disponibili:\n" +
                "D indica un difensore, A un attaccante, C un centrocampista e P un portiere");
            foreach(KeyValuePair<string, Athlete> athlete in Team1)
            {
                Console.WriteLine(athlete.Key, athlete.Value);
            };

            Console.WriteLine("Scegli 4 difensori identificandoli col cognome:");
            string scelta;
            bool check;
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    scelta = Console.ReadLine();
                    check = GetByLastName(scelta);
                } while (check == false);
            }

        }
    }
}
