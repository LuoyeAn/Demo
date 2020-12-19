using MediaManager;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinDemo.Models;


namespace XamarinDemo.ViewModels
{
    public class VideoViewModel : BaseViewModel
    {
        public VideoViewModel()
        {
            Title = "视频";
            Videos = new ObservableCollection<VideoModel>();
            Videos.Add(new VideoModel
            {
                Name= "紧急救援",
                PathUrl= "https://vfx.mtime.cn/Video/2019/03/19/mp4/190319222227698228.mp4"
            });
            Videos.Add(new VideoModel
            {
                Name = "赏金律条",
                PathUrl = "https://vfx.mtime.cn/Video/2019/03/21/mp4/190321153853126488.mp4"
            });

            Videos.Add(new VideoModel
            {
                Name = "驯龙高手",
                PathUrl = "https://vfx.mtime.cn/Video/2019/02/04/mp4/190204084208765161.mp4"
            });
        }

        public ObservableCollection<VideoModel> Videos { get; set; }
    }
}