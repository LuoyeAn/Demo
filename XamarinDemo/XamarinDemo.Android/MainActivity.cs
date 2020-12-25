using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using PanCardView.Droid;
using MediaManager;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDemo.Droid
{
    [Activity(Label = "XamarinDemo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            CardsViewRenderer.Preserve();
            CrossMediaManager.Current.Init(this);
            LoadApplication(new App());
            SendMessage();
        }

        private async void SendMessage()
        {
            await Task.Delay(5000);
            MessagingCenter.Send(App.Current, "Hi","1");
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public override bool OnKeyUp([GeneratedEnum] Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back) 
            {
                Xamarin.Forms.Application.Current.MainPage.DisplayAlert("退出", "确认退出", "退出", "取消").ContinueWith(t =>
                {
                    if (t.Result)
                    {
                        this.FinishAffinity(); Xamarin.Forms.Application.Current.Quit();
                    }
                });
                return true;
            }
            return base.OnKeyUp(keyCode, e);
        }
    }
}