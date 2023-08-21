using WebApplicationCore.Browser;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace WebApplicationCore.BasePage
{
    public abstract class BasePage
    {
        public abstract string Url { get; }

        //public WebElement AcceptAllCookiesButton = new WebElement()
          //  .FindElement(By.XPath("//*[@id = 'onetrust-accept-btn-handler']"));

        public bool IsOpened()
        {
            return BrowserFactory.Browser.GetUrl().Equals(Url);
        }

        public void AcceptAllCookies()
        {
           // AcceptAllCookiesButton.Click();
        }

        public IWebElement FindElement(By by)
        {
            return BrowserFactory.Browser.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return BrowserFactory.Browser.FindElements(by);
        }

    }
}
