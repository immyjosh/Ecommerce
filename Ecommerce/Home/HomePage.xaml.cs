using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;

using Xamarin.Forms;

namespace Ecommerce
{
    public partial class HomePage : ContentPage
    {
        private const string Url = "http://thingspeakapi.tk/public/api/products";
        private HttpClient _client = new HttpClient();
        public HomePage()
        {
            InitializeComponent();
            //listview.ItemsSource = new ObservableCollection<ProductListModel>
            //{
            //    new ProductListModel{Prod_name="Puma Mens Formal Shoe - Black and Blue",Prod_image="https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyj7araf3p.jpeg?q=70",Prod_rate="₹ 799/-"},
            //    new ProductListModel{Prod_name="Puma White Sports Shoe",Prod_image="https://rukminim1.flixcart.com/image/832/832/jave1zk0/shoe/s/g/a/styx-evo-nw-8-puma-puma-white-lapis-blue-original-imafycyhzqrywbpv.jpeg?q=70",Prod_rate="₹ 799/-"},
            //    new ProductListModel{Prod_name="Sparx Casuals For Men",Prod_image="https://rukminim1.flixcart.com/image/832/832/shoe/q/n/f/blackwhite-sx0285g-sparx-8-original-imaeptutzyabf8zz.jpeg?q=70",Prod_rate="₹ 799/-"},
            //    new ProductListModel{Prod_name="Sparx Sneakers For Men",Prod_image="https://rukminim1.flixcart.com/image/832/832/shoe/7/m/t/black-white-sx0202g-sparx-8-original-imaefpzhxhv5jyr7.jpeg?q=70",Prod_rate="₹ 799/-"},
            //    new ProductListModel{Prod_name="Adza Casual Sports",Prod_image="https://rukminim1.flixcart.com/image/832/832/shoe/u/s/y/ax-002-9-adza-royal-blue-wht-original-imaescsfhadjzjpy.jpeg?q=70",Prod_rate="₹ 799/-"},
            //    new ProductListModel{Prod_name="Puma Sneakers",Prod_image="https://rukminim1.flixcart.com/image/832/832/shoe/8/z/g/insignia-blue-dandelion-basket-city-dp-puma-10-original-imaenf7xyfcegj5w.jpeg?q=70",Prod_rate="₹ 799/-"}

            //};
            GetData();
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            listview.IsRefreshing = false;
        }

       
        public async void GetData()
        {
            try
            {
                listview.IsRefreshing = true;
                var response = await _client.GetStringAsync(Url);
                var products = JsonConvert.DeserializeObject<List<ApiModel>>(response);
                listview.ItemsSource = products;

            }
            catch (Exception e)
            {
                throw ;
            }
            finally
            {
                listview.IsRefreshing = false;
            }
        }

        //void Handle_image1(object sender, System.EventArgs e)
        //{

        //    Navigation.PushAsync(new ProductDetailPage());



        //}

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }

        //void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        //{
        //    listview.SelectedItem = null;
        //    var item = e.Item as ProductListModel;

        //    if(item!=null){


        //        Navigation.PushAsync(new MyPage(item.Prod_name,item.Prod_image,item.Prod_rate));  
        //    }

        //}


        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var selectedItem = e.SelectedItem as ApiModel;

            if (selectedItem != null)
            {
                var id = selectedItem.id;
                Navigation.PushAsync(new ProductDetail(id));
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}
