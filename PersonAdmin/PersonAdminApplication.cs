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
            Console.WriteLine("My first c# Program: {0}",
                Assembly.GetExecutingAssembly().GetName().Version);
            Console.WriteLine("{0} {1}", firstPerson.GetFirstName(), firstPerson.GetSurName());
            Console.ReadKey();
        }
    }
}
