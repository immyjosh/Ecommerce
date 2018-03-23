using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ecommerce.ProductDetailPage
{
    public class ProductViewModel
    {
        public ICommand SquareRootCommand { get; private set; }
        public ProductViewModel()
        {
            SquareRootCommand = new Command<string>(CalculateSquareRoot);
        }
        void CalculateSquareRoot(string id)
        {
            Get(id);
            selectimg1.BackgroundColor = Color.Blue;
            selectimg2.BackgroundColor = Color.White;
            selectimg3.BackgroundColor = Color.White;
            selectimg4.BackgroundColor = Color.White;
            OnPropertyChanged();
        }
    }
}
