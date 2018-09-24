using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTest
{
    public partial class MainPage : ContentPage
    {

        private QiitaAPI api = new QiitaAPI();
        public List<Article> articleList = new List<Article>();
        public Command OnClick;
        private int pageNumber = 1;

        public MainPage()
        {
            this.BindingContext = new Command(async () =>
            {
                if (this.Articles.IsRefreshing)
                {
                    return;
                }
                this.Articles.IsRefreshing = true;
                await this.FetchArticles(this.pageNumber);
                this.Articles.IsRefreshing = false;
            });
            InitializeComponent();
            var unUsed = this.FetchArticles(this.pageNumber);
        }

        async Task OnClicked(object sender, EventArgs e)
        {
            if (this.Articles.IsRefreshing)
            {
                return;
            }
            this.Articles.IsRefreshing = true;
            await FetchArticles(this.pageNumber);
            this.Articles.IsRefreshing = false;
        }

        async void OnTapped(object sender, ItemTappedEventArgs e)
        {
            var index = (Articles.ItemsSource as List<String>).IndexOf(e.Item as String);
            var url = articleList[index].Url;
            await Navigation.PushAsync(new ArticlePage(url));
        }

        async void OnLastItem(object sender, ItemVisibilityEventArgs e)
        {
            if (articleList.Last().Title == e.Item as String)
            {
                System.Diagnostics.Debug.WriteLine(e.Item);
                this.pageNumber++;
                this.Bottom.IsVisible = true;
                await FetchArticles(this.pageNumber);
                this.Bottom.IsVisible = false;
            }
        }

        async Task Reload(object sender, EventArgs e)
        {
            if (this.Articles.IsRefreshing)
            {
                return;
            }

            if (articleList.Any())
            {
                articleList.Clear();
                this.pageNumber = 1;
            }
            await this.FetchArticles(this.pageNumber);
            this.Articles.IsRefreshing = false;
        }

        // 非同期でデータ取得のメソッドを実行するメソッド
        async Task FetchArticles(int page)
        {
            try
            {
                var fetchedArticles = await api.AsyncGetWebAPIData(page);

                // 既にリストに含まれているものを除いて追加する
                var articleIds = articleList.Select(x => x.Id);
                var newArticles = fetchedArticles
                    .Where(x => !articleIds.Contains(x.Id))
                    .ToList();

                articleList.AddRange(newArticles);

                var items = articleList.Select(a => a.Title).ToList();
                this.Articles.BindingContext = items;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
        }

        void Debug(object ob)
        {
            System.Diagnostics.Debug.WriteLine(ob);
        }

    }
}
