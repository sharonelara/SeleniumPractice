using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumPractice

{
    [TestFixture]
    public class OpenBrowser
    {
        [Test]
        public void OpenChrome()
        {
            IWebDriver driver = new ChromeDriver();
        }
    }
}
