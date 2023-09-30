using NUnit;
using OpenQA.Selenium;
using WebApplicationCore.Browser;
using WebApplicationCore.Helper;
using WebApplicationUtilities.Logger;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using WebApplicationCore.Utils;
using Microsoft.Extensions.Logging;
using NUnit.Framework.Interfaces;
using WebApplicationCore.Screenshoter;

namespace WebApplicationTests;

public class BaseTest
{
    public TestContext TestContext { get; set; }

    public ScreenshoterForReport _screenshotReport;
    public ExtentReports extent;
    public ExtentTest test;
    
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        Logger.InitLogger(TestContext.CurrentContext.Test.Name, TestContext.CurrentContext.TestDirectory);
    }
    
    [SetUp]
    public void BrowserSetup()
    {
    Logger.Info("Test begins");
    BrowserFactory.Browser.GotToUrl(TestSettings.ApplicationUrl);
    BrowserFactory.Browser.Maximize();
    Waiters.WaitForPageLoad();

      string workingDirectory = Environment.CurrentDirectory;
      string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
      String reportPath =projectDirectory + "//index.html";
      var htmlReporter = new  ExtentHtmlReporter(reportPath);
      extent = new ExtentReports();
        extent.AttachReporter(htmlReporter);
        extent.AddSystemInfo("Environment", "Prod");
        extent.AddSystemInfo("Username", "Kristina Kulich");
    }
    
    [TearDown]
    public void CloseBrowser()
    {
        var status = TestContext.CurrentContext.Result.Outcome.Status;
        var stackTrace = TestContext.CurrentContext.Result.StackTrace;
        DateTime time = DateTime.Now;
        String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
        if (status == TestStatus.Failed)
        {
            BrowserFactory.Browser.SaveScreenshot(TestContext.CurrentContext.Test.MethodName, Path.Combine(TestContext.CurrentContext.TestDirectory, TestSettings.ScreenShotPath));
            test.Log(Status.Fail,"test failed with logtrace"+ stackTrace);
        }
        Logger.Info("Test finish");
        BrowserFactory.Browser.Close();
        BrowserFactory.Browser.Quit();
    }
}