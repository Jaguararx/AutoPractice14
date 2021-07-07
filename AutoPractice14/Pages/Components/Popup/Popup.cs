using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace AutoPractice14.Pages.Components.Popup
{
    public class Popup : PageObjectBase
    {
        public Popup(IWebDriver driver): base(driver) { }

        [FindsBy(How = How.Id, Using = "image-darkener")]
        public IWebElement ContainerLocator { get; set; }

        [FindsBy(How = How.Id, Using = "at-cv-lightbox-close")]
        public IWebElement CloseButton { get; set; }

        public void WaitForPopup()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10))
            {
                PollingInterval = TimeSpan.FromMilliseconds(300),
            };

            wait.Until(ExpectedConditions.ElementToBeClickable(ContainerLocator));
        }
    }
}
