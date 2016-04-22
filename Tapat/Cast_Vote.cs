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
    [Activity(Label = "Case_Vote")]
    public class Cast_Vote : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Cast_Vote);

            Button voterlogin = FindViewById<Button>(Resource.Id.v_login);
            Button menu = FindViewById<Button>(Resource.Id.mainmenu);


            voterlogin.Click += delegate {
                StartActivity(typeof(Tapat.Fingerprint_Voter));
            };
            menu.Click += delegate {
                StartActivity(typeof(Tapat. MainMenu2));
            };
        }
    }
}