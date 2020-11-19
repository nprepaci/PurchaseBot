using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SearchItem;


namespace WalmartPurchaseBot
{
    public class MainTest
    {
        public IWebDriver driver;
        public string homeURL;


        [SetUp]
        public void Setup()
        {

            homeURL = "http://walmart.com";
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            LandingPage landingPage = new LandingPage();
            landingPage.driver = driver;

            driver.Navigate().GoToUrl(homeURL);
            landingPage.selectAndSearch();

            Assert.Pass();
        }
    }
}