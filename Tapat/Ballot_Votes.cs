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
    [Activity(Label = "Ballot_Votes")]
    public class Ballot_Votes : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Ballot_Votes);

            Button recap = FindViewById<Button>(Resource.Id.recapture_button);
            Button confirm = FindViewById<Button>(Resource.Id.confirm_button);

            recap.Click += delegate {
                StartActivity(typeof(Tapat.Capture_Ballot));
            };


            confirm.Click += delegate {
                StartActivity(typeof(Tapat.Verify_VVPAT));
            };
        }
    }
}