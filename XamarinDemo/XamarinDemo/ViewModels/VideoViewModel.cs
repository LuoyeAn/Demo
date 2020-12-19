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
            Url = "https://hmediastoragestagingv4.blob.core.chinacloudapi.cn/t-1-asset/308c25cc-dde9-4b5a-8505-2ea10c41980c.mp4?sv=2018-03-28&sr=c&sig=CQViMlz%2BbbsWl7DdSBNj%2B6fNTz05y%2FIyMhyh%2F6sydT0%3D&se=2020-12-19T13%3A54%3A50Z&sp=rl";
            Videos = new ObservableCollection<VideoModel>();
            Videos.Add(new VideoModel
            {
                Name="第一个视频",
                PathUrl= "https://hmediastoragestagingv4.blob.core.chinacloudapi.cn/t-1-asset/308c25cc-dde9-4b5a-8505-2ea10c41980c.mp4?sv=2018-03-28&sr=c&sig=CQViMlz%2BbbsWl7DdSBNj%2B6fNTz05y%2FIyMhyh%2F6sydT0%3D&se=2020-12-19T13%3A54%3A50Z&sp=rl"
            });
            Videos.Add(new VideoModel
            {
                Name = "第二个视频",
                PathUrl = "https://cdn.bopoda.cn/t-3-resource/969368bf-9f81-f3a0-ee40-4f7bd06e6787.mp4"
            });

            for(var i = 0; i < 10; i++)
            {
                Videos.Add(new VideoModel
                {
                    Name = "第二个视频",
                    PathUrl = "https://cdn.bopoda.cn/t-3-resource/969368bf-9f81-f3a0-ee40-4f7bd06e6787.mp4"
                });
            }
            
        }

        public ObservableCollection<VideoModel> Videos { get; set; }

        private string _url;
        public string Url
        {
            get => _url;
            set => SetProperty(ref _url, value);
        }
    }
}