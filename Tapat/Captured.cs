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
using Android.Content.PM;
using Android.Graphics;
using Android.Provider;
using Java.IO;
using Environment = Android.OS.Environment;
using Uri = Android.Net.Uri;
using Android.Media;
using Android.Util;

namespace Tapat
{

    public static class App
    {
        public static File _file;
        public static File _dir;
        public static Bitmap bitmap;
    }


    [Activity(Label = "Captured")]
    public class Captured : Activity
    {

        private ImageView _imageView;

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            // Make it available in the gallery

            Intent mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
            Uri contentUri = Uri.FromFile(App._file);
            mediaScanIntent.SetData(contentUri);
            SendBroadcast(mediaScanIntent);

            // Display in ImageView. We will resize the bitmap to fit the display
            // Loading the full sized image will consume to much memory 
            // and cause the application to crash.

            int height = Resources.DisplayMetrics.HeightPixels;
            int width = _imageView.Height;
            App.bitmap = App._file.Path.LoadAndResizeBitmap(width, height);
            if (App.bitmap != null)
            {
                _imageView.SetImageBitmap(App.bitmap);
                App.bitmap = null;
            }

            // Dispose of the Java side bitmap.
            GC.Collect();
        }






        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.captured);


            if (IsThereAnAppToTakePictures())
            {
                CreateDirectoryForPictures();

                Button capture = FindViewById<Button>(Resource.Id.capture);
                Button proceed = FindViewById<Button>(Resource.Id.proceed);
                _imageView = FindViewById<ImageView>(Resource.Id.imageView1);
                capture.Click += TakeAPicture;

                proceed.Click += delegate {
                    StartActivity(typeof(Tapat.Ballot_Votes));
                };
            }

            


            //  Button capture = FindViewById<Button>(Resource.Id.capture_button);

            //     capture.Click += delegate {
            //             StartActivity(typeof(Tapat.Ballot_Votes));
            //        };
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CreateDirectoryForPictures()
        {
            App._dir = new File(
                Environment.GetExternalStoragePublicDirectory(
                    Environment.DirectoryPictures), "CapturedBallots");
            if (!App._dir.Exists())
            {
                App._dir.Mkdirs();
            }
        }

        private bool IsThereAnAppToTakePictures()
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            IList<ResolveInfo> availableActivities =
                PackageManager.QueryIntentActivities(intent, PackageInfoFlags.MatchDefaultOnly);
            return availableActivities != null && availableActivities.Count > 0;
        }

        private void TakeAPicture(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);

            App._file = new File(App._dir, String.Format("ballotEntry_{0}.jpg", Guid.NewGuid()));

            intent.PutExtra(MediaStore.ExtraOutput, Uri.FromFile(App._file));

            StartActivityForResult(intent, 0);
        }

        /* public static Bitmap rotate(Bitmap bitmap, int degree)
        {
            int w = bitmap.getWidth();
            int h = bitmap.getHeight();

            Matrix mtx = new Matrix();
            //       mtx.postRotate(degree);
            mtx.setRotate(degree);

            return Bitmap.createBitmap(bitmap, 0, 0, w, h, mtx, true);
        } */
    }
}
