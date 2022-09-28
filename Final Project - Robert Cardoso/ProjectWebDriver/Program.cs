using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using FinalProjectRobertCardoso.Utilities;
using FinalProjectRobertCardoso.POMPages;

namespace FinalProjectRobertCardoso.ProjectWebDriver
{
   
    internal class Program : BaseTest
    {
        [Test]
        public void WebDriverTest()
        {
            Console.WriteLine("Starting Test."); //Test begins at this point
          
            driver.Url = baseUrl + "/demo-site";//Navigate to page
            HomePagePOM home = new HomePagePOM(driver); //Instantiate class for Homepage
            home.GoLogin(); // Use page services to navigate to login page

            string username = Environment.GetEnvironmentVariable("username"); //Find username in RunSettings File
            string secret_password = Environment.GetEnvironmentVariable("password"); //Find password in RunSettings File

            LoginPagePOM login = new LoginPagePOM(driver); //Instantiate class for Login Page
            login.SetUsername(username); //Use Page services to fill username field
            login.SetPassword(secret_password); //Use Page services to fill password field
            login.GoLogin(); //Use page services to login

            driver.FindElement(By.LinkText("Shop")).Click(); //click on Shop link 
            
            string ItemPage = "#main > ul > li > a> img"; //Create String based on Locator
            driver.FindElement(By.CssSelector(ItemPage)).Click(); //Select ItemPage and click on it
            driver.FindElement(By.Name("add-to-cart")).Click(); //Select "Add to Cart" Element and click on it

            driver.FindElement(By.LinkText("Cart")).Click(); //Select shopping cart and click on it
            
            driver.FindElement(By.CssSelector("#coupon_code")).SendKeys("edgewords" + Keys.Enter); //Select coupon field, fill with coupon code and press enter
            Thread.Sleep(3000); //Wait 3 seconds, for discount to appear on page
            string coupon = "#post-5 > div > div > div.cart-collaterals > div > table > tbody > tr.cart-discount.coupon-edgewords > td > span"; //Create string based on locator
            string discount = driver.FindElement(By.CssSelector(coupon)).Text; //Create string based on text found in "coupon" locator
            Console.WriteLine(discount); //Write out "Discount" String to console.

            //Check to see if discount is at 10%
            if (discount == "£1.80")
            {
                TestContext.WriteLine("Discount at 10%");
            } else
            {
                TestContext.WriteLine("Discount not at 10%");
            }

            driver.FindElement(By.LinkText("My account")).Click(); //Select Account Link and click on it
            driver.FindElement(By.LinkText("Log out")).Click(); //Select Log Out Link and clicks on it

        }
        [Test]
        public void WebDriverTest2()
        {
            Console.WriteLine("Starting Test."); //Test begins at this point

            driver.Url = baseUrl + "/demo-site";//Navigate to page
            HomePagePOM home = new HomePagePOM(driver); //Instantiate class for Homepage
            home.GoLogin(); // Use Page services to navigate to login page

            string username = Environment.GetEnvironmentVariable("username"); //Find username in RunSettings File
            string secret_password = Environment.GetEnvironmentVariable("password"); //Find password in RunSettings File

            LoginPagePOM login = new LoginPagePOM(driver); //Instantiate class for Login Page
            login.SetUsername(username); //Use Page Services to fill username field
            login.SetPassword(secret_password); //Use Page Services to fill password field
            login.GoLogin(); //Use Page Services to log in

            driver.FindElement(By.LinkText("Shop")).Click(); //clicks on Shop link 
            string ItemPage = "#main > ul > li > a> img"; //Create string based on locator

            driver.FindElement(By.CssSelector(ItemPage)).Click();//Select ItemPage and click on it
            driver.FindElement(By.Name("add-to-cart")).Click(); //Select "Add to Cart" Element and click on it
            driver.FindElement(By.LinkText("Cart")).Click(); //Select Shopping Cart and click on it
            driver.FindElement(By.LinkText("Checkout")).Click(); //Select Checkout Link and click on it

            //Find Billing Details in RunSettings file
            string firstName = Environment.GetEnvironmentVariable("firstname");
            string lastName = Environment.GetEnvironmentVariable("lastname");
            string address1 = Environment.GetEnvironmentVariable("address1");
            string city = Environment.GetEnvironmentVariable("city");
            string postcode = Environment.GetEnvironmentVariable("postcode");
            string phoneNumber = Environment.GetEnvironmentVariable("phonenumber");


            BillingPagePOM billing = new BillingPagePOM(driver); //Instantiate class for Billing Page
            //Fill out billing details using RunSettings file
            billing.SetFirstName(firstName);
            billing.SetLastName(lastName);
            billing.SetAddress1(address1);
            billing.SetCity(city);
            billing.SetPostcode(postcode);
            billing.SetPhoneNumber(phoneNumber);

            Thread.Sleep(3000); //Wait 3 seconds, for "Place order" link to appear
            driver.FindElement(By.CssSelector("#place_order")).Click(); //Select "Place order" link and click on it
            Thread.Sleep(3000); //Wait 3 seconds, for order number to appear
            string order = "li.woocommerce-order-overview__order.order > strong"; //Create string based on locator
            string OrderNumber = driver.FindElement(By.CssSelector(order)).Text; //Create string based on text found in order number locator
            Console.WriteLine(OrderNumber); //Writes out order number to console

            driver.FindElement(By.LinkText("My account")).Click(); //Select Account Link and click on it
            driver.FindElement(By.LinkText("Log out")).Click(); //Select Log Out Link and click on it
        }
    }   
}