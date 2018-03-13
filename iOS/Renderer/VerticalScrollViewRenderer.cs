using System;
using Ecommerce;
using Ecommerce.iOS;
using Ecommerce.iOS.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(VerticalScrollView), typeof(VerticalScrollViewRenderer))]
namespace Ecommerce.iOS.Renderer
{
    public class VerticalScrollViewRenderer: ScrollViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

           
            // Don't need these.
            ShowsHorizontalScrollIndicator = false;
            ShowsVerticalScrollIndicator = false;
        }
    }
}
