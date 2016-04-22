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
    [Activity(Label = "VVPAT_Commit")]
    public class VVPAT_Commit : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.VVPAT_Commit);


            Button commit = FindViewById<Button>(Resource.Id.rechecked);




            commit.Click += delegate {
                StartActivity(typeof(Tapat.MainMenu4));
            };
        }

    }
}
