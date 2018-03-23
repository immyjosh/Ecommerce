using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Windows.Input;
using System.ComponentModel;

namespace Ecommerce
{
    public partial class ProductDetailPage : ContentPage
    {
        private const string Url = "http://thingspeakapi.tk/public/api/customer";
        private HttpClient _client = new HttpClient();

        // public List<ProductModel> Product { get; set; }
        ObservableCollection<ProductColor> Colors;
        public ProductDetailPage(string id)
        {
            InitializeComponent();
            //LoadPalletData();
            // LoadImageData();
            GetApi(id);


        }
       
        public async void GetApi(string id)
        {
            try
            {

                var response =
                    await _client.GetAsync($"{Url}/{id}");
                var movies = await response.Content.ReadAsStringAsync();
                var get= JsonConvert.DeserializeObject<ApiModel>(movies);


                img1.Source = get.images;
                prodImage1.Source = get.images;
                prodImage2.Source = get.image1;
                prodImage3.Source = get.image2;
                prodImage4.Source = get.image3;


                activityIndicator.IsVisible = true;
                await Task.Delay(2000);
                activityIndicator.IsVisible = false;


            }
            catch (Exception e)
            {

                throw;
            }
        }

       

        async void LoadImageData()
        {
            
            this.BindingContext = new 
            {
                Prodimage1 = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyj7araf3p.jpeg?q=70",
                Prodimage2 = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyrfdhpfwz.jpeg?q=70",
                Prodimage3 = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsye8zz86fg.jpeg?q=70",
                Prodimage4 = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyynexfht6.jpeg?q=70",
               
                brownshoe = "https://rukminim1.flixcart.com/image/832/832/jb890nk0/shoe/k/n/5/sokr-brwn-8-deals4you-brown-original-imafymgg9shk6jbq.jpeg?q=70",
                blackshoe = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyj7araf3p.jpeg?q=70",

                

            };
            activityIndicator.IsVisible = true;
            await Task.Delay(2000);
            activityIndicator.IsVisible = false;

        }





        void LoadPalletData()
        {
            Colors = new ObservableCollection<ProductColor>()
            {
                new ProductColor() { colorpallet="http://www.solidbackgrounds.com/images/1920x1080/1920x1080-black-solid-color-background.jpg"},
                new ProductColor() { colorpallet="https://wallpapercave.com/wp/KwEMqSb.jpg"},
                new ProductColor() { colorpallet="https://knobco.com/sites/default/files/styles/product_full/public/legacy_files/files/BPT-181-4X4.jpg?itok=l5xyBeQH"},
                new ProductColor() { colorpallet="https://wallpapercave.com/wp/KwEMqSb.jpg"},
                new ProductColor() { colorpallet="https://knobco.com/sites/default/files/styles/product_full/public/legacy_files/files/BPT-181-4X4.jpg?itok=l5xyBeQH"},
                new ProductColor() { colorpallet="https://wallpapercave.com/wp/KwEMqSb.jpg"}

            };

          //  colorpallet.ItemsSource = Colors;
        }



        void Handle_Tapped(object sender, System.EventArgs e)
        {


            pallet.IsVisible = !pallet.IsVisible;

        }

        async void Get(string id){
            var client = new HttpClient();
            var response =
                await client.GetStringAsync("http://thingspeakapi.tk/public/api/customer/"+id);
            var movies = JsonConvert.DeserializeObject<ApiModel>(response);


            img1.Source = movies.images;

        }

       

        async   void Handle_image1(object id, System.EventArgs e)
        {

            // (BindingContext as ProductDetailViewModel).Tap_Image(id.ToString());

            Get(id.ToString());
            selectimg1.BackgroundColor = Color.Blue;
            selectimg2.BackgroundColor = Color.White;
            selectimg3.BackgroundColor = Color.White;
            selectimg4.BackgroundColor = Color.White;

        }
        async  void Handle_image2(object id, System.EventArgs e)
        {


            var client = new HttpClient();
            var response =
                await client.GetStringAsync("http://thingspeakapi.tk/public/api/customer/"+id);
            var movies = JsonConvert.DeserializeObject<ApiModel>(response);
            id = img1.Source;


            img1.Source = movies.image1;
            selectimg2.BackgroundColor = Color.Blue;
            selectimg1.BackgroundColor = Color.White;
            selectimg3.BackgroundColor = Color.White;
            selectimg4.BackgroundColor = Color.White;

        }
        async  void Handle_image3(object sender, System.EventArgs e)
        {


            var client = new HttpClient();
            var response =
                await client.GetStringAsync("http://thingspeakapi.tk/public/api/customer/22");
            var movies = JsonConvert.DeserializeObject<ApiModel>(response);



            img1.Source = movies.image2;
            selectimg3.BackgroundColor = Color.Blue;
            selectimg1.BackgroundColor = Color.White;
            selectimg2.BackgroundColor = Color.White;
            selectimg4.BackgroundColor = Color.White;


        }
        async void Handle_image4(object sender, System.EventArgs e)
        {
            var client = new HttpClient();
            var response =
                await client.GetStringAsync("http://thingspeakapi.tk/public/api/customer/22");
            var movies = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiModel>(response);



            img1.Source = movies.image3;
            selectimg4.BackgroundColor = Color.Blue;
            selectimg1.BackgroundColor = Color.White;
            selectimg2.BackgroundColor = Color.White;
            selectimg3.BackgroundColor = Color.White;



        }

        void Handle_brownshoe(object sender, System.EventArgs e)
        {
           
            brownshoe.BackgroundColor = Color.Blue;
            blackshoe.BackgroundColor = Color.White;
            Application.Current.MainPage = new ProductBrown();


        }

        void Handle_blackshoe(object sender, System.EventArgs e)
        {
            blackshoe.BackgroundColor = Color.Blue;
            brownshoe.BackgroundColor = Color.White;

        }
        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            // Handle the pan
        }


    }
}
