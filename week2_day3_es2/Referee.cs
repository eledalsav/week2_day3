using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3_es2
{
    class Referee:Athlete
    {
        public int Career { get; set; }

        public Referee(string firstname, string lastname, int age, int career)
            :base(firstname, lastname, age)
        {
            Career = career;
        }
    }
}
