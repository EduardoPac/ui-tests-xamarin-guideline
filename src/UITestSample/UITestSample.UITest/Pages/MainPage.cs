using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITestSample.UITest.Pages
{
    public class MainPage : BasePage
    {
        readonly Query _simpleButton;
        readonly Query _returnButton;
        readonly Query _listButton;

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("main_page"),
            iOS = x => x.Marked("main_page")
        };

        public MainPage()
        {
            _simpleButton = x => x.Marked("btn_sample");
            _returnButton = x => x.Marked("btn_return");
            _listButton = x => x.Marked("btn_list");
        }

        public MainPage ClickBtnSample()
        {
            App.WaitForElement(_simpleButton);
            App.Tap(_simpleButton);

            return this;
        }

        public MainPage ClickBtnReturn()
        {
            App.WaitForElement(_returnButton);
            App.Tap(_returnButton);
            return this;
        }

        public MainPage ClickBtnList()
        {
            App.WaitForElement(_listButton);
            App.Tap(_listButton);

            return this;
        }
    }
}