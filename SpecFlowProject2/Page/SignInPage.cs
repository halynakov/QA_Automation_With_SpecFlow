using Final_Task.Pages;
using OpenQA.Selenium;
using SpecFlowProject2.Drivers;

namespace SpecFlowProject2.Page
{
    public class SignInPage : BasePage
    {
        public SignInPage() { }
        private static SignInPage _signInPage;
        public static SignInPage Instance => _signInPage ?? (_signInPage = new SignInPage());

        By ContinueButton => By.XPath("//input[@id = 'continue']");
        By WarningMessage => By.XPath("//div[contains(text(),'Enter')]");

        public void ClickContinueButton()
        {
            FindElement(ContinueButton).Click();
        }

        public string GetMessage()
        {
            return FindElement(WarningMessage).Text;
        }
    }
}
