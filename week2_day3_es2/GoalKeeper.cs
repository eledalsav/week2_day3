using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3_es2
{
    class GoalKeeper:SocPlayer
    {
        static int Number { get; set; }
        public int GoalSub { get; set; }

        public GoalKeeper(string firstname, string lastname, int age, int number, EnumRole role, int goalsub)
            :base(firstname, lastname, age, 1, role)
        {
            GoalSub = goalsub;
        }
    }
}
