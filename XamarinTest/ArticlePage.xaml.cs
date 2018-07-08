using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinTest
{
    public partial class ArticlePage : ContentPage
    {
        public ArticlePage(String url)
        {
            var webView = new WebView
            {
                Source = url
            };

            Content = webView;
        }
    }
}
