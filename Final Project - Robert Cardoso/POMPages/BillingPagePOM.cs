using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectRobertCardoso.POMPages
{
    internal class BillingPagePOM
    {
        IWebDriver driver;
        public BillingPagePOM(IWebDriver driver)
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



        public BillingPagePOM SetFirstName(string firstName)
        {
            BillingFirstName.Clear();
            BillingFirstName.SendKeys(firstName);
            return this;
        }
        public BillingPagePOM SetLastName(string lastName)
        {
            BillingLastName.Clear();
            BillingLastName.SendKeys(lastName);
            return this;
        }
        public BillingPagePOM SetAddress1(string address1)
        {
            BillingAddress1.Clear();
            BillingAddress1.SendKeys(address1);
            return this;
        }
        public BillingPagePOM SetCity(string city)
        {
            BillingCity.Clear();
            BillingCity.SendKeys(city);
            return this;
        }
        public BillingPagePOM SetPostcode(string postcode)
        {
            BillingPostcode.Clear();
            BillingPostcode.SendKeys(postcode);
            return this;
        }
        public BillingPagePOM SetPhoneNumber(string phoneNumber)
        {
            BillingPhone.Clear();
            BillingPhone.SendKeys(phoneNumber);
            return this;
        }

    }
}
