using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebApplicationCore.Browser;
using WebApplicationCore.Helper;
using WebApplicationWeb;

namespace WebApplicationTests;

public class LandingPageTests:BaseTest
{
    private EpamLandingPage _epamLandingPage;

    [SetUp]
    public void SetUp()
    {
        _epamLandingPage = new EpamLandingPage();
    }
    
    [Test]
    public void VerifyLandingPageIsLoading()
    {
        Assert.IsTrue(_epamLandingPage.Title.Displayed,"error");
    }
}