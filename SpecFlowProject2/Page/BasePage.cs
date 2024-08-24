using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecFlowProject2.Drivers;
using System;
using System.Collections.ObjectModel;

namespace Final_Task.Pages
{
    public class BasePage
    {
        public BasePage() { }

        protected void WaitForElementToBeVisible(By locator, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        protected void WaitForElementToBeVisible(IWebElement element, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(driver => element.Displayed);
        }

        protected void WaitForElementToBeClickable(By locator, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        protected void WaitForElementToDisappear(By locator, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
        }

        protected void WaitForElementTextToChange(By locator, string expectedText, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(driver =>
            {
                try
                {
                    var element = driver.FindElement(locator);
                    return element.Text.Contains(expectedText);
                }
                catch (StaleElementReferenceException)
                {
                    var element = driver.FindElement(locator);
                    return element.Text.Contains(expectedText);
                }
            });
        }

        protected void ScrollToElement(By locator)
        {
            var element = DriverManager.Instance().FindElement(locator);
            ((IJavaScriptExecutor)DriverManager.Instance()).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        protected void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)DriverManager.Instance()).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public IWebElement FindElement(By locator)
        {
            return DriverManager.Instance().FindElement(locator);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return DriverManager.Instance().FindElements(locator);
        }

        public bool IsDisplayed(By locator, int timeout = 60)
        {
            var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeout));
            return wait.Until(d => DriverManager.Instance().FindElement(locator).Displayed);
        }
    }
}