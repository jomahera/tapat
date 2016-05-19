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
    [Activity(Label = "Capture_Ballot")]
    public class Capture_Ballot : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Capture_Ballot);

            Button capture = FindViewById<Button>(Resource.Id.proceed);

            capture.Click += delegate {
                StartActivity(typeof(Tapat.Captured));
            };
        }

    }
}
