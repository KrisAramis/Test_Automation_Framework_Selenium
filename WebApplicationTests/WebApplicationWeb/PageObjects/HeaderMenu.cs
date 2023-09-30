using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebApplicationWeb;

public class HeaderMenu
{
    private WebDriver _driver;

    public IWebElement careers => _driver.FindElement(By.XPath("//*[@href='/careers' and contains(@class, 'top-navigation__item-link')]"));

}