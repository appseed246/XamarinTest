using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;

namespace XamarinTest
{
    public partial class MainPage : ContentPage
    {
        public ListView listView;
        public List<QiitaArticleEntity> articleList;
        private QiitaAPI api = new QiitaAPI();

        public MainPage()
        {
            InitializeComponent();
            Title = "新着記事";

            InitListViewSetting();

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { listView }
            };

            // ツールバーに更新ボタンを追加
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "更新",
                Command = new Command(() =>
                {
                    // リストをクリアしてから更新
                    listView.ItemsSource = new List<String>();
                    fetchArticles();
                })
            });

            fetchArticles();

        }

        private void InitListViewSetting()
        {
            
            listView = new ListView
            {
                RowHeight = 60
            };

            // タイトルをタップして記事を開く
            listView.ItemSelected += async (sender, e) =>
            {
                var index = (listView.ItemsSource as List<String>).IndexOf(e.SelectedItem as String);
                var articleUrl = articleList[index].Url;
                await Navigation.PushAsync(new ArticlePage(url: articleUrl));
            };

            // Refresh-To-Swipeを有効にする
            listView.IsPullToRefreshEnabled = true;
            listView.Refreshing += async (sender, e) => {
                await fetchArticles();
                listView.IsRefreshing = false;
            };

        }

        async Task fetchArticles()
        {

            Debug.WriteLine("--- fetch start ---");

            try
            {
                articleList = await api.AsyncGetWebAPIData();

                var items = new List<String>();

                foreach (QiitaArticleEntity value in articleList)
                {
                    items.Add(value.Title);
                }

                listView.ItemsSource = items;

                Debug.WriteLine("--- success ---");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "OK");
            }
        }
    }
}
