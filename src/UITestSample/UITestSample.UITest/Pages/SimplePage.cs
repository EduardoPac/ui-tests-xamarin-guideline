namespace UITestSample.UITest.Pages
{
    public class SimplePage : BasePage
    {
        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("simple_page"),
            iOS = x => x.Marked("simple_page")
        };
    }
}