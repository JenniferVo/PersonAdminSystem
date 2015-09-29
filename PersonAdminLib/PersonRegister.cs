using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAdminLib
{
    public class PersonRegister
    {
        private List<Person> personList;
       // private Persons

        public PersonRegister()
        {
           this.personList = new List<Person>();
        }

        public Person this[int index]
        {
            get { return personList[index]; }
            set { personList.Add(value); }
        }
    }
}
