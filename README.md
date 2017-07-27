# XamFormsCarouselFix
Fixes the issue of _CarouselViewControl_ not rendering the control's view height correctly on _Android_ during first load.

### Description of Defect
The _CarouselViewControl_ has an issue of not rendering the control's view height on _Android_ during first load. The control's content bleeds into and past the _Indicator_ which is situated at the bottom of the control. The bug only occurs when the control is on the primarily loaded page.  The bug does not occur during second loading of the page or when the control is situated on a secondary page.

### Bug Repro
Uncomment the _<xamFormsCarousel:CarouselViewControl>_, remove the _<c:Carousel>_ and run on the _Android_ version of the app.  Swipe left and right to see how the templates bleed over the bottom _Indicator_.

### Fix
Removes the _CarouselViewControl's_ issue of not rendering the control's view height on _Android_ during first load.

### Additional Info
The problem might lye in the _Android_ renderer's _SetNativeView()_ function. It occurs regardless whether the _DataTemplate_ uses a _StackPanel_ or _Grid_ control as the wrapper.  Not sure about Windows as we use _UWP/WinRT_ solutions with MSFT based _XAML_ for that platform. This may possibly be related to the following:  

* [Android does not re-measure its layout on Height Changed](https://github.com/alexrainman/CarouselView/issues/184)  

* [Carousel miscalculating heights in some cases](https://github.com/alexrainman/CarouselView/issues/123)