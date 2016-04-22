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
    [Activity(Label = "VVPAT_Check")]
    public class VVPAT_Check : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.VVPAT_Check);
            Button proceed = FindViewById<Button>(Resource.Id.proceedd);

            proceed.Click += delegate {
                StartActivity(typeof(Tapat.VVPAT_IDEntries));
            };
        }
    }
}