using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Ecommerce
{
    public class ListControl:ListView
    {
        public static readonly BindableProperty ItemsProperty =
            BindableProperty.Create("Items", typeof(IEnumerable<ProductListModel>), typeof(ListControl), new List<ProductListModel>());

        public IEnumerable<ProductListModel> Items
        {
            get { return (IEnumerable<ProductListModel>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

        public void NotifyItemSelected(object item)
        {
            if (ItemSelected != null)
            {
                ItemSelected(this, new SelectedItemChangedEventArgs(item));
            }
        }
    }
}
