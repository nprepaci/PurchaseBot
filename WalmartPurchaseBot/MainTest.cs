using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace WalmartPurchaseBot
{
    public class MainTest
    {
        private IWebDriver driver;
        public string homeURL;


        [SetUp]
        public void Setup()
        {

            homeURL = "http://nicholasrepaci.com";
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl(homeURL);
            Assert.Pass();
        }
    }
}