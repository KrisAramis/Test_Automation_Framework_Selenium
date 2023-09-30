using AventStack.ExtentReports;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace WebApplicationCore.Screenshoter
{
    public class ScreenshoterForReport
    {
        public MediaEntityModelProvider CaptureScreenshotAndReturnModel(IWebDriver driver, string testName,
            string folderPath)
        {
            ScreenshotTaker.TakesScreenshot(driver, testName, folderPath);
            return MediaEntityBuilder.CreateScreenCaptureFromPath(folderPath).Build();
        }
    }
}