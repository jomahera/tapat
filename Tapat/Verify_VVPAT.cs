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
    [Activity(Label = "Verify_VVPAT")]
    public class Verify_VVPAT : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Verify_VVPAT);

            Button confirm = FindViewById<Button>(Resource.Id.confirm_VVPAT);


            confirm.Click += delegate {
                StartActivity(typeof(Tapat.Cast_Vote));
            };
        }
    }
}