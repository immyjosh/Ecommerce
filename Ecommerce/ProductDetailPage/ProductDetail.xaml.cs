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


        public ProductDetail(string id)
        {
            InitializeComponent();



            GetCaro(id);


        }

        //async void GetApi()
        //{
        //    var client = new HttpClient();
        //    var response =
        //        await client.GetStringAsync("http://thingspeakapi.tk/public/api/customer/22");
        //    var get = JsonConvert.DeserializeObject<ApiModel>(response);


        //}

        async   void GetCaro(string id)
        {
            var client = new HttpClient();
            var response =
                await client.GetStringAsync("http://thingspeakapi.tk/public/api/customer/"+id);
            var get = JsonConvert.DeserializeObject<ApiModel>(response);


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


            //Trendings = new ObservableCollection<ProductColor>()
            //{
            //    new ProductColor(){im1 = "https://rukminim1.flixcart.com/image/832/832/shoe/m/p/s/black-as114as115-andrew-scott-9-original-imae5z2cs6caqfcc.jpeg?q=70"},
            //    new ProductColor(){im1 = "https://rukminim1.flixcart.com/image/832/832/shoe/m/p/s/black-as114as115-andrew-scott-9-original-imae5z2cs6caqfcc.jpeg?q=70"},
            //    new ProductColor(){im1 = "https://rukminim1.flixcart.com/image/832/832/shoe/m/p/s/black-as114as115-andrew-scott-9-original-imae5z2cs6caqfcc.jpeg?q=70"}
            //};

            //carousel.ItemsSource = Trendings;

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

        //void LoadTrendingData()
        //{
        //    Trendings = new ObservableCollection<ProductColor>()
        //    {
        //        new ProductColor() {  image1 = "http://www.pictureicon.com/images/categories-icon-png-extended-category-icons.png"},
        //        new ProductColor() {  image1 = "http://www.nowtrendingtv.net/wp-content/uploads/2012/07/ntsunglassesmw.jpg"},

        //    };

        //    carousel.ItemsSource = Trendings;
        //}


        //void GetCaro(){
        //    myCarousel.ItemsSource = new ObservableCollection<View> { 
        //        new Image(){Source="https://rukminim1.flixcart.com/image/832/832/shoe/m/p/s/black-as114as115-andrew-scott-9-original-imae5z2cs6caqfcc.jpeg?q=70",Aspect=Aspect.Fill},
        //        new Image(){Source="https://rukminim1.flixcart.com/image/832/832/shoe/m/p/s/black-as114as115-andrew-scott-7-original-imae5z2c4ufdbsyg.jpeg?q=70",Aspect=Aspect.Fill}
        //    }; 
        //    myCarousel.ItemTemplate = new DataTemplate(typeof(ProductDetail)); //new DataTemplate (typeof(MyView));
        //    myCarousel.Position = 0; //default
        //    myCarousel.InterPageSpacing = 10;
        //    myCarousel.Orientation = CarouselViewOrientation.Horizontal;

        //}

        //public async void GetApi(string id)
        //{
        //    try
        //    {

        //        var client = new System.Net.Http.HttpClient();
        //        var response =
        //            await client.GetStringAsync("http://thingspeakapi.tk/public/api/customer/" + id);
        //        var movies = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ApiModel>>(response);






        //    }
        //    catch (Exception e)
        //    {

        //        throw;
        //    }
        //}


    }
}
