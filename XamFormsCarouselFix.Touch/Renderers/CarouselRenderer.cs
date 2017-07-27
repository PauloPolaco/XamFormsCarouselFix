using CarouselView.FormsPlugin.iOS;
using CarouselView.FormsPlugin.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamFormsCarouselFix.Controls;
using XamFormsCarouselFix.Touch.Renderers;

[assembly: ExportRenderer(typeof(Carousel), typeof(CarouselRenderer))]
namespace XamFormsCarouselFix.Touch.Renderers
{
    /// <summary>
    /// Custom CarouselViewRenderer for CarouselViewControl.
    /// </summary>
    /// <remarks>
    /// Fixes the issue of CarouselViewControl not rendering 
    /// the control's view height correctly on Android during
    /// first load.
    /// </remarks>
    public sealed class CarouselRenderer : CarouselViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CarouselViewControl> e)
        {
            base.OnElementChanged(e);
        }

        public override void MovedToWindow()
        {
            base.MovedToWindow();

            SetElementLayout();
        }

        private void SetElementLayout()
        {
            if (Control == null)
            {
                Element.Layout((Element.Parent as View).Bounds);
            }
        }
    }
}