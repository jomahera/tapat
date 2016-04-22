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
    [Activity(Label = "Main_Menu4")]
    public class MainMenu4 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MainMenu4);



    
            Button tallyvotes = FindViewById<Button>(Resource.Id.tally);
            Button logout = FindViewById<Button>(Resource.Id.logout_butt);


   
            tallyvotes.Click += delegate {
                StartActivity(typeof(Tapat.Tally_Votes));
            };
            logout.Click += delegate {
                StartActivity(typeof(Tapat.Logout));
            };
        }
    }
}