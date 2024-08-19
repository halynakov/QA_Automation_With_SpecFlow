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
    public class CartPage : BasePage
    {
        public CartPage() { }
        private static CartPage cartpage;
        public static CartPage Instance => cartpage ?? (cartpage = new CartPage());
        IWebElement QtyButton => DriverManager.Instance().FindElement(By.XPath("//span [@class = 'a-dropdown-label']"));
        IWebElement Qty2Button => DriverManager.Instance().FindElement(By.XPath("//a [@id = 'quantity_2']"));
        IWebElement NewPrice => DriverManager.Instance().FindElement(By.XPath("//span [@class = 'a-size-medium a-color-base sc-price sc-white-space-nowrap']"));
        IWebElement DeleteButton => DriverManager.Instance().FindElement(By.XPath("//input[@value = 'Delete']"));
        IWebElement Title => DriverManager.Instance().FindElement(By.XPath("//h2"));

        public void ClickOnQtyButton()
        {
            QtyButton.Click();
        }
        public void ClickOnDeleteButton()
        {
            DeleteButton.Click();
            Thread.Sleep(1000);
        }
        public void ChangeAmountOfGoods()
        {
            Qty2Button.Click();
            Thread.Sleep(1000);
        }
        public string GetActualCart()
        {
            return NewPrice.Text;
        }
        public string GetTitle()
        {
            return Title.Text;
        }
    }
}
