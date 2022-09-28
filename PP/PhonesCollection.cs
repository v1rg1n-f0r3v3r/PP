using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace PP
{
    public class PhonesCollection: ICollection
    {
        List<object> phones = new List<object>();
        public List<object> GetCollection()
        {
            for (int i = 1; i < 30; i++)
            {
                Model.Phone camera = new Model.Phone();
                camera.Name = "Телефон " + i;
                camera.Model = "Iphone " + i;
                phones.Add(camera);
            }
            return phones;
        }

        public List<object> LoadMore()
        {
            for (int i = 1; i < 30; i++)
            {
                Model.Phone camera = new Model.Phone();
                camera.Name = "Телефон " + i;
                camera.Model = "Iphone " + i;
                phones.Add(camera);
            }
            return phones;
        }
    }
}
