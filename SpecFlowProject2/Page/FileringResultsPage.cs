using Final_Task.Pages;
using OpenQA.Selenium;
using SpecFlowProject2.Drivers;

namespace SpecFlowProject2.Page
{
    public class FilteringResultsPage : BasePage
    {
        public FilteringResultsPage() { }
        private static FilteringResultsPage filter_page;
        public static FilteringResultsPage Instance => filter_page ?? (filter_page = new FilteringResultsPage());

        private readonly By productNameLocator = By.XPath("//span[@class='a-size-base-plus a-color-base a-text-normal']");
        private readonly By productPriceLocator = By.XPath("//span[@class='a-price-whole']");

        public string GetProductName()
        {
            WaitForElementToBeVisible(productNameLocator);   
            return FindElement(productNameLocator).Text;
        }

        public string GetProductPrice()
        {
            WaitForElementToBeVisible(productPriceLocator);   
            return FindElement(productPriceLocator).Text;
        }

        public void ClickOnProductNameButton()
        {
            ScrollToElement(productNameLocator);   
            WaitForElementToBeClickable(productNameLocator);   
            FindElement(productNameLocator).Click();
        }
    }
}
