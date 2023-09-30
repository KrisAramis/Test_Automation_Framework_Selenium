using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using AventStack.ExtentReports;
using System.Drawing.Imaging;
using System.Drawing;
using OpenQA.Selenium;
using WebApplicationCore.Helper;

namespace WebApplicationCore.Screenshoter
{
    internal static class ScreenshotTaker
    {
        internal static void TakesScreenshot(IWebDriver driver, string testName, string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string screenFileName =
                $"{testName} {DateTime.Now:dd, MM}.{ImageFormat.Jpeg.ToString().ToLowerInvariant()}";

            string screenPath = Path.Combine(TestSettings.ScreenShotPath, screenFileName);
            using (Image screenshot =
                   Image.FromStream(new MemoryStream(((ITakesScreenshot)driver).GetScreenshot().AsByteArray)))
            {
                screenshot.Save(screenPath);
            }
        }
    }
}
