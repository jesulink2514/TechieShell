using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TechieShell.Model
{
    public class Post: BindableObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverUrl { get; set; }

        public Post()
        {
        }
        public Post(string title,string desc, string cover)
        {
            Title = title;
            Description = desc;
            CoverUrl = cover;
        }

        public static Post[] Samples = new[]
        {
            new Post("Implementando BottomTabs en Xamarin.Forms","Es muy comun que nos pidan implementar tabs inferiores en Android y iOS, lo cual va mas alla de lo que Xamarin.Forms nos da, pero tranquilos siempre hay un paquete con un CustomRenderer al rescate ","https://somostechies.com/content/images/2018/04/promotional_bottomTabs.jpg"),
            new Post("Implementando BottomTabs en Xamarin.Forms","Es muy comun que nos pidan implementar tabs inferiores en Android y iOS, lo cual va mas alla de lo que Xamarin.Forms nos da, pero tranquilos siempre hay un paquete con un CustomRenderer al rescate ","https://somostechies.com/content/images/2018/04/promotional_bottomTabs.jpg"),
            new Post("Implementando BottomTabs en Xamarin.Forms","Es muy comun que nos pidan implementar tabs inferiores en Android y iOS, lo cual va mas alla de lo que Xamarin.Forms nos da, pero tranquilos siempre hay un paquete con un CustomRenderer al rescate ","https://somostechies.com/content/images/2018/04/promotional_bottomTabs.jpg")
        };
    }
}
