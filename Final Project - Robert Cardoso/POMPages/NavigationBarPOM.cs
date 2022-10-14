using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FinalProjectRobertCardoso.Utilities.HelpersStatic;
namespace FinalProjectRobertCardoso.POMPages
{
    internal class NavigationBarPOM
    {
        IWebDriver driver;
        public NavigationBarPOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement HomePage => driver.FindElement(By.LinkText("Home"));
        IWebElement Shop => driver.FindElement(By.LinkText("Shop"));
        IWebElement Cart => driver.FindElement(By.LinkText("Cart"));
        IWebElement Checkout => driver.FindElement(By.LinkText("Checkout"));
        
        IWebElement MyAccount => driver.FindElement(By.LinkText("My account"));
        IWebElement Blog => driver.FindElement(By.LinkText("Blog"));
        public void HomeLink()
        {
            WebDriverWait myWait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            myWait.Until(drv => drv.FindElement(By.LinkText("Home")).Displayed);
            HomePage.Click();
        }

        public void ShopLink()
        {
            WebDriverWait myWait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            myWait.Until(drv => drv.FindElement(By.LinkText("Shop")).Displayed);
            Shop.Click();
        }

        public void CartLink()
        {
            WebDriverWait myWait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            myWait.Until(drv => drv.FindElement(By.LinkText("Cart")).Displayed);
            Cart.Click();
        }

        public void CheckoutLink()
        {
            WebDriverWait myWait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            myWait.Until(drv => drv.FindElement(By.LinkText("Checkout")).Displayed);
            Checkout.Click();
        }

        public void MyAccountLink()
        {
            WaitForElmStatic(driver, 5, By.LinkText("My account"));
            //WebDriverWait myWait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            //myWait.Until(drv => MyAccount.Displayed);
            //Thread.Sleep(1000);
            MyAccount.Click();
        }

        public void BlogLink()
        {
            WebDriverWait myWait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            myWait.Until(drv => drv.FindElement(By.LinkText("Blog")).Displayed);
            Blog.Click();
        }
    }
}
