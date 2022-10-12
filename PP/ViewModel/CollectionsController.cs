using System.Collections.ObjectModel;
using System.Threading.Tasks;
using GUISDK;

namespace PP.ViewModel
{
    public class CollectionsController : PropertyChange
    {
        readonly IListReceiver interfaceCollection;
        public CollectionsController(IListReceiver _interfaceCollection)
        {
            interfaceCollection = _interfaceCollection;
            var list = interfaceCollection.LoadCollection();
            _collection = new ObservableCollection<object>(list);
            _loadMoreCommand = new RelayCommand(obj => { Load(); });
        }

        private bool _isLoading;
        public bool IsLoading
        { 
            get { return _isLoading; }
            set { _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));}
        }

        private RelayCommand _loadMoreCommand;
        public RelayCommand loadMoreCommand
        {
            get { return _loadMoreCommand; }
        }
        private async void Load()
        {
            IsLoading = true;
            try
            {
                var list = await Task.Run(() => interfaceCollection.LoadCollection());
                Collection.AddRange(list);
            }
            catch { }
            IsLoading = false;
        }

        private ObservableCollection<object> _collection;
        public ObservableCollection<object> Collection
        {
            get { return _collection; }
            set { _collection = value; }
        }
    }
}
