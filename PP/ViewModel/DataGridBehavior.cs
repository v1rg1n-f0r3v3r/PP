using System.Windows;
using PP.View;
using System.Windows.Controls;
using System.Windows.Interactivity;
using GUISDK;
using System;
using System.Data.Linq;
using System.Windows.Input;

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
            if (verticalOffSet >= maxVerticalOfSet * 0.9)
            {
                DataGridLoadMoreCommand.Execute(null);
            }
        }

        private void DataGridLoaded(object sender, EventArgs e)
        {
            _scrollViewer = AssociatedObject.FindChild<ScrollViewer>();
            _scrollViewer.ScrollChanged += AssociatedObjectScrollChanged;
        }

        public ICommand DataGridLoadMoreCommand
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly DependencyProperty CommandProperty =
           DependencyProperty.Register(nameof(DataGridLoadMoreCommand), typeof(ICommand), typeof(DataGridBehavior), new PropertyMetadata(null));
    }
}
