using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Tapat
{
    [Activity(Label = "Tapat", MainLauncher = true, Icon = "@drawable/icon")]
    public class Login : Activity
    {
     

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login);

            Button login = FindViewById<Button>(Resource.Id.login_button);
            EditText user = FindViewById<EditText>(Resource.Id.user_id);
            EditText pass = FindViewById<EditText>(Resource.Id.password);

            //Login functionality
            login.Click += delegate
            {
                if (user.Text != null)
                {
                    StartActivity(typeof(Tapat.Fingerprint_BEI));
                }
            };
        }
    }
}

