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
        private int count;

        public IList<Person> Persons {get{return this.personList; } }  
        
        public PersonRegister()
        {
           this.personList = new List<Person>();
        }

        public Person this[int index]
        {
            get { return personList[index]; }
            set { personList.Add(value); }
        }

        public void Sort(Comparison<Person> comp)
        {
            personList.Sort(comp);
        }

        public int AddPerson(Person newPerson)
        {
            personList.Add(newPerson);
            this.count++;
            newPersonAdded?.Invoke(newPerson);
            return this.count;
        }

        delegate void PersonAddedHandler(Person newPerson);

        event PersonAddedHandler newPersonAdded;
    }
}
