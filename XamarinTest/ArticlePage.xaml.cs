using System;
using System.Collections.Generic;
using Markdig;
using Markdig.SyntaxHighlighting;

using Xamarin.Forms;

namespace XamarinTest
{
    public partial class ArticlePage : ContentPage
    {

        public ArticlePage(String url)
        {
            Content = new WebView
            {
                Source = url
            };

        }

        int PaddingSize() 
        {
            switch(Device.RuntimePlatform)
            {
                case Device.iOS:
                    return 20;
                default:
                    return 0;
            }
        }
    }
}
