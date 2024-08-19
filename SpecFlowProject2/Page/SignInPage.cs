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
    public class SignInPage : BasePage
    {
        public SignInPage() { }
        private static SignInPage _signInPage;
        public static SignInPage Instance => _signInPage ?? (_signInPage = new SignInPage());
        IWebElement ContinueButton => DriverManager.Instance().FindElement(By.XPath("//input[@id = 'continue']"));
        IWebElement WarningMessage => DriverManager.Instance().FindElement(By.XPath("//div[contains(text(),'Enter')]"));
        public void ClickContinueButton()
        {
            ContinueButton.Click();
            Thread.Sleep(2000);
        }
        public string GetMessage()
        {
            return WarningMessage.Text;
        }
    }
}
