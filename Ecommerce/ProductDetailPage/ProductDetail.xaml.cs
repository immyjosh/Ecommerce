using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using CarouselView.FormsPlugin.Abstractions;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Ecommerce
{
    public partial class ProductDetail : ContentPage
    {

        private const string Url = "http://thingspeakapi.tk/public/api/product/";
        private HttpClient _client = new HttpClient();

        public ProductDetail(string id)
        {
            InitializeComponent();

            GetData(id);

        }



        #region Get API
        async void GetData(string id)
        {
            
            var response =
                await _client.GetStringAsync(Url + id);
            var get = JsonConvert.DeserializeObject<ApiModel>(response);

            //Get Product Name & Price
            prodname.Text = get.productname;
            price.Text = "₹"+get.price+"/-";

            //Get Carousel Images
            PagedCarouselView.ItemsSource = new List<ProductColor>
            {
                new ProductColor
                {
                    im1=get.image1,
                    CustomSelectedColor=Color.Blue,
                    CustomUnselectedColor=Color.Gray

                },
                new ProductColor
                {
                    im1=get.image2,
                    CustomSelectedColor=Color.Blue,
                    CustomUnselectedColor=Color.Gray
                },
                new ProductColor
                {
                    im1=get.image3,
                    CustomSelectedColor=Color.Blue,
                    CustomUnselectedColor=Color.Gray
                }

            };


            //this.BindingContext = new ProductColor()
            //{
            //    im1 = "https://rukminim1.flixcart.com/image/832/832/shoe/m/p/s/black-as114as115-andrew-scott-9-original-imae5z2cs6caqfcc.jpeg?q=70",
            //    im2="https://rukminim1.flixcart.com/image/832/832/shoe/m/p/s/black-as114as115-andrew-scott-9-original-imae5z2cs6caqfcc.jpeg?q=70",
            //    im3="https://rukminim1.flixcart.com/image/832/832/shoe/m/p/s/black-as114as115-andrew-scott-9-original-imae5z2cs6caqfcc.jpeg?q=70"
            //};


            //carousel.ItemsSource = new ObservableCollection<ApiModel>
            //{
            //    new ApiModel(){image1=get.image1},
            //    new ApiModel(){image2=get.image2},
            //    new ApiModel(){image3=get.image3}
            //};
        }
        #endregion


    }
}
