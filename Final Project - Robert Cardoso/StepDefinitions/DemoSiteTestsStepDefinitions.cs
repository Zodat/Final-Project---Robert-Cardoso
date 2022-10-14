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
using static FinalProjectRobertCardoso.Utilities.HelpersStatic;
using TechTalk.SpecFlow;
using static FinalProjectRobertCardoso.Utilities.BaseTest;
using NUnit.Framework;

namespace FinalProjectRobertCardoso.StepDefinitions
{
    [Binding]
    public class DemoSiteTestStepDefinitions
    {

        [Given(@"I am on the demo site")]
        public void GivenIAmOnTheDemoSite()
        {
            TestContext.WriteLine("Starting Test");
            Console.WriteLine("Starting Test."); //Test begins at this point
            driver.Url = "https://www.edgewordstraining.co.uk" + "/demo-site";//Navigate to page;
        }

        [Given(@"I am logged in using a valid (.*) and (.*)")]
        public void GivenILogInUsingAValidUsernameAndPassword(string username, string secret_password)
        {
            NavigationBarPOM navigation = new NavigationBarPOM(driver);
            navigation.MyAccountLink(); // Use page services to navigate to login page
            MyAccountPagePOM account = new MyAccountPagePOM(driver);
            account.SetUsername(username); //Use Page services to fill username field
            account.SetPassword(secret_password); //Use Page services to fill password field
            account.GoLogin(); //Use page services to login
            string accountContent = driver.FindElement(By.CssSelector(".woocommerce-MyAccount-content")).Text;
            Assert.That(accountContent, Does.Contain("Log out"), "We are not logged in");
        }


        [When(@"I add an item to the basket")]
        public void WhenAddAnItemToTheBasket()
        {
            NavigationBarPOM navigation = new NavigationBarPOM(driver);
            ShopPagePOM shopping = new ShopPagePOM(driver);
            ItemPagePOM item = new ItemPagePOM(driver);

            navigation.ShopLink();
            shopping.Item2();
            item.AddToCart();
        }

        [When(@"I apply a (.*)")]
        public void WhenIApplyAEdgewords(string coupon)
        {
            NavigationBarPOM navigation = new NavigationBarPOM(driver);
            CartPagePOM cart = new CartPagePOM(driver);

            navigation.CartLink();
            cart.FillCoupon(coupon);
            cart.ApplyCoupon();
        }

        [Then(@"a discount will be applied")]
        public void ThenADiscountWillBeApplied()
        {
            NavigationBarPOM navigation = new NavigationBarPOM(driver);
            CartPagePOM cart = new CartPagePOM(driver);
            MyAccountPagePOM account = new MyAccountPagePOM(driver);

            WebDriverWait myWait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            myWait.Until(drv => cart.discount.Displayed);

            //WaitForElmStatic(driver, 3, cart.discount);

            Console.WriteLine(cart.discount.Text); //Write out "Discount" String to console.

            /*//Check to see if discount is at 10%
            if (discount == "£1.80")
            {
                TestContext.WriteLine("Discount at 10%");
            }
            else
            {
                TestContext.WriteLine("Discount not at 10%");
            }
            */

            navigation.MyAccountLink();

            account.GoLogout();
        }

        [When(@"I enter my details")]
        public void WhenIEnterMyDetails()
        {
            NavigationBarPOM navigation = new NavigationBarPOM(driver);
            CheckoutPagePOM checkout = new CheckoutPagePOM(driver);

            navigation.CheckoutLink();

            //Find Billing Details in RunSettings file
            string firstName = Environment.GetEnvironmentVariable("firstname");
            string lastName = Environment.GetEnvironmentVariable("lastname");
            string address1 = Environment.GetEnvironmentVariable("address1");
            string city = Environment.GetEnvironmentVariable("city");
            string postcode = Environment.GetEnvironmentVariable("postcode");
            string phoneNumber = Environment.GetEnvironmentVariable("phonenumber");

            //Fill out billing details using RunSettings file
            checkout.SetFirstName(firstName);
            checkout.SetLastName(lastName);
            checkout.SetAddress1(address1);
            checkout.SetCity(city);
            checkout.SetPostcode(postcode);
            checkout.SetPhoneNumber(phoneNumber);
        }

        [Then(@"I can place an order")]
        public void ThenICanPlaceAnOrder()
        {
            NavigationBarPOM navigation = new NavigationBarPOM(driver);
            CheckoutPagePOM checkout = new CheckoutPagePOM(driver);
            MyAccountPagePOM account = new MyAccountPagePOM(driver);
            //checkout.getOrderNumber();

            //WebDriverWait myWait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            //myWait.Until(drv => drv.FindElement(By.CssSelector("#place_order")).Displayed);

            //Thread.Sleep(3000); //Wait 3 seconds, for "Place order" link to appear
            //driver.FindElement(By.CssSelector("#place_order")).Click(); //Select "Place order" link and click on it
            //Thread.Sleep(3000); //Wait 3 seconds, for order number to appear
            checkout.placeOrder();
            //Console.WriteLine(checkout.OrderNumber.Text); //Writes out order number to console

            //WebDriverWait myWait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            //myWait.Until(drv => drv.FindElement(By.LinkText("My account")).Displayed);
            navigation.MyAccountLink();

            account.GoLogout();
        }
    }
}









        /*[Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            
            
        }
        [When(@"I enter a valid  and (.*)")]
        public void WhenIEnterAValidUsernameAndPassword()
        {
            
        }
        
        [Then(@"I will be logged in")]
        public void ThenIWillBeLoggedIn()
        {
            MyAccountPagePOM account = new MyAccountPagePOM(driver);
            account.GoLogin(); //Use page services to login
            //string accountContent = driver.FindElement(By.CssSelector("#post-7 > div > div > div"))
            string accountContent = driver.FindElement(By.CssSelector(".woocommerce-MyAccount-content")).Text;
            Assert.That(accountContent, Does.Contain("Log out"), "We are not logged in");
        }*/
    


/* MyAccountPagePOM account = new MyAccountPagePOM(driver);
            string username = Environment.GetEnvironmentVariable("username"); //Find username in RunSettings File
            string secret_password = Environment.GetEnvironmentVariable("password"); //Find password in RunSettings File
            account.SetUsername(username); //Use Page services to fill username field
            account.SetPassword(secret_password); //Use Page services to fill password field
            account.GoLogin(); //Use page services to login*/
