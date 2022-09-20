using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PP
{
    public class Collection
    {
        public static IEnumerable<Model.Camera> GetCam()
        {
            return new Model.Camera[]
            {
                new Model.Camera
                {
                    Name = "Камера 1"
                },
                new Model.Camera
                {
                    Name = "Камера 2"
                }
            };
        }
    }
}
