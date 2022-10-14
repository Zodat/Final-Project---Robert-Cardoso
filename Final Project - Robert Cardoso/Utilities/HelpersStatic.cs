using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;


namespace FinalProjectRobertCardoso.Utilities;

public static class HelpersStatic
{

    public static void WaitForElmStatic(IWebDriver driver, int Seconds, By Locator)
    {
        //Wait to land on login page
        WebDriverWait myWait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(Seconds));
        myWait3.Until(drv => drv.FindElement(Locator).Displayed);
    }

    public static void TakeScreenshot(IWebDriver driver, string Filename)
    {
        ITakesScreenshot ssdriver = driver as ITakesScreenshot;
        Screenshot file = ssdriver.GetScreenshot();
        file.SaveAsFile(@"C:\Users\RobertCardoso\Pictures\Screenshots\" + Filename + ".png", ScreenshotImageFormat.Png);
    }

    public static void TakeScreenshotElement(IWebElement elm, string Filename)
    {
        ITakesScreenshot sselm = elm as ITakesScreenshot;
        Screenshot file = sselm.GetScreenshot();
        file.SaveAsFile(@"C:\Users\RobertCardoso\Pictures\Screenshots\" + Filename + ".png", ScreenshotImageFormat.Png);
    }


}

