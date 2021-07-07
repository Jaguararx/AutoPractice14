
using OpenQA.Selenium;

namespace AutoPractice14.Pages
{
    public abstract class PageObjectBase
    {
        public IWebDriver Driver { get; set; }

        protected PageObjectBase(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
