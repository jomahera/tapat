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
    [Activity(Label = "User_Votes")]
    public class User_Votes : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.User_Votes);

            Button printballot= FindViewById<Button>(Resource.Id.print_ballot);
            Button recapture = FindViewById<Button>(Resource.Id.recapture_button);

            printballot.Click += delegate
                {
                    StartActivity(typeof(Tapat.Verify_VVPAT));
                };

            recapture.Click += delegate {
                    StartActivity(typeof(Tapat.Capture_Ballot));
                };
        }
    }
}
