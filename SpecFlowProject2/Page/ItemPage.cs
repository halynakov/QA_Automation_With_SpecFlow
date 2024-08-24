using Final_Task.Pages;
using OpenQA.Selenium;
using SpecFlowProject2.Drivers;

namespace SpecFlowProject2.Page
{
    public class ItemPage : BasePage
    {
        public ItemPage() { }
        private static ItemPage _item_page;
        public static ItemPage Instance => _item_page ?? (_item_page = new ItemPage());

        private readonly By addCartButtonLocator = By.XPath("//input[@id='add-to-cart-button']");
        private readonly By goToCartButtonLocator = By.XPath("//a[@class='a-button-text']");
        private readonly By amountItemsOnCartLocator = By.XPath("//span[@id='nav-cart-count']");

        public void AddToCart()
        {
            HomePage.Instance.ClickLocationButton();
            HomePage.Instance.ChangeLocationButton();
            HomePage.Instance.ClickDoneButton();
            WaitForElementToBeClickable(addCartButtonLocator);  
            FindElement(addCartButtonLocator).Click();
        }

        public string GetAmountOfItemsInCart()
        {
            WaitForElementToBeVisible(amountItemsOnCartLocator);  
            return FindElement(amountItemsOnCartLocator).Text;
        }

        public void GoToTheCart()
        {
            WaitForElementToBeClickable(goToCartButtonLocator);  
            FindElement(goToCartButtonLocator).Click();
        }
    }
}
