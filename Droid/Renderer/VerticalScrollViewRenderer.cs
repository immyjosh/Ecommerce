using System;
using System.ComponentModel;
using Android.Content;
using Ecommerce;
using Ecommerce.Droid;
using Ecommerce.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(VerticalScrollView), typeof(VerticalScrollViewRenderer))]
namespace Ecommerce.Droid.Renderer
{
    public class VerticalScrollViewRenderer:ScrollViewRenderer
    {
       
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
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
