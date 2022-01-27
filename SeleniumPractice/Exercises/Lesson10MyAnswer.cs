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
        IWebDriver driver;

        [OneTimeSetUp]
        public void StartSession()
        {
            driver = new ChromeDriver();
            //driver.Manage().Window.Position = new System.Drawing.Point(0, 0);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://imdb.com");
            driver.Navigate().Refresh();
        }

        [Test]
        public void UrlCompare()
        {
            string Url = driver.Url;
            string ExpUrl = "http://imdb.com";

            Console.WriteLine("Actual URL is: " + driver.Url);
            Console.WriteLine("Expected URL is: " + ExpUrl);
         

            if (Url.Equals(ExpUrl))
                Console.WriteLine("Actual and expected URLs match - " + Url);
            else
                Console.WriteLine("Actual and expected URLs DO NOT match");

        }

        [Test]
        public void TitleCompare()
        {
            string Title = driver.Title;
            string ExpTitle = "IMDB";

            Console.WriteLine("Actual Title is: " + driver.Title);
            Console.WriteLine("Expected Title is: " + ExpTitle);

            if (Title.Equals(ExpTitle))
                Console.WriteLine("Actual and expected titles match - " + Title);
            else
                Console.WriteLine("Actual and expected titles DO NOT match");
            
        }

        [OneTimeTearDown]
        public void CloseSession() 
        {
            driver.Quit();
        }
    }
}
