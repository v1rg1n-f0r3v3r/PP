using System.Collections.ObjectModel;
using System.Threading.Tasks;
using GUISDK;

namespace PP.ViewModel
{
    public class CollectionsController : PropertyChange
    {
        public ICollection getCollection;
        public CollectionsController()
        {
            _collection = new ObservableCollection<object>();
            LoadMoreCommand = new RelayCommand(obj => {Load();});
            if (getCollection == null)
            {
            }
            else
            { Load(); }
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
