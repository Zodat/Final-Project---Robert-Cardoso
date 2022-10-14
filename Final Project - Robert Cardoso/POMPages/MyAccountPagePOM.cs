using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectRobertCardoso.POMPages
{
    internal class MyAccountPagePOM
    {
        IWebDriver driver;

        public MyAccountPagePOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators
       
        IWebElement UsernameField => driver.FindElement(By.Id("username"));
        IWebElement PasswordField => driver.FindElement(By.Id("password"));
        string LogInButton = "#customer_login > div.u-column1.col-1 > form > p:nth-child(3) > button";
        IWebElement LogIn => driver.FindElement(By.CssSelector(LogInButton));

        IWebElement Logout => driver.FindElement(By.LinkText("Log out"));
        public MyAccountPagePOM SetUsername(string username)
        {
            UsernameField.Clear();
            UsernameField.SendKeys(username);
            return this;
        }
        public MyAccountPagePOM SetPassword(string password)
        {
            PasswordField.Clear();
            PasswordField.SendKeys(password);
            return this;
        }
        public void GoLogin()
        {
            LogIn.Click();

        }

        public void GoLogout()
        {
            Logout.Click();
        }
    }
}
