using System;

namespace week2_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Mario", "Rossi");
            Employee e1 = new Employee("Mario", "Roosi", RolesEnum.Manager);
            Person p2 = new Person();
            p2.FirstName = "Marco";
            p2.LastName = "Verdi";

            Employee e2 = new Employee();
            e2.FirstName = "Sara";
            e2.LastName = "Bianchi";//age è protected, non lo posso fare
            e2.Role = RolesEnum.Technician;
            e2.GetFullName();//posso accedere anche ai metodi

            Console.WriteLine("PrintInfo su employee:");
            e2.PrintInfo();

            Console.WriteLine("PrintInfo su person:");
            p1.PrintInfo();


        }
    }
}
