using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAdminLib
{
    public class Person
    {
        public string FirstName { get; set; }
   
        public string SurName { get; set; }

        public Person(string _firstName, string _surname)
        {
            this.FirstName = _firstName;
            this.SurName = _surname;
        }
            
    }
}
