using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using XamarinTest;
using XamarinTest.iOS;

// FormsコントロールとRendererの対応を宣言
//[assembly: ExportRenderer(typeof(MainPage), typeof(MainPageRenderer))]

namespace XamarinTest.iOS
{
    //// ViewRendererの型引数にFormsコントロールとNativeコントロールを与える
    //public class MainPageRenderer : ViewRenderer<MainPage, UIView>
    //{
    //    protected override void OnElementChanged(ElementChangedEventArgs<MainPage> e)
    //    {
    //        // Nativeコントロールのインスタンス生成はココ！
    //        if (Control == null)
    //        {
    //            var nativeControl = new UIView();
    //            nativeControl.BackgroundColor = Color.Lime.ToUIColor();
    //            SetNativeControl(nativeControl);
    //        }

    //        base.OnElementChanged(e);
    //    }
    //}
}