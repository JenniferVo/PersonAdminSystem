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

        public List<Person> Persons {get{return this.personList; } }  

        //delegate void sort            

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
