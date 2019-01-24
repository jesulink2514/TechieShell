using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechieShell.Model;
using Xamarin.Forms;

namespace TechieShell
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public Post[] Items {get;set; } = Post.Samples;
    }
}
