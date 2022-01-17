using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumPractice.Examples

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
