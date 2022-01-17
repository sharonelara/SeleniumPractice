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
        public void ChromeNavigate()
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Position = new System.Drawing.Point(0, 0);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://google.com");
            Console.WriteLine("URL is: " + driver.Url);
            Console.WriteLine("Title is: " + driver.Title);
            driver.Quit();

            //LESSON NOTES

            //Returns URL of page currently loaded
            //string url = driver.Url;

            //Returns title of page currently loaded
            //string title = driver.Title;

            //Returns page source of page currently loaded
            //string source = driver.PageSource;

            //TO CLOSE TAB
            //driver.Close();

            //TO CLOSE BROWSER
            //driver.Quit();

            //driver.Navigate() OPTIONS
            //driver.Navigate().Back();
            //driver.Navigate().Forward();
            //driver.Navigate().Refresh();

            //MAXIMIZE WINDOW
            //driver.Manage().Window.Maximize();
        }
    }
}
