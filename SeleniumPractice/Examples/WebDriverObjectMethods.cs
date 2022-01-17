using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumPractice.Examples
{
    [TestFixture]
    class WebDriverObjectMethods
    {
        [Test]
        public void Test01()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https")
        }
    }
}
