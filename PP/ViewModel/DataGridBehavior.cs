using System.Windows;
using PP.View;
using System.Windows.Controls;
using System.Windows.Interactivity;
using GUISDK;
using System;
using System.Data.Linq;

namespace PP.ViewModel
{
    public class DataGridBehavior : Behavior<System.Windows.Controls.DataGrid>
    {
        ScrollViewer _scrollViewer;
        protected override void OnAttached()
        {
            AssociatedObject.Loaded += DataGridLoaded;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.Loaded -= DataGridLoaded;
            _scrollViewer.ScrollChanged -= AssociatedObjectScrollChanged;
        }

        private void AssociatedObjectScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            var scrollViewer = e.OriginalSource as ScrollViewer;
            var verticalOffSet = scrollViewer.VerticalOffset;
            var maxVerticalOfSet = scrollViewer.ScrollableHeight;
            if (verticalOffSet == maxVerticalOfSet * 0.9 || verticalOffSet == maxVerticalOfSet)
            {
                var cameraVM = (CameraViewModel)AssociatedObject.DataContext;
                cameraVM.loadMoreCommand.Execute(null);
            }
        }

        private void DataGridLoaded(object sender, EventArgs e)
        {
            _scrollViewer = AssociatedObject.FindChild<ScrollViewer>();
            _scrollViewer.ScrollChanged += AssociatedObjectScrollChanged;
        }
    }
}
