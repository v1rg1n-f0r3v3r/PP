using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PP.Model;

namespace PP.ViewModel
{
    public class CollectionsController : PropertyChange
    {
        public CollectionsController()
        {
            Cameras = new ObservableCollection<Camera>(Collection.GetCam());
        }

        public ObservableCollection<Model.Camera> Cameras { get; set; }
    }
}
