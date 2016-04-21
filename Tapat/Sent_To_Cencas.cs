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
    [Activity(Label = "Sent_To_Cencas")]
    public class Sent_To_Cencas : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Sent_To_Cencas);
            Button logout = FindViewById<Button>(Resource.Id.main);

            logout.Click += delegate {
                StartActivity(typeof(Tapat.Logout));
            };
        }
    }
}