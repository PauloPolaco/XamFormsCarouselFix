using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsCarouselFix.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            InitializeCarousel();
        }

        private void InitializeCarousel()
        {
            c_carouselControl.ItemsSource = new DataTemplate[]
            {
                this.Resources["CarouselTemplate1"] as DataTemplate,
                this.Resources["CarouselTemplate2"] as DataTemplate,
                this.Resources["CarouselTemplate3"] as DataTemplate
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}