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
    public partial class UserControlCameras : UserControl
    {
        public UserControlCameras()
        {
            InitializeComponent();
        }

        private void LoadMoreCameras(object sender, ScrollChangedEventArgs e)
        {
            var verticalOffSet = ScrollViewerCameras.VerticalOffset;
            var maxVerticalOfSet = ScrollViewerCameras.ScrollableHeight;
            if (verticalOffSet == maxVerticalOfSet)
            {
                var collectionController = (CollectionsController)DataContext;
                if (collectionController.LoadMoreCamerasCommand.CanExecute(null))
                { collectionController.LoadMoreCamerasCommand.Execute(null); }
            }
        }
    }
}
