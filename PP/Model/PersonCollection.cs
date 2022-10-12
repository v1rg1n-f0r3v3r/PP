using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PP.Model;

namespace PP
{
    public class PersonCollection: IListReceiver
    {
        int count = 0;
        public PersonCollection()
        {
            count = 1;
        }

        public List<object> LoadCollection()
        {
            List<object> persons = new List<object>();
            for (int i = 1; i < count; i++)
            {
                Person person = new Person();
                person.Name = "Василий";
                person.SurName = "Алексеев";
                person.Patronomic = "Аркашевич";
                person.DateBirth = i.ToString();
                persons.Add(person);
                Thread.Sleep(10);
            }
            return persons;
        }
    }
}
