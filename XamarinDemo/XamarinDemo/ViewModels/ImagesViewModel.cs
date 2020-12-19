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
                ImageUrl = "https://dss1.bdstatic.com/70cFvXSh_Q1YnxGkpoWK1HF6hhy/it/u=2771978851,2906984932&fm=26&gp=0.jpg"
            });
            Images.Add(new ImageModel
            {
                ImageUrl = "https://dss1.bdstatic.com/70cFvXSh_Q1YnxGkpoWK1HF6hhy/it/u=1091405991,859863778&fm=26&gp=0.jpg"
            });
            Images.Add(new ImageModel
            {
                ImageUrl = "https://dss1.bdstatic.com/70cFuXSh_Q1YnxGkpoWK1HF6hhy/it/u=1089874897,1268118658&fm=26&gp=0.jpg"
            });
        }

        public ObservableCollection<ImageModel> Images { get; set; }
    }
}