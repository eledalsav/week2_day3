using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3_es2
{
    class MidFIelder:SocPlayer
    {
        public int Assist { get; set; }

        public MidFIelder(string firstname, string lastname, int age, int number, EnumRole role, int assist)
            : base(firstname, lastname, age, number, role)
        {
            Assist = assist;
        }
    }
}
