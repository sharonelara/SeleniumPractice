using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace SeleniumPractice.Yuda
{
    class Item
    {
        public string ItemName { get; set; }

        public string AddToCart { get; set; }

        public Item()
        {
            ItemName = " ";
            AddToCart = " ";
            
        }

    }
}
