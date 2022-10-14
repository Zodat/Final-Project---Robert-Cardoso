using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using TechTalk.SpecFlow;

namespace FinalProjectRobertCardoso.Utilities
{
    [Binding]
    internal class BaseTest
    {
        public static IWebDriver driver;
        public string baseUrl = "https://www.edgewordstraining.co.uk";


        [BeforeScenario]
        //[SetUp]
        public void Setup()
        {


            string browser = Environment.GetEnvironmentVariable("BROWSER"); //Find Browser in RunSettings


            switch (browser)
            {
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                default:
                    Console.WriteLine("No browser or unknown browser");
                    Console.WriteLine("Using Chrome");
                    driver = new ChromeDriver();
                    break;
            }



            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        //[TearDown]
        public void TearDown()
        {
            Thread.Sleep(3000);///waits 3 seconds
            driver.Quit();//Closes Browser
        }
    }

}