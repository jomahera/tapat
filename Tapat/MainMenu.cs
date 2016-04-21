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
    [Activity(Label = "Main_Menu")]
    public class MainMenu : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MainMenu);

            Button openpoll = FindViewById<Button>(Resource.Id.open_poll);
            Button closepoll = FindViewById<Button>(Resource.Id.close_poll);
            Button manualcount = FindViewById<Button>(Resource.Id.man_count);
            Button tallyvotes = FindViewById<Button>(Resource.Id.tally);
            Button logout = FindViewById<Button>(Resource.Id.logout_butt);

            openpoll.Click += delegate {
                StartActivity(typeof(Tapat.Fingerprint_Voter));
            };

            closepoll.Click += delegate {
                StartActivity(typeof(Tapat.Close_Poll));
            };

            manualcount.Click += delegate {
                StartActivity(typeof(Tapat.VVPAT_IDEntries));
            };

            tallyvotes.Click += delegate {
                StartActivity(typeof(Tapat.Tally_Votes));
            };
            logout.Click += delegate {
                StartActivity(typeof(Tapat.Logout));
            };
        }
    }
}