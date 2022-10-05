using PP.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace PP
{
    public partial class CollectionsView : UserControl
    {
        public CollectionsView()
        {
            InitializeComponent();
        }

        public Style DataGridStyle
        {
            get { return (Style)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        public static readonly DependencyProperty MyPropertyProperty =
           DependencyProperty.Register("DataGridStyle", typeof(Style), typeof(CollectionsView), new PropertyMetadata(new Style(typeof(DataGrid))));



        private void LoadMoreList(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scrollViewer = e.OriginalSource as ScrollViewer;
            var verticalOffSet = scrollViewer.VerticalOffset;
            var maxVerticalOfSet = scrollViewer.ScrollableHeight;
            if (verticalOffSet == maxVerticalOfSet)
            {
                var collectionController = (CollectionsController)DataContext;
                collectionController.loadMoreCommand.Execute(null);
            }
        }
    }
}
