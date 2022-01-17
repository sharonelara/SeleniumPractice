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
    class MyAnswer7
    {
        [Test]
        public void UrlTitleCompare()
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Position = new System.Drawing.Point(0, 0);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://imdb.com");
            driver.Navigate().Refresh();
            string Url = driver.Url;
            string Title = driver.Title;
            string ExpUrl = "http://imdb.com";
            string ExpTitle = "IMDB";

            Console.WriteLine("Actual URL is: " + driver.Url);
            Console.WriteLine("Expected URL is: " + ExpUrl);
            Console.WriteLine("Actual Title is: " + driver.Title);
            Console.WriteLine("Expected Title is: " + ExpTitle);

            if (Url.Equals(ExpUrl))
                Console.WriteLine("Actual and expected URLs match - " + Url);
            else
                Console.WriteLine("Actual and expected URLs DO NOT match");

            if (Title.Equals(ExpTitle))
                Console.WriteLine("Actual and expected titles match - " + Title);
            else
                Console.WriteLine("Actual and expected titles DO NOT match");

            driver.Quit();
        }
    }
}
