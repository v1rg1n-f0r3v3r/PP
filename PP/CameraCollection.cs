using PP.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading;
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

        public List<object> GetCollection()
        {
            List<object> cameras = new List<object>();
            for (int i = 1; i < 15; i++)
            {
                Model.Camera camera = new Model.Camera();
                camera.Name = "Камера " + i;
                cameras.Add(camera);
            }
            return cameras;
        }
        public List<object> LoadMore()
        {
            List<object> cameras = new List<object>();
            for (int i = 1; i < count; i++)
            {
                Model.Camera camera = new Model.Camera();
                camera.Name = "Камера " + i;
                cameras.Add(camera);
                Thread.Sleep(0);
            }
            return cameras;
        }
    }
}
