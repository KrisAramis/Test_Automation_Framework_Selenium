﻿using WebApplicationCore.Enums;
using OpenQA.Selenium;
 

namespace WebApplicationCore.Browser
{
    public static class DriverFactory
    {
        public static IWebDriver GetWebDriver(BrowserType browser)
        {
            IWebDriver createdWebDriver;
            switch (browser)
            {
                case BrowserType.Chrome:
                    createdWebDriver = new ChromeBrowser().GetDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser));
            }

            return createdWebDriver;
        }
    }
}
