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
    [Activity(Label = "VVPAT_IDEntries")]
    public class VVPAT_IDEntries : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.VVPAT_IDEntries);

            Button vvpat1 = FindViewById<Button>(Resource.Id.id1);
            Button vvpat2 = FindViewById<Button>(Resource.Id.id2);
            Button vvpat3 = FindViewById<Button>(Resource.Id.id3);
            Button vvpat4 = FindViewById<Button>(Resource.Id.id4);
            Button vvpat5 = FindViewById<Button>(Resource.Id.id5);
            Button vvpat6 = FindViewById<Button>(Resource.Id.id6);
            Button vvpat7 = FindViewById<Button>(Resource.Id.id7);
            Button vvpat8 = FindViewById<Button>(Resource.Id.id8);
            Button vvpat9 = FindViewById<Button>(Resource.Id.id9);
            Button donee = FindViewById<Button>(Resource.Id.done);


            vvpat1.Click += delegate {
                StartActivity(typeof(Tapat.VVPAT_Check));
            };
            vvpat2.Click += delegate {
                StartActivity(typeof(Tapat.VVPAT_Check));
            };

            vvpat3.Click += delegate {
                StartActivity(typeof(Tapat.VVPAT_Check));
            };
            vvpat4.Click += delegate {
                StartActivity(typeof(Tapat.VVPAT_Check));
            };

            vvpat5.Click += delegate {
                StartActivity(typeof(Tapat.VVPAT_Check));
            };
            vvpat6.Click += delegate {
                StartActivity(typeof(Tapat.VVPAT_Check));
            };

            vvpat7.Click += delegate {
                StartActivity(typeof(Tapat.VVPAT_Check));
            };
            vvpat8.Click += delegate {
                StartActivity(typeof(Tapat.VVPAT_Check));
            };


            vvpat9.Click += delegate {
                StartActivity(typeof(Tapat.VVPAT_Check));
            };

            donee.Click += delegate {
                StartActivity(typeof(Tapat.VVPAT_Commit));
            };
        }
    }
}