using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WalmartPurchaseBot;

namespace SearchItem
{
    public class LandingPage
    {
        private IWebDriver driver;
        

        By searchBar = By.Id("global-search-input");
        By searchButton = By.Id("global-search-submit");

        string searchText = "Playstation 5";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

        }


        public void selectAndSearch()
        {
            driver.FindElement(searchBar).SendKeys(searchText);
            driver.FindElement(searchButton).Click();

           
        }    

    }
}