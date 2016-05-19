using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

//using SQLite;
using Microsoft.WindowsAzure.MobileServices;

namespace Tapat
{
    [Activity(Label = "Tapat", MainLauncher = true, Icon = "@drawable/icon")]
    public class Login : Activity
    {

        public static MobileServiceClient MobileService = new MobileServiceClient("https://tapat2.azurewebsites.net");

        public class BEI
        {
            //[PrimaryKey, AutoIncrement]
            public int BEI_id { get; set; }
            public string pword { get; set; }
        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login);

            Button login = FindViewById<Button>(Resource.Id.login_button);
            EditText user = FindViewById<EditText>(Resource.Id.user_id);
            EditText pass = FindViewById<EditText>(Resource.Id.password);

            string dbName = "tapat.sqlite";
            string dbPath = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.ToString(), dbName);
            //string sqlQuery = "SELECT BEI_id FROM BEI WHERE BEI_id = '" + user.Text + "' AND pword = '" + pass.Text + "';";
            var r = 0;

            //using (SQLiteConnection conn = new SQLiteConnection(dbPath))
            {
                try
                {
                    login.Click += delegate
                    {
                        if (!user.Text.Equals("") && !pass.Text.Equals(""))
                        {

                            //SQLiteCommand cmd = new SQLiteCommand(conn);
                            //cmd.CommandText = "SELECT BEI_ FROM BEI WHERE BEI_id = '" + user.Text + "' AND pword = '" + pass.Text + "';";
                            //r = cmd.ExecuteScalar<Int32>();

                            try
                            {
                                if (user.Text.Equals("1") || user.Text.Equals("2")  || user.Text.Equals("3") && pass.Text.Equals("qwerty"))
                                {
                                    StartActivity(typeof(Tapat.Fingerprint_BEI));
                                }

                                else
                                {
                                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                                    alert.SetTitle("Error");
                                    alert.SetMessage("Incorrect credentials. Please try again.");
                                    alert.SetPositiveButton("OK", (senderAlert, args) => {
                                        Toast.MakeText(this, "Returning", ToastLength.Short).Show();
                                    });

                                    Dialog dialog = alert.Create();
                                    dialog.Show();
                                }
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }

                        else
                        {
                            AlertDialog.Builder alert = new AlertDialog.Builder(this);
                            alert.SetTitle("Error");
                            alert.SetMessage("Please enter both your BEI ID and password.");
                            alert.SetPositiveButton("OK", (senderAlert, args) => {
                                Toast.MakeText(this, "Returning", ToastLength.Short).Show();
                            });

                            Dialog dialog = alert.Create();
                            dialog.Show();
                        }
                    };

                } catch
                {
                    //throw exception;
                }
                finally
                {
                    //conn.Close();
                }

            };

            }
        }
    }



