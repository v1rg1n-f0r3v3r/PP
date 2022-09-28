using PP.ViewModel;
using System.Windows;

namespace PP
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel.CollectionsController.getCollection = new CameraCollection();
            CollectionsView.DataContext = new CollectionsController();
        }
    }
}
