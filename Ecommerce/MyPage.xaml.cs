using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Ecommerce
{
    public partial class MyPage : ContentPage
    {
        ObservableCollection<ProductColor> Colors;
        public MyPage(String name, string image, string rate)
        {
            InitializeComponent();
            LoadPalletData();
            LoadImageData();
            pallet.IsVisible = false;
            GetDetail(name, image, rate);


        }


        private void GetDetail(String name, string image, string rate)
        {
            img1.Source = image;
            getrate.Text = rate;

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

        void Handle_image1(object sender, System.EventArgs e)
        {


            img1.Source = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyj7araf3p.jpeg?q=70";
            selectimg1.BackgroundColor = Color.Blue;
            selectimg2.BackgroundColor = Color.White;
            selectimg3.BackgroundColor = Color.White;
            selectimg4.BackgroundColor = Color.White;

        }
        void Handle_image2(object sender, System.EventArgs e)
        {


            img1.Source = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyrfdhpfwz.jpeg?q=70";
            selectimg2.BackgroundColor = Color.Blue;
            selectimg1.BackgroundColor = Color.White;
            selectimg3.BackgroundColor = Color.White;
            selectimg4.BackgroundColor = Color.White;

        }
        void Handle_image3(object sender, System.EventArgs e)
        {


            img1.Source = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsye8zz86fg.jpeg?q=70";
            selectimg3.BackgroundColor = Color.Blue;
            selectimg1.BackgroundColor = Color.White;
            selectimg2.BackgroundColor = Color.White;
            selectimg4.BackgroundColor = Color.White;


        }
        void Handle_image4(object sender, System.EventArgs e)
        {
            img1.Source = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyynexfht6.jpeg?q=70";
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
