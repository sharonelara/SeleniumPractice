using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace Exersices
{
    [TestFixture]
    public class Ex08_LocatorsBasic
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void LoadDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.seleniumhq.org/");
        }

        [Test]
        public void LocatorsBasic()
        {
            Console.WriteLine(driver.FindElement(By.Id("menu_about")));
            Console.WriteLine(driver.FindElement(By.LinkText("About")));
            Console.WriteLine(driver.FindElement(By.PartialLinkText("About")));
            Console.WriteLine(driver.FindElement(By.TagName("li")));
            Console.WriteLine(driver.FindElements(By.TagName("a"))[7]);

            IList<IWebElement> links = driver.FindElements(By.TagName("a"));
            IList<IWebElement> Seleniumlinks = driver.FindElements(By.PartialLinkText("Selenium"));
            IList<IWebElement> seleniumlinks = driver.FindElements(By.PartialLinkText("selenium"));
            Console.WriteLine("Number of total links in page: " + links.Count());
            Console.WriteLine("Number of links in page with word: Selenium is: " + Seleniumlinks.Count());
            Console.WriteLine("Number of links in page with word: selenium is: " + seleniumlinks.Count());
        }

        [OneTimeTearDown]
        public void UnloadDriver()
        {
            driver.Quit();
        }
    }
}
