using PP.ViewModel;
using System.Windows;

namespace PP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CollectionsView.DataContext = new CollectionsController();
            //CollectionsView.ListView.ItemTemplate = ;
        }
    }
}
