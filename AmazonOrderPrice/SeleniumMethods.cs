using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AmazonOrderPrice
{
    class SeleniumMethods
    {
        private const string BaseUrl = "https://www.amazon.com/";
        private const string SearchInputXpath = "//input[@id='nav-bb-search' or @id='twotabsearchtextbox']";
        private const string SearchButtonXpath = "//input[@class = 'nav-bb-button' or @id='nav-search-submit-button']";
        private const string ProductPriceSymbolXpath = "//span[@class='a-price-symbol']";
        private const string ProductPriceWholeXpath = "//span[@class='a-price-whole']";
        private const string ProductPriceFractionXpath = "//span[@class='a-price-fraction']";

        private IWebDriver Driver { get; }

        internal SeleniumMethods()
        {
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArgument("--headless");

            Driver = new ChromeDriver(chromeDriverService, chromeOptions);
        }

        internal void GetAmazonPrice(string category, string country, out string price)
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            var searchInput = Driver.FindElement(By.XPath(SearchInputXpath));
            searchInput.Click();
            searchInput.SendKeys($"{category}, country {country}");
            Driver.FindElement(By.XPath(SearchButtonXpath)).Click();
            try
            {
                var symbol = Driver.FindElement(By.XPath(ProductPriceSymbolXpath)).Text;
                var whole = Driver.FindElement(By.XPath(ProductPriceWholeXpath)).Text;
                var dec = Driver.FindElement(By.XPath(ProductPriceFractionXpath)).Text;
                price = $"{symbol} {whole}.{dec}";

                if (string.IsNullOrEmpty(price))
                {
                    throw new Exception("Empty price.");
                }
            }
            catch
            {
                price = "Sorry, nothing was found:(";
            }
            Driver.Close();
            Driver.Quit();
        }
    }
}