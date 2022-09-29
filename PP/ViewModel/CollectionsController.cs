using System.Collections.ObjectModel;
using System.Threading.Tasks;
using GUISDK;

namespace PP.ViewModel
{
    public class CollectionsController : PropertyChange
    {
        private ICollection getCollection;
        public CollectionsController(ICollection _getCollection)
        {
            getCollection = _getCollection;
            var list = getCollection.LoadCollection();
            _collection = new ObservableCollection<object>(list);
            LoadMoreCommand = new RelayCommand(obj => {Load();});
        }

        public RelayCommand LoadMoreCommand;

        private async void Load()
        {
            var list = await Task.Run(() => getCollection.LoadCollection());
            foreach (var item in list)
            {
                Collection.Add(item);
            }
            //Collection.AddRange(list); эта функция у меня не работает,скорее всего какие-то проблемы с версией проекта и GUISDK
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
    }
}
