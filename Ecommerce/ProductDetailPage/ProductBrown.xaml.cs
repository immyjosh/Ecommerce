using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Ecommerce
{
    public partial class ProductBrown : ContentPage
    {
        ObservableCollection<ProductColor> Colors;
        public ProductBrown()
        {
            InitializeComponent();
            LoadPalletData();
            LoadImageData();
            pallet.IsVisible = true;

        }
        void LoadImageData()
        {
            this.BindingContext = new
            {
                Prodimage1 = "https://rukminim1.flixcart.com/image/832/832/jd3epow0/shoe/h/3/h/0506-7-dls-brown-original-imaf22zghhmhvvpz.jpeg?q=70",
                Prodimage2 = "https://rukminim1.flixcart.com/image/832/832/j4eha4w0/shoe/h/3/h/0506-9-dls-brown-original-imaev99tuvgzaypn.jpeg?q=70",
                Prodimage3 = "https://rukminim1.flixcart.com/image/832/832/jd3epow0/shoe/h/3/h/0506-7-dls-brown-original-imaf22zgxrhezy3w.jpeg?q=70",
                Prodimage4 = "https://rukminim1.flixcart.com/image/832/832/j4fwpzk0/shoe/h/3/h/0506-6-dls-brown-original-imaev99ucbzxgqvf.jpeg?q=70",

                brownshoe = "https://rukminim1.flixcart.com/image/832/832/jb890nk0/shoe/k/n/5/sokr-brwn-8-deals4you-brown-original-imafymgg9shk6jbq.jpeg?q=70",
                blackshoe = "https://rukminim1.flixcart.com/image/832/832/shoe/w/r/y/black-pipf00009-provogue-8-original-imaemzsyj7araf3p.jpeg?q=70",



            };
        }



        void LoadPalletData()
        {
            Colors = new ObservableCollection<ProductColor>()
            {
                new ProductColor() { colorpallet="http://www.solidbackgrounds.com/images/1920x1080/1920x1080-black-solid-color-background.jpg"},
                new ProductColor() { colorpallet="https://i.pinimg.com/originals/34/a1/13/34a1137416f3b698eb4a9c67a1bc877b.jpg"}

            };

            //colorpallet.ItemsSource = Colors;
        }



        void Handle_Tapped(object sender, System.EventArgs e)
        {


            pallet.IsVisible = !pallet.IsVisible;

        }

        void Handle_image1(object sender, System.EventArgs e)
        {


            img1.Source = "https://rukminim1.flixcart.com/image/832/832/jd3epow0/shoe/h/3/h/0506-7-dls-brown-original-imaf22zghhmhvvpz.jpeg?q=70";
            selectimg1.BackgroundColor = Color.Blue;
            selectimg2.BackgroundColor = Color.White;
            selectimg3.BackgroundColor = Color.White;
            selectimg4.BackgroundColor = Color.White;

        }
        void Handle_image2(object sender, System.EventArgs e)
        {


            img1.Source = "https://rukminim1.flixcart.com/image/832/832/j4eha4w0/shoe/h/3/h/0506-9-dls-brown-original-imaev99tuvgzaypn.jpeg?q=70";
            selectimg2.BackgroundColor = Color.Blue;
            selectimg1.BackgroundColor = Color.White;
            selectimg3.BackgroundColor = Color.White;
            selectimg4.BackgroundColor = Color.White;

        }
        void Handle_image3(object sender, System.EventArgs e)
        {


            img1.Source = "https://rukminim1.flixcart.com/image/832/832/jd3epow0/shoe/h/3/h/0506-7-dls-brown-original-imaf22zgxrhezy3w.jpeg?q=70";
            selectimg3.BackgroundColor = Color.Blue;
            selectimg1.BackgroundColor = Color.White;
            selectimg2.BackgroundColor = Color.White;
            selectimg4.BackgroundColor = Color.White;


        }
        void Handle_image4(object sender, System.EventArgs e)
        {
            img1.Source = "https://rukminim1.flixcart.com/image/832/832/j4fwpzk0/shoe/h/3/h/0506-6-dls-brown-original-imaev99ucbzxgqvf.jpeg?q=70";
            selectimg4.BackgroundColor = Color.Blue;
            selectimg1.BackgroundColor = Color.White;
            selectimg2.BackgroundColor = Color.White;
            selectimg3.BackgroundColor = Color.White;



        }

        void Handle_brownshoe(object sender, System.EventArgs e)
        {
            
            brownshoe.BackgroundColor = Color.Blue;
            blackshoe.BackgroundColor = Color.White;

        }

        void Handle_blackshoe(object sender, System.EventArgs e)
        {
            blackshoe.BackgroundColor = Color.Blue;
            brownshoe.BackgroundColor = Color.White;
            App.Current.MainPage = new ProductDetailPage();

        }

    }
}
