using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FinalProjectRobertCardoso.Utilities.HelpersStatic;

namespace FinalProjectRobertCardoso.POMPages
{
    public class CartPagePOM
    {
        IWebDriver driver;
        public CartPagePOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators
        string clear = ".remove";
        IWebElement Remove => driver.FindElement(By.CssSelector(clear));

        IWebElement CouponField => driver.FindElement(By.CssSelector("#coupon_code"));

        public string SubtotalValue = "#post-5 > div > div > div.cart-collaterals > div > table > tbody > tr.cart-subtotal > td > span > bdi";
        IWebElement subtotal => driver.FindElement(By.CssSelector(SubtotalValue));

        public string DiscountField = "#post-5 > div > div > div.cart-collaterals > div > table > tbody > tr.cart-discount.coupon-edgewords > td > span"; 
        public IWebElement discount => driver.FindElement(By.CssSelector(DiscountField));

        IWebElement ApplyCouponButton => driver.FindElement(By.Name("apply_coupon"));
        

        public void ClearCheckout()
        {
            Remove.Click();
        }

        public CartPagePOM FillCoupon(string coupon)
        {
            CouponField.Clear();
            CouponField.SendKeys(coupon);
            return this;
        }

        public void ApplyCoupon()
        {
            ApplyCouponButton.Click();

        } 

    }

}

