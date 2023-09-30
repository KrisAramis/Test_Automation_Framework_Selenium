using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebApplicationCore.BasePage;
using WebApplicationCore.Browser;

namespace WebApplicationWeb;

public class EpamLandingPage:BasePage
{
    public override string Url => "https://www.epam.com/";
    public IWebElement Title =BrowserFactory.Browser.FindElement(By.TagName("header"));
    public IWebElement SearchButton => BrowserFactory.Browser.FindElement(By.XPath(("//*[@class='search-icon dark-iconheader-search__search-icon']")));
}