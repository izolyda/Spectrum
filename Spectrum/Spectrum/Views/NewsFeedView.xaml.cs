using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Spectrum.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spectrum.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsFeedView : ContentPage
    {
        public ObservableCollection<News> Items { get; set; }

        List<News> NewsFeedList = RSSFeedReader.NewsList;

        private bool _order = true;


        public NewsFeedView (List<News> news)
        {
            InitializeComponent();

            listViewNewsFeed.BindingContext = new ObservableCollection<News>(news);
           
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            Navigation.PushAsync(new NewsView((News)e.Item));
            
            ((ListView)sender).SelectedItem = null;
        }

        void SearchBar_TextChanged(System.Object sender, TextChangedEventArgs e)
        {
            listViewNewsFeed.BindingContext = NewsFeedList.Where(n => n.Title.ToLower().Contains(e.NewTextValue.ToLower()));

        }

        void listViewNewsFeed_Refreshing(System.Object sender, System.EventArgs e)
        {
            listViewNewsFeed.EndRefresh();

        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            listViewNewsFeed.BindingContext = _order ? NewsFeedList.OrderBy(x => x.Title).Reverse() : NewsFeedList.OrderBy(x => x.Title);

            _order = !_order;
        }
    }
}

