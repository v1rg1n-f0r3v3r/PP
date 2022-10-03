using PP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP
{
    public class PersonCollectionColumns: ICollection
    {
        public List<object> LoadCollection()
        {
            List<object> persons = new List<object>();
            PersonColumns person = new PersonColumns();
            person.NameColumn = "Имя: ";
            person.SecondNameColumn = "Фамилия: ";
            person.PatronomicColumn = "Отчество: ";
            person.DateBirthColumn = "Дата рождения: ";
            persons.Add(person);
            return persons;
        }
    }
}
