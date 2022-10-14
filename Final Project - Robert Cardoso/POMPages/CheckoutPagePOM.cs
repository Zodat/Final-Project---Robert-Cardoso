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
    public class CheckoutPagePOM
    {
        IWebDriver driver;
        public CheckoutPagePOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators
        IWebElement BillingFirstName => driver.FindElement(By.CssSelector("#billing_first_name"));
        IWebElement BillingLastName => driver.FindElement(By.CssSelector("#billing_last_name"));
        IWebElement BillingAddress1 => driver.FindElement(By.CssSelector("#billing_address_1"));
        IWebElement BillingCity => driver.FindElement(By.CssSelector("#billing_city"));
        IWebElement BillingPostcode => driver.FindElement(By.CssSelector("#billing_postcode"));
        IWebElement BillingPhone => driver.FindElement(By.CssSelector("#billing_phone"));

        public string order = "li.woocommerce-order-overview__order.order > strong"; //Create string based on locator
        public IWebElement OrderNumber => driver.FindElement(By.CssSelector(order));//.Text; //Create string based on text found in order number locator

        //Service Methods
        public CheckoutPagePOM SetFirstName(string firstName)
        {
            BillingFirstName.Clear();
            BillingFirstName.SendKeys(firstName);
            return this;
        }
        public CheckoutPagePOM SetLastName(string lastName)
        {
            BillingLastName.Clear();
            BillingLastName.SendKeys(lastName);
            return this;
        }
        public CheckoutPagePOM SetAddress1(string address1)
        {
            BillingAddress1.Clear();
            BillingAddress1.SendKeys(address1);
            return this;
        }
        public CheckoutPagePOM SetCity(string city)
        {
            BillingCity.Clear();
            BillingCity.SendKeys(city);
            return this;
        }
        public CheckoutPagePOM SetPostcode(string postcode)
        {
            BillingPostcode.Clear();
            BillingPostcode.SendKeys(postcode);
            return this;
        }
        public CheckoutPagePOM SetPhoneNumber(string phoneNumber)
        {
            BillingPhone.Clear();
            BillingPhone.SendKeys(phoneNumber);
            return this;
        }

        public void placeOrder()
        {
            //WaitForElmStatic(driver, 3, By.CssSelector("#place_order"));
            //WebDriverWait myWait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            //myWait.Until(drv => drv.FindElement(By.CssSelector("#place_order")).Displayed);
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("#place_order")).Click();
            //WebDriverWait myWait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            Thread.Sleep(3000);
        }

        public void getOrderNumber()
        {
            WebDriverWait myWait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            myWait.Until(drv => (OrderNumber.Text));
            Console.WriteLine(OrderNumber.Text); //Writes out order number to console
        }
    }
}
