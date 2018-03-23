using System;
using System.ComponentModel;
using Android.Content;
using Ecommerce.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Ecommerce.ListControl), typeof(ListRenderer))]
namespace Ecommerce.Droid.Renderer
{
    public class ListRenderer:ListViewRenderer
    {
       
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || this.Element == null)
                return;

            if (e.OldElement != null)
                e.OldElement.PropertyChanged -= OnElementPropertyChanged;

            e.NewElement.PropertyChanged += OnElementPropertyChanged;
        }

        protected void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            HorizontalScrollBarEnabled = false;
            VerticalScrollBarEnabled = false;
        }
    }
}
