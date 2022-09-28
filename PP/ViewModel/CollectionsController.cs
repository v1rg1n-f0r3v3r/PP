using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace PP.ViewModel
{
    public class CollectionsController : PropertyChange
    {
        public static ICollection getCollection;

        public CollectionsController()
        {
            _collection = new ObservableCollection<object>();
            List<object> list = getCollection.GetCollection();
            foreach (object item in list)
            {
                Collection.Add(item);
            }
        }

        public RelayCommand LoadMoreCamerasCommand
        {
            get
            {
            return loadMoreCamerasCommand ??
                (loadMoreCamerasCommand = new RelayCommand(obj =>
                {
                    List<object> list = getCollection.LoadMore();
                    Collection.Clear();
                    foreach (object item in list)
                    {
                        Collection.Add(item);
                    }
                }));
            }
        }
        private RelayCommand loadMoreCamerasCommand;

        private static ObservableCollection<object> _collection;
        public static ObservableCollection<object> Collection
        {
            get { return _collection; }
            set
            {
                var prop = new PropertyChange();
                _collection = value;

                prop.OnPropertyChanged();
            }
        }
    }
}
