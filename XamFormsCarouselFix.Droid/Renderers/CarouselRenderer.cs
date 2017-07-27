using CarouselView.FormsPlugin.Abstractions;
using CarouselView.FormsPlugin.Android;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamFormsCarouselFix.Controls;
using XamFormsCarouselFix.Droid.Renderers;

[assembly: ExportRenderer(typeof(Carousel), typeof(CarouselRenderer))]
namespace XamFormsCarouselFix.Droid.Renderers
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

            if (e.OldElement != null)
            {
                if (Element != null)
                {
                    Element.SizeChanged -= Element_SizeChanged;
                }
            }

            if (e.NewElement != null)
            {
                Element.SizeChanged += Element_SizeChanged;
            }
        }

        protected override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();

            SetElementLayout();
        }

        private void SetElementLayout()
        {
            if (Control == null)
            {
                Rectangle parentRect = (Element.Parent as Xamarin.Forms.View).Bounds;
                Rectangle carouselRect = new Rectangle(
                    parentRect.X, parentRect.Y - 0,
                    parentRect.Width, parentRect.Height);

                Element.Layout(carouselRect);
            }
        }

        void Element_SizeChanged(object sender, EventArgs e)
        {
            if (Element != null)
            {
                typeof(CarouselViewRenderer).GetMethod("SetNativeView",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance).Invoke(
                    (CarouselViewRenderer)this, null);

                Element.PositionSelected?.Invoke(Element, Element.Position);
            }
        }
    }
}