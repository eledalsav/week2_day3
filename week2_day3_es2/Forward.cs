using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3_es2
{
    class Forward:SocPlayer
    {
        public int GoalFatti { get; set; }

        public Forward(string firstname, string lastname, int age, int number, EnumRole role,int golfatti)
            : base(firstname, lastname, age, number, role)
        {
            GoalFatti = golfatti;
        }
    }
}
