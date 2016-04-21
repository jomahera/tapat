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

            Button confirm= FindViewById<Button>(Resource.Id.confirm_button);
            Button recapture = FindViewById<Button>(Resource.Id.recapture_button);

            confirm.Click += delegate
                {
                    StartActivity(typeof(Tapat.MainMenu));
                };

            recapture.Click += delegate {
                    StartActivity(typeof(Tapat.Capture_Ballot));
                };
        }
    }
}
