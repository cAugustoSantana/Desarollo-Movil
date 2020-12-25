using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Practica_1.Services;

namespace Practica_1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrientationPage : TabbedPage
    {
        public OrientationPage()
        {
            InitializeComponent();
        }

        void OnGetDeviceOrientatcionButtonClicked(object sender, EventArgs e)
        {
            DeviceOrientation orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
            orientationLabel.Text = orientation.ToString();
        }
    }
}