using NUnit.Framework;
using Xamarin.UITest;

namespace UITestSample.UITest
{
    public class ReplInit : BaseTestFixture
    {
        public ReplInit(Platform platform) : base(platform)
        {
        }
        
        [Test]
        public void Repl() => App.Repl();
    }
}