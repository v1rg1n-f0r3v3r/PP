using PP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace PP
{
    public class CameraCollectionColumns : ICollection
    {
        public List<object> LoadCollection()
        {
            List<object> cameras = new List<object>();
            CameraColumn camera = new CameraColumn();
            camera.NameColumn = "Наименование: ";
            cameras.Add(camera);
            return cameras;
        }
    }
}
