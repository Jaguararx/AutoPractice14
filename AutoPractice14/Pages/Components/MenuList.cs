using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace AutoPractice14.Pages.Components
{
    public class MenuList
    {
        private IWebDriver _driver;
        public IWebElement Container;


        public MenuList(IWebDriver driver, IWebElement container)
        {
            _driver = driver;
            Container = container;
        }

        public List<MenuGroup> Group
        {
            get
            {
                var elements = Container.FindElements(By.XPath(".//ul/li[not(@style='display: none;')]")).ToList();

                var list = new List<MenuGroup>();
                elements.ForEach(p => list.Add(new MenuGroup(p)));

                return list;
            }
        }
    }
}
