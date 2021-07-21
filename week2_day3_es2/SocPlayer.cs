using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3_es2
{
    class SocPlayer:Athlete
    {
        public int Number { get; set; }
        public EnumRole Role { get; set; }

        public SocPlayer(string firstname, string lastname, int age, int number, EnumRole role)
            :base(firstname, lastname, age)
        {
            Number = number;
            Role = role;
        }
    }
    enum EnumRole
    {
        Midfieder,
        Forward,
        Goalkeeper,
        Defender
    }
}
