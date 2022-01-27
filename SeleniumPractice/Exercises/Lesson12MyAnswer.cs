using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumPractice.Exercises
{
    [TestFixture]
    class Lesson12MyAnswer
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void StartSession()
        {
            driver = new ChromeDriver();
            //driver.Manage().Window.Position = new System.Drawing.Point(0, 0);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://selenium.dev");
        }

        [Test]
        public void BlogElement()
        {
            IList<IWebElement> LinkList = driver.FindElements(By.TagName("a"));
            int NumberLinks = LinkList.Count();

            Console.WriteLine("Number of links in page: " + NumberLinks);
            Console.WriteLine("List of links in page:");
            Console.WriteLine(LinkList);


        }

        [OneTimeTearDown]
        public void CloseSession()
        {
            driver.Quit();
        }
    }
}
