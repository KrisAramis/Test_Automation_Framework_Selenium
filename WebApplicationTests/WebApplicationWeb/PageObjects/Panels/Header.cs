using OpenQA.Selenium;
using WebApplicationCore.Browser;

namespace WebApplicationWeb.Panels;

public class Header
{
   public IWebElement careers = BrowserFactory.Browser.FindElement(By.XPath("//*[@href='/careers' and contains(@class, 'top-navigation__item-link')]"));
}