using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectRobertCardoso.POMPages
{
    internal class ItemPagePOM
    {
        IWebDriver driver;
        public ItemPagePOM(IWebDriver driver)
        {
            this.driver = driver;
        }


        //Locators
        IWebElement AddToCartButton => driver.FindElement(By.Name("add-to-cart"));


        public void AddToCart()
        {
            AddToCartButton.Click();   
        }

    }
}
