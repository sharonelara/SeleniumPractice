
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
    public class AddToCart
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void LoadDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Test]
        public void LoginProblemUser()
        {
            IWebElement Username = driver.FindElement(By.Id("user-name"));
            IWebElement Password = driver.FindElement(By.Id("password"));
            IWebElement LoginButton = driver.FindElement(By.Id("login-button"));

            Username.SendKeys("problem_user");
            Password.SendKeys("secret_sauce");
            LoginButton.Click();
        }


        //Cart1 item: Sauce Labs Backpack
        //Cart2 item: Sauce Labs Bike Light
        //Cart3 item: Sauce Labs Bolt T-Shirt
        //Item names are in div class inventory_item_name

       
        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]




        [Test]
        public void Cart()
        {
            //I want to identify xpath by id text that changes based on item:
            string addToCart = "add-to-cart-";
            string Backpack = addToCart + "sauce-labs-backpack";
            string BikeLight = addToCart + "sauce-labs-bike-light";
            string BoltTShirt = addToCart + "sauce-labs-bolt-t-shirt";

            //Test that string is correct for xpath id
            //Console.WriteLine(Backpack);
            IWebElement ItemToBuy = driver.FindElement(By.Id(BoltTShirt));
            
        }

        [OneTimeTearDown]
        public void UnloadDriver()
        {
            driver.Quit();
        }
    }
}
