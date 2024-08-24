using Final_Task.Pages;
using OpenQA.Selenium;
using SpecFlowProject2.Drivers;

namespace SpecFlowProject2.Page
{
    public class CartPage : BasePage
    {
        public CartPage() { }
        private static CartPage cartpage;
        public static CartPage Instance => cartpage ?? (cartpage = new CartPage());

        private readonly By qtyButtonLocator = By.XPath("//span[@class='a-dropdown-label']");
        private readonly By qty2ButtonLocator = By.XPath("(//a[@id='quantity_2' and @aria-hidden='true'])[3]");
        private readonly By newPriceLocator = By.XPath("//span[@class='a-size-medium a-color-base sc-price sc-white-space-nowrap']");
        private readonly By deleteButtonLocator = By.XPath("//input[@value='Delete']");
        private readonly By titleLocator = By.XPath("//h2");

        public void ClickOnQtyButton()
        {
            WaitForElementToBeClickable(qtyButtonLocator);
            var qtyButton = FindElement(qtyButtonLocator);
            qtyButton.Click();
            WaitForElementToBeClickable(qty2ButtonLocator);
        }

        public void ClickOnDeleteButton()
        {
            WaitForElementToBeClickable(deleteButtonLocator);
            var deleteButton = FindElement(deleteButtonLocator);
            deleteButton.Click();
            WaitForElementToDisappear(deleteButtonLocator);
        }

        public void ChangeAmountOfGoods()
        {
            WaitForElementToBeClickable(qty2ButtonLocator);
            var qty2Button = FindElement(qty2ButtonLocator);
            ScrollToElement(qty2ButtonLocator); 
            qty2Button.Click();
        }

        public string GetActualCart()
        {
            WaitForElementToBeVisible(newPriceLocator);
            var newPrice = FindElement(newPriceLocator);
            return newPrice.Text;
        }

        public string GetTitle()
        {
            WaitForElementTextToChange(titleLocator, "Cart is empty", 10);
            var title = FindElement(titleLocator);
            return title.Text;
        }
    }
}
