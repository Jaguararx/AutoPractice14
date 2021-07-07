using AutoPractice14.Pages;
using AutoPractice14.Pages.Components.Popup;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace Tests.UI.Tests
{
    public class WebDriverTests : BaseTests
    {

        public Main MainPage { get; set; }
        public Popup PopupPage { get; set; }

        [Test]
        [Category("UI")]
        public void FirstUITest()
        {
            Driver.Navigate().GoToUrl(settings.HomeURL);
            PopupPage = PageFactory.InitElements<Popup>(Driver);

            PopupPage.WaitForPopup();
            PopupPage.CloseButton.Click();

            MainPage = PageFactory.InitElements<Main>(Driver);
            Driver.ScrollIntoView(MainPage.MenuList.Container);
            MainPage.MenuList.Group[0].Container.Click();
            MainPage.MenuList.Group[0].Links[0].Click();
            MainPage.MenuList.Group[3].Container.Click();
            MainPage.MenuList.Group[3].Links[0].Click();

        }
    }
}
