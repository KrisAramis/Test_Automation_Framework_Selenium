using OpenQA.Selenium;

namespace WebApplicationWeb;

public class SearchResultsPage
{
    private IWebDriver _driver;
    public List <IWebElement> SearchResults => _driver.FindElements(By.TagName("article")).ToList();
}