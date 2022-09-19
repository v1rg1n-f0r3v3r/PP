using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace PP.ViewModel
{
    public class ObjectViewModel : DependencyObject
    {
        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(ObjectViewModel), new PropertyMetadata(null));

        public ObjectViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(Model.Objectz.GetObjects());
        }
    }
}
