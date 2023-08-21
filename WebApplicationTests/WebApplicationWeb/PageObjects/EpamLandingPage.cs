using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebApplicationWeb;

public class EpamLandingPage
{
    private WebDriver _driver;

    public IWebElement SearchButton => _driver.FindElement(By.XPath(("//*[@class='search-icon dark-iconheader-search__search-icon']")));
}