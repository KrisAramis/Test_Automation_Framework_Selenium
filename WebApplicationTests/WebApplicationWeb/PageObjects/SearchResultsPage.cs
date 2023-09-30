using OpenQA.Selenium;
using WebApplicationCore.Browser;

namespace WebApplicationWeb;

public class SearchResultsPage
{
    public List <IWebElement> SearchResults => BrowserFactory.Browser.FindElements(By.TagName("article")).ToList();
}