using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using System.Text;
using System.ComponentModel;

[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(Practica_1.Droid.FocusEffect),nameof(Practica_1.Droid.FocusEffect))]
namespace Practica_1.Droid
{
    public class FocusEffect : PlatformEffect
    {
        Android.Graphics.Color originalBackgrounColor = new Android.Graphics.Color(0, 0, 0, 0);
        Android.Graphics.Color backgroundColor;


        protected override void OnAttached()
        {
            try 
            {
                backgroundColor = Android.Graphics.Color.LightBlue;
                Control.SetBackgroundColor(backgroundColor);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
        protected override void OnDetached()
        {
            
        }
        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            try 
            {
                if(args.PropertyName == "IsFocused")
                {
                    if(((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == backgroundColor)
                    {
                        Control.SetBackgroundColor(originalBackgrounColor);
                    }
                    else
                    {
                        Control.SetBackgroundColor(backgroundColor);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
    }
}