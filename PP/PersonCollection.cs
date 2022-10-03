using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PP.Model;

namespace PP
{
    public class PersonCollection: ICollection
    {
        int count = 0;
        public PersonCollection()
        {
            count = 15;
        }

        public List<object> LoadCollection()
        {
            List<object> persons = new List<object>();
            for (int i = 1; i < count; i++)
            {
                Person person = new Person();
                person.Name = "Василий";
                person.SecondName = "Алексеев";
                person.Patronomic = "Аркашевич";
                person.DateBirth = "12.28.200" + i;
                persons.Add(person);
                Thread.Sleep(100);
            }
            return persons;
        }
    }
}
