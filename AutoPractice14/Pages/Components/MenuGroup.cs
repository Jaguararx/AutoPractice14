using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace AutoPractice14.Pages.Components
{
    public class MenuGroup
    {
        public IWebElement Container;

        public MenuGroup(IWebElement container)
        {
            Container = container;
        }

        public List<IWebElement> Links
            => Container.FindElements(By.XPath(".//li/a")).ToList();
    }
}
