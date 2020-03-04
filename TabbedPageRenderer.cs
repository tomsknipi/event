using Event.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(TabbedPageRenderer))]

namespace Event.iOS
{
    public class TabbedPageRenderer : TabbedRenderer
    {
        #region Методы

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            TabBar.TintColor = App.ColorIcons.ToUIColor();
            TabBar.BarTintColor = App.ColorPrimary.ToUIColor();
            TabBar.UnselectedItemTintColor = App.ColorPrimaryText.ToUIColor();
        }

        #endregion

        //public override void ViewWillLayoutSubviews()
        //{
        //    base.ViewWillLayoutSubviews();
        //    var tabBarHeight = 30f;
        //    TabBar.Frame = new CGRect(TabBar.Frame.X, TabBar.Frame.Y + (TabBar.Frame.Height - tabBarHeight), TabBar.Frame.Width, tabBarHeight);
        //}
    }
}