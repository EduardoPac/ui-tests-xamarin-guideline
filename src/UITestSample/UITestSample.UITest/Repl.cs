using NUnit.Framework;
using Xamarin.UITest;

namespace UITestSample.UITest
{
    public class Repl : BaseTestFixture
    {
        public Repl(Platform platform) : base(platform)
        {
        }
        
        [Test]
        public void InitRepl() => App.Repl();
    }
}