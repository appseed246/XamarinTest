using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTest
{
    public partial class MainPage : ContentPage
    {

        public ListView listView;
        private QiitaAPI api = new QiitaAPI();
        public List<QiitaArticleEntity> articleList;
        public Command OnClick;

        public MainPage()
        {
            this.BindingContext = new Command(
                async () => await this.FetchArticles());
            InitializeComponent();
            var nouse = this.FetchArticles();
        }

        async Task OnClicked(object sender, EventArgs e)
        {
            await FetchArticles();
        }

        async void OnSelect(object sender, SelectedItemChangedEventArgs e)
        {
            var index = (Articles.ItemsSource as List<String>).IndexOf(e.SelectedItem as String);
            var articleUrl = articleList[index].Url;
            await Navigation.PushAsync(new ArticlePage(articleUrl));
        }

        async Task Reload(object sender, EventArgs e)
        {
            await this.FetchArticles();
            this.Articles.IsRefreshing = false;
        }

        // 非同期でデータ取得のメソッドを実行するメソッド
        async Task FetchArticles()
        {

            try
            {
                // 取得したデータをListに設定
                articleList = await api.AsyncGetWebAPIData();
                var items = new List<String>();
                System.Diagnostics.Debug.WriteLine("ababa");
                articleList.ForEach(a => items.Add(a.Title));
                this.Articles.BindingContext = items;
            }
            // エラー表示処理
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }

        }

    }
}
