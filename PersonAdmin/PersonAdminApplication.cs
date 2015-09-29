using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PersonAdminLib;

namespace PersonAdmin
{
    class PersonAdminApplication
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Hans", "Muster");
            Console.WriteLine("My first C# Program: {0}",
                Assembly.GetExecutingAssembly().GetName().Version);
            var personRegister = new PersonRegister();
            personRegister[0] = firstPerson;
            Console.WriteLine("Person: {0} {1}",
                personRegister[0].FirstName,
                personRegister[0].SurName);
            Console.ReadKey();        
        }

        private static void PrintPersons(PersonRegister personRegister)
        {
            foreach (var p in personRegister.Persons)
                Console.WriteLine("{0} {1}", p.Surname, p.Firstname);
        }
    }
}
