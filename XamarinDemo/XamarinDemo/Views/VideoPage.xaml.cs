using MediaManager;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.ViewModels;
using System.Linq;

namespace XamarinDemo.Views
{
    public partial class VideoPage : ContentPage
    {
        public VideoPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CrossMediaManager.Current.KeepScreenOn = true;
            CrossMediaManager.Current.Play();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            CrossMediaManager.Current.KeepScreenOn = false;
            CrossMediaManager.Current.Pause();
        }
    }
}