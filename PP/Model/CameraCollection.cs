using System.Collections.Generic;
using System.Threading;
using PP.Model;

namespace PP
{
    public class CameraCollection: IListReceiver
    {
        int count = 0;
        public CameraCollection()
        {
            count = 20;
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
