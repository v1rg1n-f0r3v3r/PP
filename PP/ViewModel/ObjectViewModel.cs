using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PP.Model;

namespace PP.ViewModel
{
    public class ObjectViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObjectViewModel()
        {
            Objectz = new ObservableCollection<Objectz>(GetObj());
        }

        public static IEnumerable<Objectz> GetObj()
        {
            return new Objectz[]
            {
                new Objectz
                {
                    Name = "Камера 1"
                },
                new Objectz
                {
                    Name = "Камера 2"
                }
            };
        }
        public ObservableCollection<Objectz> Objectz { get; set; }
    }
}
