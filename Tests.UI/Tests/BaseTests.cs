
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace Tests.UI.Tests
{
    public abstract class BaseTests
    {
        public TestSettings settings { get; set; }
        public IWebDriver Driver { get; set; }

        [OneTimeSetUp]
        public void SetUpBeforeTestRun() {
            settings = new TestSettings();

            var configuration = new ConfigurationBuilder()
                                    .AddJsonFile("appsettings.json")
                                    .AddJsonFile("appsettings.development.json", optional: true)
                                    .Build();

            configuration.Bind(settings);

            var PathToDriver = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var options = new ChromeOptions();
            if (settings.Headless)
            {
                options.AddArgument("headless");
            }

            Driver = new ChromeDriver(PathToDriver, options);
            Driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void TearDownAfterTestRun() {
            Driver.Close();
            Driver.Quit();
        }
    }
}
