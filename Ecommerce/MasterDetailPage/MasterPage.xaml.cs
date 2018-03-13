using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ecommerce
{
    public partial class MasterPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }
        public MasterPage()
        {
            InitializeComponent();
            MasterDetailList();

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
            this.BindingContext = new
            {
                Image = "http://www.solostream.com/wp-content/uploads/2017/01/E-commerce-web-development.png",
                Footer = "Welcome "
            };
        }

        void MasterDetailList(){
            menuList = new List<MasterPageItem>();

            var page1 = new MasterPageItem() { Title = "Home", Icon = "ic_home.png", TargetType = typeof(HomePage) };
            var page2 = new MasterPageItem() { Title = "Cart", Icon = "ic_home.png", TargetType = typeof(HomePage) };

            // Adding menu items to menuList
            menuList.Add(page1);
            menuList.Add(page2);
           


            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;
        }
        //private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{

        //    var item = (MasterPageItem)e.SelectedItem;
        //    Type page = item.TargetType;
        //    Detail = new NavigationPage((Page)Activator.CreateInstance(page));
        //    IsPresented = false;
        //}


        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var item = (MasterPageItem)e.Item;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
