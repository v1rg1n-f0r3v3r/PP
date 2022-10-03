using System.Collections.ObjectModel;
using System.Threading.Tasks;
using GUISDK;

namespace PP.ViewModel
{
    public class CollectionsController : PropertyChange
    {
        private ICollection getCollection;
        private ICollection columncollection;
        public CollectionsController(ICollection _getCollection, ICollection _columncollection)
        {
            columncollection = _columncollection;
            getCollection = _getCollection;
            var list = getCollection.LoadCollection();
            var listColumn = columncollection.LoadCollection();
            _collection = new ObservableCollection<object>(list);
            _collectionColumns = new ObservableCollection<object>(listColumn);
            LoadMoreCommand = new RelayCommand(obj => {Load();});
        }

        public RelayCommand LoadMoreCommand;

        private async void Load()
        {
            try
            {
                var list = await Task.Run(() => getCollection.LoadCollection());
                foreach (var item in list)
                {
                    Collection.Add(item);
                }
            }
            catch { }
        }

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
        private ObservableCollection<object> _collectionColumns;
        public ObservableCollection<object> CollectionColumns
        {
            get { return _collectionColumns; }
            set
            {
                var prop = new PropertyChange();
                _collectionColumns = value;

                prop.OnPropertyChanged();
            }
        }
    }
}
