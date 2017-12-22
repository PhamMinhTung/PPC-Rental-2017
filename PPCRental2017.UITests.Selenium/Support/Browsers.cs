using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;

namespace BookShop.UITests.Selenium.Support
{
    public static class Browsers
    {
        public static readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        private static IWebDriver _chrome;
        public static IWebDriver Chrome
        {
            get
            {
                if (_chrome == null) _chrome = new ChromeDriver();
                return _chrome;
            }
        }

        private static IWebDriver _firefox;
        public static IWebDriver Firefox
        {
            get
            {
                if (_firefox == null)
                {
                    _firefox = new FirefoxDriver();
                    _firefox.Manage().Timeouts().ImplicitWait = DefaultTimeout;
                }

                return _firefox;
            }
        }

        private static IWebDriver _ie;
        public static IWebDriver IE
        {
            get
            {
                if (_ie == null)
                {
                    _ie = new InternetExplorerDriver();
                    _ie.Manage().Timeouts().ImplicitWait = DefaultTimeout;
                }

                return _ie;
            }
        }

    }
}
