using NUnit.Framework;
using UITestSample.UITest.Pages;
using Xamarin.UITest;

namespace UITestSample.UITest.Tests
{
    public class ReturnFlow : BaseTestFixture
    {
        public ReturnFlow(Platform platform) : base(platform)
        {
        }

        [Test]
        public void EnterReturnPageAndReturnNative()
        {
            new MainPage().ClickBtnReturn();
            new ReturnPage().Back();
        }

        [Test]
        public void EnterReturnPageAndReturnByButton()
        {
            new MainPage().ClickBtnReturn();
            new ReturnPage().BackButton();
        }
    }
}