using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_1.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RendererPage : ContentPage
    {
        public RendererPage()
        {
            Content = new StackLayout
            {
                Children = {
        new Label {
          Text = "Hello, Custom Renderer !",
        },
        new MyEntry {
          Text = "In Shared Code",
        }
      },
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            
        }
    }
}