using OpenQA.Selenium;

namespace Tests.UI
{
    public static class IWebDriverExtention
    {
        public static void ScrollIntoView(this IWebDriver driver, IWebElement webElement)
        {
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView()", webElement);
        }
    }
}
