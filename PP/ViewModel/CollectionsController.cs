using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PP.Model;

namespace PP.ViewModel
{
    public class CollectionsController : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public CollectionsController()
        {
            Camera = new ObservableCollection<Camera>(Collection.GetCam());
        }

        public ObservableCollection<Model.Camera> Camera { get; set; }
    }
}
