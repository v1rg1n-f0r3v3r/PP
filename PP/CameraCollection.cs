using System.Collections.Generic;
using System.Threading;
using PP.Model;
using PP.ViewModel;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace PP
{
    public class CameraCollection: ICollection
    {
        int count = 0;
        public CameraCollection()
        {
            count = 15;
        }

        public List<object> LoadCollection()
        {   
            List<object> cameras = new List<object>();
            for (int i = 1; i < count; i++)
            {
                Camera camera = new  Camera();
                camera.Name = "Камера " + i;
                cameras.Add(camera);
                Thread.Sleep(100);
            }
            return cameras;
        }
    }
}
