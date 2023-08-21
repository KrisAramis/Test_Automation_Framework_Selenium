using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebApplicationCore.Browser;
using WebApplicationWeb.Helper;
using WebApplicationWeb;

namespace WebApplicationTests;

public class Tests
{

    [SetUp]
    public void BrowserSetup()
    {
        BrowserFactory.Browser.GotToUrl(TestSettings.ApplicationUrl);
        BrowserFactory.Browser.Maximize();
    }
    
    [Test]
    public void VerifyLandingPageIsLoading()
    {
        //to be added
    }
    
    [TearDown]
    public void TearDown()
    {
        BrowserFactory.Browser.Close();
        BrowserFactory.Browser.Quit();
    } 
}