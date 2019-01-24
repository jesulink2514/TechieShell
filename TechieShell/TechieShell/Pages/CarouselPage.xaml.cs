using System.Diagnostics;
using TechieShell.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TechieShell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPage : ContentPage
    {
        public CarouselPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public Post[] Posts {get;set;} = Post.Samples;

        private void CarouselView_ScrollToRequested(object sender, ScrollToRequestEventArgs e)
        {
            Debug.WriteLine($"Scrolling to {e.Index}...");
        }
    }
}