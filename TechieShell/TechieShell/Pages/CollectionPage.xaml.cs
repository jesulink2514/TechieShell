using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechieShell.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TechieShell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionPage : ContentPage
    {
        public CollectionPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public Post[] Posts {get;set;} = Post.Samples;
    }
}