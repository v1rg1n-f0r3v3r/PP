using PP.ViewModel;
using System.Windows.Controls;

namespace PP
{
    public partial class CollectionsView : UserControl
    {
        public CollectionsView()
        {
            InitializeComponent();
        }

    private void LoadMoreCameras(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer sb = e.OriginalSource as ScrollViewer;
            var verticalOffSet = sb.VerticalOffset;
            var maxVerticalOfSet = sb.ScrollableHeight;
            if (verticalOffSet == maxVerticalOfSet)
            {
                var collectionController = (CollectionsController)DataContext;
                collectionController.LoadMoreCommand.Execute(null);
            }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.DataContext = new CollectionsController(new PersonCollection(), new PersonCollectionColumns());
        }
    }
}
