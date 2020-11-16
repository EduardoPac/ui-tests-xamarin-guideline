using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITestSample.UITest.Pages
{
    public class ListPage : BasePage
    {
        readonly Query _collectionView;
        readonly Query _btnOk;

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("list_page"),
            iOS = x => x.Marked("list_page")
        };

        public ListPage()
        {
            if (OnAndroid)
            {
                _collectionView = x => x.Marked("collection_view");
                _btnOk = x => x.Marked("Ok");
            }

            if (OniOS)
            {
            }
        }

        public ListPage ClickToItem(int index)
        {
            App.WaitForElement(_collectionView);

            Query item = x => x.Marked("collection_view").Child(index);
            App.WaitForElement(item);

            App.Tap(item);

            return this;
        }

        public ListPage ClickAlertOk()
        {
            App.WaitForElement(_btnOk);
            App.Tap(_btnOk);

            return this;
        }
    }
}