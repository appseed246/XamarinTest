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

        public double DisplayWidth { get; private set; }
        public double DisplayHeight { get; private set; }

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
            var index = (Articles.ItemsSource as List<CellItem>).IndexOf(e.Item as CellItem);
            var url = articleList[index].Url;
            await Navigation.PushAsync(new ArticlePage(url));
        }

        async void OnLastItem(object sender, ItemVisibilityEventArgs e)
        {
            var item = e.Item as CellItem;
            if (articleList.Last().Id == item.Id)
            {
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

                var items = articleList.Select(a =>
                {
                    return new CellItem()
                    {
                        Id = a.Id,
                        Title = a.Title,
                        Url = a.Url,
                        ProfileImageUrl = a.User.ProfileImageUrl,
                        Username = a.User.Name,
                        UserId = a.User.Id,
                        IconSize = this.DisplayWidth * 0.15,
                        CreatedAt = a.CreatedAt
                    };
                }).ToList();
                this.Articles.BindingContext = items;
                //this.Articles.BindingContext = articleList;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            this.DisplayWidth = width;
            this.DisplayHeight = height;
            var unused = FetchArticles(this.pageNumber);
        }

        void Debug(object ob)
        {
            System.Diagnostics.Debug.WriteLine(ob);
        }

    }
}
