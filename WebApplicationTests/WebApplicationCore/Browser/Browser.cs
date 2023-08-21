using System;
using WebApplicationCore.Helper;
using WebApplicationUtilities.Logger;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace WebApplicationCore.Browser;

public class Browser
{
    private readonly IWebDriver _driver;

        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ScrollToElement(IWebElement element)
        {
            ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public void ScrollBy(int px)
        {
            ExecuteScript($"window.scrollBy(0, {px});");
        }

        public void Back()
        {
            Logger.Info("Navigate Back");
            _driver.Navigate().Back();
        }

        public string GetUrl()
        {
            return _driver.Url;
        }

        public void Maximize()
        {
            Logger.Info("Maximize Browser");
            _driver.Manage().Window.Maximize();
        }

        public void Refresh()
        {
            Logger.Info("Refresh page");
            _driver.Navigate().Refresh();
        }

        public void GotToUrl(string url)
        {
            Logger.Info($"Open url: {url}");
            _driver.Navigate().GoToUrl(url);
        }

        public void Close()
        {
            Logger.Info("Close current page");
            _driver.Close();
        }

        public void Quit()
        {
            Logger.Info("Quit Browser");
            try
            {
                _driver.Quit();
            }

            catch (Exception ex)
            {
                Logger.Info($"Unable to Quit the browser. Reason: {ex.Message}");
            }
        }

        public string Url
        {
            get => _driver.Url;
            set => _driver.Url = value;
        }

        #region Waiters

        public WebDriverWait Waiters() => new WebDriverWait(_driver, TestSettings.WebDriverTimeOut);

        public Actions Action => new Actions(_driver);

        #endregion

        public IWebElement FindElement(By locator)
        {
            return _driver.FindElement(locator);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return _driver.FindElements(by);
        }

        public object ExecuteScript(string script, params object[] args)
        {
            try
            {
                return ((IJavaScriptExecutor)_driver).ExecuteScript(script, args);
            }
            catch (WebDriverTimeoutException e)
            {
                // If timeout or any errors
                Logger.Info($"Error: Timeout Exception thrown while running JS Script:{e.Message}-{e.StackTrace}");
            }
            return null;
        }
    }

