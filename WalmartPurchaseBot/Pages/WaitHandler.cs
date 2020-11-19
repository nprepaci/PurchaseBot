using System;
using OpenQA.Selenium;
namespace WalmartPurchaseBot.Pages
{
    public class WaitHandler
    {
        public IWebDriver driver;

        public void ExecuteWait(IWebDriver driver, By elementToWaitFor)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.Url = "http://somedomain/url_that_delays_loading";
            IWebElement dynamicElement = driver.FindElement(elementToWaitFor);
            Console.Write("success");
        }
    }
}
