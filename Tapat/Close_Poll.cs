using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Tapat
{
    [Activity(Label = "Close_Poll")]
    public class Close_Poll : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Close_Poll);
            Button mainmenu = FindViewById<Button>(Resource.Id.main);

            mainmenu.Click += delegate {
                StartActivity(typeof(Tapat.MainMenu3));
            };
        }
    }
}