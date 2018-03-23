using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Refit;

namespace Ecommerce
{
    public partial class TestPage : ContentPage
    {
        

        public TestPage()
        {
            InitializeComponent();
            GetData();
        }

        public async void GetData()
        {
            try
            {
                HttpClient client = new HttpClient();
                var response = await client.GetStringAsync("http://thingspeakapi.tk/public/api/customers");
                var movies = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ApiModel>>(response);
                postsListView.ItemsSource = movies;

            }
            catch (Exception e)
            {
                throw;
            }
        }

		//async Task CallApi()
        //{
        //    var nsAPI = RestService.For<IMakeUpApi>("http://makeup-api.herokuapp.com");
        //    var sugars = await nsAPI.GetMakeUps(Id);
        //    i.Text = sugars.id;
        //}

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var selectedItem = e.SelectedItem as ApiModel;

            if (selectedItem != null)
            {
                var id = selectedItem.id;
               // Navigation.PushAsync(new ApiPage(id));
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}
