using Final_Task.Pages;
using OpenQA.Selenium;
using SpecFlowProject2.Drivers;

namespace SpecFlowProject2.Page
{
    public class ProductsCategoryPage : BasePage
    {
        public ProductsCategoryPage() { }
        private static ProductsCategoryPage _productsPage;
        public static ProductsCategoryPage Instance => _productsPage ?? (_productsPage = new ProductsCategoryPage());

        By FiltersButton => By.XPath("//span[@id='s-all-filters' and @role='button']");
        By SelectedBrand => By.XPath("//li[@id='p_123/331810']//span[contains(text(),'JOYIN')]");

        public void FilteringByBrand()
        {
            WaitForElementToBeVisible(SelectedBrand);
            WaitForElementToBeClickable(SelectedBrand);
            FindElement(SelectedBrand).Click();
        }
    }
}
