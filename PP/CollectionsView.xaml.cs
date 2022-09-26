using PP.Model;
using PP.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
                sb.ScrollToVerticalOffset(sb.VerticalOffset-20);
                var collectionController = (CollectionsController)DataContext;
                collectionController.LoadMoreCamerasCommand.Execute(null);
            }
        }
    }
}
