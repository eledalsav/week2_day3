using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3
{
    class Person
    {
        public string FirstName{get;set; }
        public string LastName { get; set; }

        protected int Age { get; set; }//visibile solo dalle classi derivate

        public int MyProperty { get; set; }


        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public Person()
        {

        }

        public Person(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }

        public void GetFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public virtual void PrintInfo()//VIRTUAL dice che la classe der può fare override
            //si può fare override anche se in mezzo c'è una classe che non lo fa
        {
            Console.WriteLine(FirstName + " " + LastName + " " + Age);
        }
    }
}
