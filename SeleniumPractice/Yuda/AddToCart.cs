
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
        //public string Backpack = "add-to-cart-sauce-labs-backpack";
        //public string BikeLight = "add-to-cart-sauce-labs-bike-light";
        //public string BoltTShirt = "add-to-cart-sauce-labs-bolt-t-shirt";

        [OneTimeSetUp]
        public void LoadDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            IWebElement Username = driver.FindElement(By.Id("user-name"));
            IWebElement Password = driver.FindElement(By.Id("password"));
            IWebElement LoginButton = driver.FindElement(By.Id("login-button"));

            Username.SendKeys("problem_user");
            Password.SendKeys("secret_sauce");
            LoginButton.Click();
        }

        //[Test]
        //public void LoginProblemUser()
        //{
        //    IWebElement Username = driver.FindElement(By.Id("user-name"));
        //    IWebElement Password = driver.FindElement(By.Id("password"));
        //    IWebElement LoginButton = driver.FindElement(By.Id("login-button"));

        //    Username.SendKeys("problem_user");
        //    Password.SendKeys("secret_sauce");
        //    LoginButton.Click();
        //}


        //Cart1 item: Sauce Labs Backpack
        //Cart2 item: Sauce Labs Bike Light
        //Cart3 item: Sauce Labs Bolt T-Shirt
        //Item names are in div class inventory_item_name
        //string addToCart = "add-to-cart-";
        //string Backpack = addToCart + "sauce-labs-backpack";
        //string BikeLight = addToCart + "sauce-labs-bike-light";
        //string BoltTShirt = addToCart + "sauce-labs-bolt-t-shirt";

    
       
        
        [TestCase("add-to-cart-sauce-labs-backpack")]
        [TestCase("add-to-cart-sauce-labs-bike-light")]
        [TestCase("add-to-cart-sauce-labs-bolt-t-shirt")]
        public void Cart(string ItemName)
        {
            //Less repetitive test case method:
            //string a = "add-tocart";
            //string b = a + ItemName;


            IWebElement ItemToBuy = driver.FindElement(By.Id(ItemName));
            ItemToBuy.Click();
            
        a

        [OneTimeTearDown]
        public void UnloadDriver()
        {
            driver.Quit();
        }
    }
}
