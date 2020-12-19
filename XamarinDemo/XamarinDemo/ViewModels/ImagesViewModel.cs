using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using XamarinDemo.Models;
using XamarinDemo.Views;

namespace XamarinDemo.ViewModels
{
    public class ImagesViewModel : BaseViewModel
    {
        public ImagesViewModel()
        {
            Title = "图片";
            Images = new ObservableCollection<ImageModel>();
            Images.Add(new ImageModel
            {
                ImageUrl = "https://hmediastoragestagingv4.blob.core.chinacloudapi.cn/t-1-resource/19ed251d-cdfb-5ce3-e798-fd611a5526ca.jpg"
            });
            Images.Add(new ImageModel
            {
                ImageUrl = "https://cdn-image.bopoda.cn/t-3-resource/d88ea1db-c5af-fc99-38f8-3bb440b81e12.png"
            });
        }

        public ObservableCollection<ImageModel> Images { get; set; }
    }
}