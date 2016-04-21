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
    [Activity(Label = "Tally_Votes")]
    public class Tally_Votes : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Tally_Votes);

            Button sendtocencas = FindViewById<Button>(Resource.Id.send);


            sendtocencas.Click += delegate {
                StartActivity(typeof(Tapat.Sent_To_Cencas));
            };
        }
    }
}