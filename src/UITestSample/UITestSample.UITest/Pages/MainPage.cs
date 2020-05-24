using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITestSample.UITest.Pages
{
    public class MainPage : BasePage
    {
        readonly Query simpleButton;
        readonly Query returnButton;
        readonly Query listButton;

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("main_page"),
            iOS = x => x.Marked("main_page")
        };

        public MainPage()
        {
            simpleButton = x => x.Marked("btn_sample");
            returnButton = x => x.Marked("btn_return");
            listButton = x => x.Marked("btn_list");
        }

        public void ClickBtnSample()
        {
            App.WaitForElement(simpleButton);
            App.Tap(simpleButton);
        }

        public void ClickBtnReturn()
        {
            App.WaitForElement(returnButton);
            App.Tap(returnButton);
        }

        public void ClickBtnList()
        {
            App.WaitForElement(listButton);
            App.Tap(listButton);
        }
    }
}