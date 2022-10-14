using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectRobertCardoso.POMPages
{
    internal class ShopPagePOM
    {
        IWebDriver driver;

        public ShopPagePOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators

        string FirstItemString = "#main > ul > li:nth-of-type(1) > a> img"; //Create String for Beanie based on Locator
        IWebElement Beanie => driver.FindElement(By.CssSelector(FirstItemString));


        string SecondItemString = "#main > ul > li:nth-of-type(2) > a> img"; //Create String for Belt based on Locator
        IWebElement Belt => driver.FindElement(By.CssSelector(SecondItemString));

        string ThirdItemString = "#main > ul > li:nth-of-type(3) > a> img"; //Create String for Cap based on Locator
        IWebElement Cap => driver.FindElement(By.CssSelector(ThirdItemString));


        string FourthItemString = "#main > ul > li:nth-of-type(4) > a> img"; //Create String for Hoodie based on Locator
        IWebElement Hoodie => driver.FindElement(By.CssSelector(FourthItemString));

        string FifthItemString = "#main > ul > li:nth-of-type(5) > a> img"; //Create String for Hoodie with Logo based on Locator
        IWebElement HoodieLogo => driver.FindElement(By.CssSelector(FifthItemString));


        string SixthItemString = "#main > ul > li:nth-of-type(6) > a> img"; //Create String for Hoodie with Pocket based on Locator
        IWebElement HoodiePocket => driver.FindElement(By.CssSelector(SixthItemString));

        string SeventhItemString = "#main > ul > li:nth-of-type(7) > a> img"; //Create String for Hoodie with Zipper based on Locator
        IWebElement HoodieZipper => driver.FindElement(By.CssSelector(SeventhItemString));


        string EigthItemString = "#main > ul > li:nth-of-type(8) > a> img"; //Create String for LongSleeveTee based on Locator
        IWebElement LongSleeveTee => driver.FindElement(By.CssSelector(EigthItemString));

        string NinthItemString = "#main > ul > li:nth-of-type(9) > a> img"; //Create String for Beanie based on Locator
        IWebElement Polo => driver.FindElement(By.CssSelector(NinthItemString));


        string TenthItemString = "#main > ul > li:nth-of-type(10) > a> img"; //Create String for Belt based on Locator
        IWebElement Sunglasses => driver.FindElement(By.CssSelector(TenthItemString));

        string EleventhItemString = "#main > ul > li:nth-of-type(11) > a> img"; //Create String for Beanie based on Locator
        IWebElement TShirt => driver.FindElement(By.CssSelector(EleventhItemString));


        string TwelvthItemString = "#main > ul > li:nth-of-type(12) > a> img"; //Create String for Belt based on Locator
        IWebElement VNeckTShirt => driver.FindElement(By.CssSelector(TwelvthItemString));



        //Service Methods
        public void Item1()
        {
            Beanie.Click();
        }

        public void Item2()
        {
            Belt.Click();
        }

        public void Item3()
        {
            Cap.Click();
        }
        public void Item4()
        {
            Hoodie.Click();
        }
        public void Item5()
        {
            HoodieLogo.Click();
        }
        public void Item6()
        {
            HoodiePocket.Click();
        }
        public void Item7()
        {
            HoodieZipper.Click();
        }
        public void Item8()
        {
            LongSleeveTee.Click();
        }
        public void Item9()
        {
            Polo.Click();
        }
        public void Item10()
        {
            Sunglasses.Click();
        }
        public void Item11()
        {
            TShirt.Click();
        }
        public void Item12()
        {
            VNeckTShirt.Click();
        }

    }
}
