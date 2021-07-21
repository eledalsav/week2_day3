using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3_es2
{
    class Defender:SocPlayer
    {
        public int Recuperi { get; set; }

        public Defender(string firstname, string lastname, int age, int number, EnumRole role, int recuperi)
            :base(firstname,lastname,age,number, role)
        {
            Recuperi = recuperi;
        }
    }
}
