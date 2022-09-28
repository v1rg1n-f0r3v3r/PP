using System.Collections.ObjectModel;

namespace PP.ViewModel
{
    public class CollectionsController : PropertyChange
    {
        public ICollection getCollection;
        public CollectionsController()
        {
            getCollection = new CameraCollection();
            var list = getCollection.GetCollection();
            _collection = new ObservableCollection<object>(list);
        }

        public RelayCommand LoadMoreCamerasCommand
        {
            get
            {
            return loadMoreCamerasCommand ??
                (loadMoreCamerasCommand = new RelayCommand( obj =>
                {
                    var list = getCollection.LoadMore();
                    foreach (object item in list)
                    {
                        Collection.Add(item);
                    }
                }));
            }
        }
        private RelayCommand loadMoreCamerasCommand;

        private ObservableCollection<object> _collection;
        public ObservableCollection<object> Collection
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
