using System;
using Android.Graphics;
using Xamarin.Forms.Platform.Android;
using Android.Content;
using XFrameRenderer = Xamarin.Forms.Platform.Android.AppCompat.FrameRenderer;
using Xamarin.Forms;
using Ecommerce.Droid.Renderer;

[assembly: ExportRenderer(typeof(Ecommerce.IndicatorItemView), typeof(IndicatorItemViewRenderer))]
namespace Ecommerce.Droid.Renderer
{
    public class IndicatorItemViewRenderer : XFrameRenderer
    {
        

        public override void Draw(Canvas canvas)
        {
            base.Draw(canvas);

            if (Element == null || Element.OutlineColor.A <= 0)
            {
                return;
            }

            using (var paint = new Paint { AntiAlias = true })
            using (var path = new Path())
            using (var direction = Path.Direction.Cw)
            using (var style = Paint.Style.Stroke)
            using (var rect = new RectF(0, 0, canvas.Width, canvas.Height))
            {
                var raduis = Android.App.Application.Context.ToPixels(Element.CornerRadius);
                path.AddRoundRect(rect, raduis, raduis, direction);
                paint.StrokeWidth = Context.Resources.DisplayMetrics.Density * 2;
                paint.SetStyle(style);
                paint.Color = Element.OutlineColor.ToAndroid();
                canvas.DrawPath(path, paint);
            }
        }
    }
}
