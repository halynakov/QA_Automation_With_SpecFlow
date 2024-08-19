using Final_Task.Pages;
using OpenQA.Selenium;
using SpecFlowProject2.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.Page
{
    public class ProductsCategoryPage : BasePage
    {
        public ProductsCategoryPage() { }
        private static ProductsCategoryPage _productsPage;
        public static ProductsCategoryPage Instance => _productsPage ?? (_productsPage = new ProductsCategoryPage());
        IWebElement SelectedBrand => DriverManager.Instance().FindElement(By.XPath("//li[@id='p_123/331810']//span[contains(text(),'JOYIN')]"));
        public void FilteringByBrand()
        {
            SelectedBrand.Click();
        }
    }
}
