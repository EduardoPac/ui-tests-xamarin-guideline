using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITestSample.UITest.Pages
{
    public class ReturnPage : BasePage
    {
        readonly Query _returnButton;
        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("return_page"),
            iOS = x => x.Marked("return_page")
        };

        public ReturnPage()
        {
            _returnButton = x => x.Marked("btn_return");
        }

        public void BackButton()
        {
            App.WaitForElement(_returnButton);
            App.Tap(_returnButton);
        }
    }
}