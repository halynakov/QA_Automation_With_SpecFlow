using Final_Task.Pages;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using SpecFlowProject2.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.Page
{
    public class HomePage : BasePage
    {
        public HomePage() { }
        private string URL => "https://www.amazon.com";
        IWebElement ChooseLanguageButton => DriverManager.Instance().FindElement(By.XPath("//span[text() = 'Deutsch']"));
        IWebElement InputSearchButton => DriverManager.Instance().FindElement(By.XPath("//input[@type='text']"));
        IWebElement SearchButton => DriverManager.Instance().FindElement(By.XPath("//input[@id='nav-search-submit-button']"));
        IWebElement SectionButton => DriverManager.Instance().FindElement(By.XPath("//span[text()='Headsets']"));
        IWebElement LocationButton => DriverManager.Instance().FindElement(By.XPath("//span[@id = 'glow-ingress-line2']"));
        IWebElement LocationLabelButton => DriverManager.Instance().FindElement(By.XPath("//span[@role='radiogroup']"));
        IWebElement CountryButton => DriverManager.Instance().FindElement(By.XPath("//a[@tabindex = '-1' and text() =  'United Kingdom']"));
        IWebElement DoneButton => DriverManager.Instance().FindElement(By.XPath("//button[@name = 'glowDoneButton']"));
        IWebElement LanguageButton => DriverManager.Instance().FindElement(By.XPath("//span[@class ='nav-line-2']"));
        IWebElement SectionName => DriverManager.Instance().FindElement(By.XPath("//a[text() = 'Geschenkkarten ']"));
        IWebElement CategoryName => DriverManager.Instance().FindElement(By.XPath("//span[contains(text(),'Learning Toys')]"));
        IWebElement AllButton => DriverManager.Instance().FindElement(By.XPath("//span[@class = 'hm-icon-label']"));
        IWebElement SignInButton => DriverManager.Instance().FindElement(By.XPath("//div[@id = 'hmenu-customer-name']"));

        private static HomePage homePage;
        public static HomePage Instance => homePage ?? (homePage = new HomePage());
        public void OpenHomePage()
        {
            DriverManager.Instance().Navigate().GoToUrl(URL);
            Thread.Sleep(10000);
        }
        public void EnterSearchInputButton(string name)
        {
            InputSearchButton.SendKeys(name);
        }
        public void ClickSearchButton()
        {
            SearchButton.Click();
        }
        public void ClickSectionButton()
        {
            SectionButton.Click();
        }
        public void ClickLocationButton()
        {
            LocationButton.Click();
            Thread.Sleep(2000);
        }
        public void ChangeLocationButton()
        {
            LocationLabelButton.Click();
            Thread.Sleep(2000);
            CountryButton.Click();
        }
        public void ClickDoneButton()
        {
            DoneButton.Click();
            Thread.Sleep(2000);
        }
        public string GetLocation()
        {
            return LocationButton.Text;
        }
        public void HoverLanguageButton()
        {
            var actions = new Actions(DriverManager.Instance());
            actions.MoveToElement(LanguageButton).Perform();
            Thread.Sleep(3000);
        }
        public void ClickLanguageButton()
        {
            ChooseLanguageButton.Click();
            Thread.Sleep(2000);
        }
        public string GetSectionName()
        {
            return SectionName.Text;
        }
        public void ClickOnCategory()
        {
            CategoryName.Click();
        }
        public void ClickDropdownMenu()
        {
            AllButton.Click();
            Thread.Sleep(2000);
        }
        public void ClickSignInButton()
        {
            SignInButton.Click();
            Thread.Sleep(2000);
        }
    }}
