using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebSitePage : ContentPage
    {
        public WebSitePage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<Application,string>(App.Current, "Hi", (t,p) =>
            {
                System.Diagnostics.Debug.WriteLine("2fdsf");
                DisplayAlert("Hi",p,"OK");
            });
        }
    }
}