using OpenQA.Selenium;

namespace WebApplicationCore.Browser
{
    public interface IDriverFactory
    {
        public IWebDriver GetDriver();
    }
}
