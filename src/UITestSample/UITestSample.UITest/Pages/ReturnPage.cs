using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITestSample.UITest.Pages
{
    public class ReturnPage : BasePage
    {
        readonly Query returnButton;
        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("return_page"),
            iOS = x => x.Marked("return_page")
        };

        public ReturnPage()
        {
            returnButton = x => x.Marked("btn_return");
        }

        public void BackButton()
        {
            App.WaitForElement(returnButton);
            App.Tap(returnButton);
        }

        public void Back() => App.Back();
    }
}