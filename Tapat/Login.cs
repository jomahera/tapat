using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.WindowsAzure.MobileServices;

namespace Tapat
{
    [Activity(Label = "Tapat", MainLauncher = true, Icon = "@drawable/icon")]
    public class Login : Activity
    {

        public static MobileServiceClient MobileService = new MobileServiceClient("https://tapat2.azurewebsites.net");
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login);

            Button login = FindViewById<Button>(Resource.Id.login_button);
            EditText user = FindViewById<EditText>(Resource.Id.user_id);
            EditText pass = FindViewById<EditText>(Resource.Id.password);

            //Login functionality; to be coded later after SQL server has been connected
            login.Click += async delegate
            {
                //Test code
                CurrentPlatform.Init();
                TodoItem item = new TodoItem { Text = "Test Run" };
                await MobileService.GetTable<TodoItem>().InsertAsync(item);

                if (user.Text != null)
                {
                    StartActivity(typeof(Tapat.Fingerprint_BEI));
                }
            };
        }

        public class TodoItem
        {
            public string Id { get; set; }
            public string Text { get; set; }
        }

    }
}

