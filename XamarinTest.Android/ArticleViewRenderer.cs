using XamarinTest;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinTest.Droid;

[assembly: ExportRenderer(typeof(ArticleView), typeof(ArticleViewRenderer))]
namespace XamarinTest.Droid
{
    public class ArticleViewRenderer : WebViewRenderer
    {
        public ArticleViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
            Control.Settings.LoadWithOverviewMode = true;
            Control.Settings.UseWideViewPort = true;
        }
    }
}