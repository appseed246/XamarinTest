using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(WebView), typeof(XamarinTest.Droid.MyWebViewRenderer))]
namespace XamarinTest.Droid
{
    public class MyWebViewRenderer : WebViewRenderer
    {
        public MyWebViewRenderer(Context context) : base(context)
        {
        }

        //protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        //{
        //    base.OnElementChanged(e);
        //    Control.Settings.LoadWithOverviewMode = true;
        //    Control.Settings.UseWideViewPort = true;
        //    Control.Settings.DefaultFontSize = 30;
        //}
    }
}