using NUnit.Framework;
using UITestSample.UITest.Pages;
using Xamarin.UITest;

namespace UITestSample.UITest.Tests
{
    public class SimpleFlow : BaseTestFixture
    {
        public SimpleFlow(Platform platform) : base(platform)
        {
        }

        [Test]
        public void EnterSimplePageAndBack()
        {
            new MainPage().ClickBtnSample();
            new SimplePage().Back();
        }
    }
}