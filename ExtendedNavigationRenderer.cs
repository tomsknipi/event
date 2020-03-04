using System.Linq;
using Event.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(ExtendedNavigationRenderer))]

namespace Event.iOS
{
    public class ExtendedNavigationRenderer : NavigationRenderer
    {
        #region Поля

        private UIToolbar _secondaryToolbar;

        #endregion

        #region Методы

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            if (_secondaryToolbar?.Items != null)
            {
                foreach (var item in _secondaryToolbar.Items)
                {
                    var label = item.CustomView.Subviews.OfType<UILabel>().FirstOrDefault();
                    if (label != null)
                    {
                        label.TextColor = App.ColorIcons.ToUIColor();
                        //label.Font = label.Font.WithSize(12f);
                    }
                }
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //_secondaryToolbar = View.Subviews.OfType<UIToolbar>().FirstOrDefault(v => v.GetType() != typeof(UIToolbar));
            _secondaryToolbar = View.Subviews.OfType<UIToolbar>().FirstOrDefault();
            if (_secondaryToolbar != null)
                _secondaryToolbar.BarTintColor = App.ColorPrimary.ToUIColor();
        }

        #endregion
    }
}