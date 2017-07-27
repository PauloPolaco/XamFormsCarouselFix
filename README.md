# XamFormsCarouselFix
Fixes the issue of CarouselViewControl not rendering the control's view height correctly on Android during first load.

BUG

The CarouselViewControl has an issue of not rendering the control's view height on Android during first load. The control's content bleeds into and past the Indicator which is situated at the bottom of the control. The bug only occurs when the control is on the primarily loaded page.  The bug does not occur during second loading of the page or when the control is situated on a secondary page.

REPRO

Uncomment the <xamFormsCarousel:CarouselViewControl>, remove the <c:Carousel> and run on the Android version of the app.  Swipe left and right to see how the templates bleed over the bottom Indicator.

FIX

Removes the CarouselViewControl's issue of not rendering the control's view height on Android during first load.

ALSO

The problem might lye in the Android renderer's SetNativeView function. It occurs regardless whether the DataTemplate uses a StackPanel or Grid control as the wrapper.  Not sure about Windows as we use UWP/WinRT solutions with MSFT based XAML for that platform. This may possibly be related to the following:

https://github.com/alexrainman/CarouselView/issues/184

https://github.com/alexrainman/CarouselView/issues/123
