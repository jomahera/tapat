
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
    [Activity(Label = "Voter_Profile")]
    public class Voter_Profile : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Voter_Profile);

            Button proceed = FindViewById<Button>(Resource.Id.proceed_butt);
            Button tryagain = FindViewById<Button>(Resource.Id.try_again);

            proceed.Click += delegate {
                StartActivity(typeof(Tapat.Capture_Ballot));
            };

            tryagain.Click += delegate {
                StartActivity(typeof(Tapat.Fingerprint_Voter));
            };
        }
    }
}
