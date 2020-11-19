using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WalmartPurchaseBot;
using WalmartPurchaseBot.Pages;


namespace SearchItem
{
    public class LandingPage
    {
        public IWebDriver driver;

        By searchBar = By.Id("global-search-input");
        By searchButton = By.Id("global-search-submit");
        By playstationDiscLink = By.ClassName("z_b");
        By playstationGiantAd = By.CssSelector("#searchProductResult > div > div:nth-child(1) > div > div > div.arrange-fill > div.tile-content.Grid-col.u-size-78-100-l.list-description-wrapper > div.tile-primary.Grid-col.u-size-5-8 > div.search-result-product-title.listview > a");
        By utilBarPrice = By.Id("util-bar-price");

        string searchText = "Playstation 5";

        //[SetUp]
        public void Setup()
        {
            //driver = new ChromeDriver();

        }


        public void selectAndSearch()
        {
            driver.FindElement(searchBar).SendKeys(searchText);
            driver.FindElement(searchButton).Click();
            //might need a wait here

            WaitHandler waitHandler = new WaitHandler();
            waitHandler.ExecuteWait(driver, utilBarPrice);
            driver.FindElement(utilBarPrice).Click();

           
        }    

    }
}