using AutoPractice14.Pages.Components;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoPractice14.Pages
{
    public class Main : PageObjectBase
    {
        public Main(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, MenuList);
        }

        public MenuList MenuList
            => new MenuList(Driver, Driver.FindElement(By.Id("treemenu")));
    }
}
