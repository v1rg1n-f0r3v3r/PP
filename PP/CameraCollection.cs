using PP.ViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PP
{
    public class CameraCollection: ICollection
    {
        int count = 0;
        public CameraCollection()
        {
            count = 50;
        }

        List<object> cameras = new List<object>();
        public List<object> GetCollection()
        {
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
            for (int i = 1; i < count; i++)
            {
                Model.Camera camera = new Model.Camera();
                camera.Name = "Камера " + i;
                cameras.Add(camera);
            }
            return cameras;
        }
    }
}
