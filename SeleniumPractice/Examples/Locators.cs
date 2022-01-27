using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// NOTES

// Locator Types:
// Id, Name, XPath, CssSelector, LinkText, PartialLinkText, ClassName, TagName
// If there are multiples, first one is selected by default
// driver.FindElement(By.LocatorType(LocatorTag));

// EXAMPLE
// IWebElement image = driver.FindElement(By.TagName("img"));

// FOR MULTIPLE:
// IList<IWebElement> img = driver.FindElements(By.TagName("img"));

// XPATH
// driver.FindElement(By.XPath("//div[@size='13']"));
// driver.FindElement(By.XPath("//div[starts-with(@id,'btn')]"));
// driver.FindElement(By.XPath("//div[ends-with(@id,'btn')]"));
// driver.FindElement(By.XPath("//div[contains(@id,'btn')]"));
// driver.FindElement(By.XPath("//*[contains(@id,'btn')]"));
// driver.FindElement(By.XPath("//div[text()='tes']"));

// CssSelector
// driver.FindElement(By.CssSelector("input[key='13']"));
// driver.FindElement(By.CssSelector("input[key^='13']")); -- starts with equivalent
// driver.FindElement(By.CssSelector("input[key$='13']")); -- ends with equivalent
// driver.FindElement(By.CssSelector("input[key*='13']")); -- contains equivalent
// driver.FindElement(By.CssSelector("input[key='13'][type='xx']")); -- and equivalent

namespace SeleniumPractice.Examples
{
    class Locators
    {

    }
}
