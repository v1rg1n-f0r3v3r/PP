using PP.ViewModel;
using PP.Model;
using System.Windows;

namespace PP
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CollectionsViewCamera.DataContext = new CollectionsController(new CameraCollection());
            CollectionsViewUsers.DataContext = new CollectionsController(new PersonCollection());
            CollectionsViewServers.DataContext = new CollectionsController(new ServerCollection());
        }
    }
}
