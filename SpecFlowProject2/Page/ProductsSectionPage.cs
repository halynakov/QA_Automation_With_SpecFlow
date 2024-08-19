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
    public class ProductsSectionPage : BasePage
    {
        public ProductsSectionPage() { }
        private static ProductsSectionPage _productsPage;
        public static ProductsSectionPage Instance => _productsPage ?? (_productsPage = new ProductsSectionPage());
        IWebElement ItemButton => DriverManager.Instance().FindElement(By.XPath("//span[@class = 'a-size-medium a-color-base a-text-normal']"));
        IWebElement ActualSectionName => DriverManager.Instance().FindElement(By.XPath("//span[@class='a-color-state a-text-bold']"));
        IWebElement InputMinPrice => DriverManager.Instance().FindElement(By.XPath("//input[@name = 'low-price']"));
        IWebElement InputMaxPrice => DriverManager.Instance().FindElement(By.XPath("//input[@name = 'high-price']"));
        IWebElement GoButton => DriverManager.Instance().FindElement(By.XPath("//input[@aria-labelledby = 'a-autoid-1-announce']"));
        public void ClickItemButton()
        {
            ItemButton.Click();
            Thread.Sleep(2000);
        }
        public string GetSectionName()
        {
            return ActualSectionName.Text;
        }
        public void EnterMinPrice(string min_price)
        {
            InputMinPrice.SendKeys(min_price);
        }
        public void EnterMaxPrice(string max_price)
        {
            InputMaxPrice.SendKeys(max_price);
        }
        public void ClickOnGoButton()
        {
            GoButton.Click();
            Thread.Sleep(2000);
        }
    }
}
