using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using GUISDK;

namespace PP.ViewModel
{
    public class CameraViewModel: PropertyChange
    {
        CameraCollection cameraCollection = new CameraCollection();
        public CameraViewModel()
        {
            var list = cameraCollection.LoadCollection();
            _loadMoreCommand = new RelayCommand(obj => { Load(); });
            CameraCollections = new ObservableCollection<object>(list);
        }

        private RelayCommand _loadMoreCommand;
        public RelayCommand loadMoreCommand
        {
            get { return _loadMoreCommand; }
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        private async void Load()
        {
            IsLoading = true;
            try
            {
                var list = await Task.Run(() => cameraCollection.LoadCollection());
                CameraCollections.AddRange(list);
            }
            catch { }
            IsLoading = false;
        }

        private ObservableCollection<object> _cameraCollection;
        public ObservableCollection<object> CameraCollections
        {
            get { return _cameraCollection; }
            set { _cameraCollection = value; }
        }
    }
}
