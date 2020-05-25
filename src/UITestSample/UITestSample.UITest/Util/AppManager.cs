using System;
using Xamarin.UITest;

namespace UITestSample.UITest
{ 
    static class AppManager
    {
        const string ApkPath = "/Users/eduardopac/repos/ui-tests-xamarin-guideline/src/UITestSample/Binaries/com.companyname.UITestSample-Signed.apk";
        const string AppPath = "../../../Binaries/TaskyiOS.app";
        const string IpaBundleId = "com.companyname.UITestSample";

        static IApp _app;
        public static IApp App
        {
            get
            {
                if (_app == null)
                    throw new NullReferenceException("'AppManager.App' not set. Call 'AppManager.StartApp()' before trying to access it.");
                return _app;
            }
        }

        static Platform? _platform;
        public static Platform Platform
        {
            get
            {
                if (_platform == null)
                    throw new NullReferenceException("'AppManager.Platform' not set.");
                return _platform.Value;
            }

            set
            {
                _platform = value;
            }
        }

        public static void StartApp()
        {
            if (Platform == Platform.Android)
            {
                _app = ConfigureApp
                    .Android
                    // Used to run a .apk file:
                    .ApkFile(ApkPath)
                    .StartApp();
            }

            if (Platform == Platform.iOS)
            {
                _app = ConfigureApp
                    .iOS
                    // Used to run a .app file on an ios simulator:
                    .AppBundle(AppPath)
                    // Used to run a .ipa file on a physical ios device:
                    //.InstalledApp(ipaBundleId)
                    .StartApp();
            }
        }
    }
}
