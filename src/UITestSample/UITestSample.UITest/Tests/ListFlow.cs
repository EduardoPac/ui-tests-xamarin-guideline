using NUnit.Framework;
using UITestSample.UITest.Pages;
using Xamarin.UITest;

namespace UITestSample.UITest.Tests
{
    public class ListFlow : BaseTestFixture
    {
        public ListFlow(Platform platform) : base(platform)
        {
        }

        [Test]
        public void EnterListPageClickListItemAndReturn()
        {
            new MainPage()
                .ClickBtnList();
            
            new ListPage()
                .ClickToItem(0).ClickAlertOk()
                .ClickToItem(1).ClickAlertOk()
                .ClickToItem(2).ClickAlertOk()
                .ClickToItem(3).ClickAlertOk()
                .ClickToItem(4).ClickAlertOk()
                .ClickToItem(5).ClickAlertOk()
                .Back();
        }
    }
}