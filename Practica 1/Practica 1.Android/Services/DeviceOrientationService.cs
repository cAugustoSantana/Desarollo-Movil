using Android.Content;
using Android.Runtime;
using Android.Views;
using Xamarin.Forms;
using Practica_1.Services;
using Practica_1.Droid;



[assembly: Dependency(typeof(DeviceOrientation))]
namespace Practica_1.Droid.Services
{
   public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
            
            bool isLandscape = orientation == SurfaceOrientation.Rotation90 ||
                orientation == SurfaceOrientation.Rotation270;

            return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;

        }
    }
}