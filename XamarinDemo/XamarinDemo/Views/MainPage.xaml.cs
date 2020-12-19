using MediaManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using XamarinDemo.ViewModels;

namespace XamarinDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

            this.CurrentPageChanged += MainPage_CurrentPageChanged;
        }

        private bool firstLoadVideoPage = true;
        private void MainPage_CurrentPageChanged(object sender, EventArgs e)
        {
            if (CurrentPage is NavigationPage navigationPage && navigationPage.CurrentPage is VideoPage videoPage && firstLoadVideoPage)
            {
                firstLoadVideoPage = false;
                var viewModel = videoPage.BindingContext as VideoViewModel;
                if (viewModel != null)
                {
                    CrossMediaManager.Current.Play(viewModel.Videos.Select(x => x.PathUrl));
                }
            }
        }
    }
}