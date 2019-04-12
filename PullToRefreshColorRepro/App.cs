using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PullToRefreshColorRepro
{
    public class App : Xamarin.Forms.Application
    {
        public App() => MainPage = new ListViewPage();
    }

    class ListViewPage : ContentPage
    {
        readonly Xamarin.Forms.ListView _listView;

        public ListViewPage()
        {
            _listView = new Xamarin.Forms.ListView
            {
                BackgroundColor = Color.Transparent,
                IsPullToRefreshEnabled = true,
                RefreshControlColor = Color.Cyan
            };
            _listView.Refreshing += HandleListViewRefreshing;

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            BackgroundColor = Color.DarkGray;

            Content = _listView;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _listView.BeginRefresh();
        }

        async void HandleListViewRefreshing(object sender, EventArgs e)
        {
            await Task.Delay(1500);
            _listView.EndRefresh();
        }
    }
}