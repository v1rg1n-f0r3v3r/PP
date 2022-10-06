using PP.ViewModel;
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
        }
    }
}
