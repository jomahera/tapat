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
    [Activity(Label = "mainscreen")]
    public class MainMenu : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MainMenu);

            Button openpoll = FindViewById<Button>(Resource.Id.open_poll);


            openpoll.Click += delegate {
                StartActivity(typeof(Tapat.Fingerprint_Voter));
            };
        }
    }
}