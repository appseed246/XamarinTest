using System;
using Xamarin.Forms;
using System.IO;
using System.Reflection;

using AngleSharp.Parser.Html;

namespace XamarinTest
{
    public interface IBaseUrl { string Get(); }

    public partial class ArticlePage : ContentPage
    {

        public ArticlePage(String body)
        {
            var parser = new HtmlParser();
            string htmlText = GetResourceText("XamarinTest.Assets.index.html");

            var document = parser.Parse(htmlText);
            var element = document.GetElementById("content");
            element.InnerHtml = body;

            var main = document.DocumentElement.OuterHtml;
            System.Diagnostics.Debug.WriteLine(main);

            var html = new HtmlWebViewSource
            {
                Html = main,
                BaseUrl = DependencyService.Get<IBaseUrl>().Get()
            };
            Content = new ArticleView
            {
                Source = html
            };
            Padding = PaddingSize();
        }

        int PaddingSize()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    return 20;
                default:
                    return 0;
            }
        }

        public string GetResourceText(string path)
        {
            var text = "";
            var assembly = typeof(ArticlePage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(path);
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            return text;
        }
    }

    public class ArticleView : WebView
    {
        public ArticleView()
        {

        }
    }
}
