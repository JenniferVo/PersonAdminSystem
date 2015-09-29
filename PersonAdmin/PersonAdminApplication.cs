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
            //console.writeline("person: {0} {1}",
            //    personregister[0].firstname,
            //    personregister[0].surname);
            PrintPersons(personRegister);
            Console.ReadKey();        
        }

        private static void PrintPersons(PersonRegister personRegister)
        {
            foreach (var p in personRegister.Persons)
                Console.WriteLine("{0} {1}", p.SurName, p.FirstName);
        }
    }
}
