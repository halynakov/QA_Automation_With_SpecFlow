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

        By ItemButton => By.XPath("//span[@class = 'a-size-medium a-color-base a-text-normal']");
        By ActualSectionName => By.XPath("//span[@class='a-color-state a-text-bold']");
        By InputMinPrice => By.XPath("//input[@name = 'low-price']");
        By InputMaxPrice => By.XPath("//input[@name = 'high-price']");
        By GoButton => By.XPath("//input[@aria-labelledby = 'a-autoid-1-announce']");

        public void ClickItemButton()
        {
            WaitForElementToBeClickable(ItemButton);
            FindElement(ItemButton).Click();
        }

        public string GetSectionName()
        {
            WaitForElementToBeVisible(ActualSectionName);
            return FindElement(ActualSectionName).Text;
        }

        public void EnterMinPrice(string min_price)
        {
            FindElement(InputMinPrice).SendKeys(min_price);
        }

        public void EnterMaxPrice(string max_price)
        {
            FindElement(InputMaxPrice).SendKeys(max_price);
        }

        public void ClickOnGoButton()
        {
            WaitForElementToBeClickable(GoButton);
            FindElement(GoButton).Click();
        }
    }
}
