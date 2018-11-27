using Xamarin.Forms;
using XamarinTest;
using XamarinTest.Droid;

[assembly: Dependency(typeof(BaseUrl))]
namespace XamarinTest.Droid
{
    public class BaseUrl : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}
