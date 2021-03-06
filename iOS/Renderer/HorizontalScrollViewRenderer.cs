﻿using System;
using Ecommerce;
using Ecommerce.iOS;
using Ecommerce.iOS.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(HorizontalScrollView), typeof(HorizontalScrollViewRenderer))]
namespace Ecommerce.iOS.Renderer
{
    public class HorizontalScrollViewRenderer : ScrollViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var element = e.NewElement as HorizontalScrollView;
            element?.Render();

            // Don't need these.
            ShowsHorizontalScrollIndicator = false;
        }
    }
}
