using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Practica1;
using Practica_1.CustomRenderers;
using Practica_1.Droid;
[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace Practica_1.Droid
{
    class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context) 
        { 
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control != null) 
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightBlue);
            }
        }
    }
}