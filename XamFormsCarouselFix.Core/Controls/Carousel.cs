using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarouselView.FormsPlugin.Abstractions;
using Xamarin.Forms;

namespace XamFormsCarouselFix.Controls
{
    /// <summary>
    /// Custom CarouselViewControl.
    /// </summary>
    /// <remarks>
    /// Fixes the issue of CarouselViewControl not rendering 
    /// the control's view height correctly on Android during
    /// first load.
    /// </remarks>
    public sealed class Carousel : CarouselViewControl
    {
        /// <summary>
        /// Custom CarouselViewControl.
        /// </summary>
        /// <remarks>
        /// Fixes the issue of CarouselViewControl not rendering 
        /// the control's view height correctly on Android during
        /// first load.
        /// </remarks>
        public Carousel()
        {
        }
    }
}