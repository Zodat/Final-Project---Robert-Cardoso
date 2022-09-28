using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectRobertCardoso.POMPages
{
    internal class HomePagePOM
    {
        IWebDriver driver;
        public HomePagePOM(IWebDriver driver)
        {
            this.driver = driver;   
        }
        //Locators
        IWebElement LoginLink => driver.FindElement(By.LinkText("My account"));
        // Not a static value, the value of LoginLink depends on what happens at runtime. Prevents stale element exception
        //Expression bodied member
        //Service Methods
        public void GoLogin()
        {
            LoginLink.Click();
        }
    }

}
