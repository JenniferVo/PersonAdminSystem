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
            Person secondPerson = new Person("Max", "Meier");
            Person thirdPerson = new Person("Anna", "Müller");
            Console.WriteLine("My first C# Program: {0}",
                Assembly.GetExecutingAssembly().GetName().Version);
            var personRegister = new PersonRegister();
            personRegister[0] = firstPerson;
            personRegister[1] = secondPerson;
            personRegister[1] = thirdPerson;
            //console.writeline("person: {0} {1}",
            //    personregister[0].firstname,
            //    personregister[0].surname);
            personRegister.Sort(CompareByFirstname);
            PrintPersons(personRegister);            
            //personRegister.Sort(CompareBySurname);
            Console.ReadKey();        
        }

        private static void PrintPersons(PersonRegister personRegister)
        {
            foreach (var p in personRegister.Persons)
                Console.WriteLine("{0} {1}", p.SurName, p.FirstName);
        }

        static int CompareByFirstname(Person p1, Person p2)
        {
            return p1.FirstName.CompareTo(p2.FirstName);
        }

        static int CompareBySurname(Person p1, Person p2)
        {
            return p1.SurName.CompareTo(p2.SurName);
        }
    }
}
