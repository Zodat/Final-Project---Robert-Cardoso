using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectRobertCardoso.POMPages
{
    internal class LoginPagePOM
    {
        IWebDriver driver;

        public LoginPagePOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators
       
        IWebElement usernameField => driver.FindElement(By.Id("username"));
        IWebElement passwordField => driver.FindElement(By.Id("password"));
        string LogInButton = "#customer_login > div.u-column1.col-1 > form > p:nth-child(3) > button";
        IWebElement LogIn => driver.FindElement(By.CssSelector(LogInButton));

        public LoginPagePOM SetUsername(string username)
        {
            usernameField.Clear();
            usernameField.SendKeys(username);
            return this;
        }
        public LoginPagePOM SetPassword(string password)
        {
            passwordField.Clear();
            passwordField.SendKeys(password);
            return this;
        }
        public void GoLogin()
        {
            LogIn.Click();

        }

    }
}
