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
    public class ItemPage : BasePage
    {
        public ItemPage() { }
        private static ItemPage _item_page;
        public static ItemPage Instance => _item_page ?? (_item_page = new ItemPage());
        IWebElement AddCartButton => DriverManager.Instance().FindElement(By.XPath("//input[@id='add-to-cart-button']"));
        IWebElement GoToCartButton => DriverManager.Instance().FindElement(By.XPath("//a[@class='a-button-text']"));
        IWebElement AmountItemsOnCart => DriverManager.Instance().FindElement(By.XPath("//span[@id='nav-cart-count']"));
        public void AddToCart()
        {
            HomePage.Instance.ClickLocationButton();
            HomePage.Instance.ChangeLocationButton();
            HomePage.Instance.ClickDoneButton();
            AddCartButton.Click();
            Thread.Sleep(3000);
        }
        public string GetAmountOfItemsInCart()
        {
            return AmountItemsOnCart.Text;
        }
        public void GoToTheCart()
        {
            GoToCartButton.Click();
            Thread.Sleep(2000);
        }
    }
}
