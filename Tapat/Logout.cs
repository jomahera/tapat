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
    [Activity(Label = "Logout")]
    public class Logout : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Logout);
            Button login = FindViewById<Button>(Resource.Id.login);

            login.Click += delegate {
                StartActivity(typeof(Tapat.Login));
            };
        }
    }
}