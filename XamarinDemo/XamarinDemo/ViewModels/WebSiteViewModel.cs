using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinDemo.ViewModels
{
    public class WebSiteViewModel: BaseViewModel
    {
        public WebSiteViewModel()
        {
            Title = "网站";
            Url = "https://www.baidu.com";
        }

        private string _url;
        public string Url
        {
            get => _url;
            set => SetProperty(ref _url, value);
        }

        public ICommand RefreshCommand => new Command(() => {
            Url = "";
            Url = "https://www.baidu.com";
            IsBusy = false;
        });
    }
}
