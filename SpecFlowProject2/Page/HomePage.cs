using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using SpecFlowProject2.Drivers;
using Final_Task.Pages;

namespace SpecFlowProject2.Page
{
    public class HomePage : BasePage
    {
        public HomePage() { }
        private string URL => "https://www.amazon.com";

        By ChooseLanguageButton => By.XPath("//span[text() = 'Deutsch']");
        By InputSearchButton => By.XPath("//input[@type='text']");
        By SearchButton => By.XPath("//input[@id='nav-search-submit-button']");
        By SectionButton => By.XPath("//span[text()='Headsets']");
        By LocationButton => By.XPath("//span[@id = 'glow-ingress-line2']");
        By LocationLabelButton => By.XPath("//span[@role='radiogroup']");
        By CountryButton => By.XPath("//a[@tabindex = '-1' and text() =  'United Kingdom']");
        By DoneButton => By.XPath("//button[@name = 'glowDoneButton']");
        By LanguageButton => By.XPath("//span[@class ='nav-line-2']");
        By SectionName => By.XPath("//a[text() = 'Geschenkkarten ']");
        By CategoryName => By.XPath("//span[contains(text(),'Learning Toys')]");
        By AllButton => By.XPath("//span[@class = 'hm-icon-label']");
        By SignInButton => By.XPath("//div[@id = 'hmenu-customer-name']");

        private static HomePage homePage;
        public static HomePage Instance => homePage ?? (homePage = new HomePage());

        public void OpenHomePage()
        {
            DriverManager.Instance().Navigate().GoToUrl(URL);
            WaitForElementToBeVisible(InputSearchButton, 10);
        }

        public void EnterSearchInputButton(string name)
        {
            FindElement(InputSearchButton).SendKeys(name);
        }

        public void ClickSearchButton()
        {
            WaitForElementToBeClickable(SearchButton, 10);
            FindElement(SearchButton).Click();
        }

        public void ClickSectionButton()
        {
            WaitForElementToBeClickable(SectionButton, 10);
            FindElement(SectionButton).Click();
        }

        public void ClickLocationButton()
        {
            WaitForElementToBeClickable(LocationButton, 10);
            FindElement(LocationButton).Click();
        }

        public void ChangeLocationButton()
        {
            WaitForElementToBeClickable(LocationLabelButton, 10);
            FindElement(LocationLabelButton).Click();
            WaitForElementToBeClickable(CountryButton, 10);
            FindElement(CountryButton).Click();
        }

        public void ClickDoneButton()
        {
            WaitForElementToBeClickable(DoneButton, 10);
            FindElement(DoneButton).Click();
        }

        public string GetLocation()
        {
            WaitForElementTextToChange(LocationButton, "United Kingdom", 10);
            return FindElement(LocationButton).Text;
        }

        public void HoverLanguageButton()
        {
            var actions = new Actions(DriverManager.Instance());
            actions.MoveToElement(FindElement(LanguageButton)).Perform();
            WaitForElementToBeVisible(ChooseLanguageButton, 10);
        }

        public void ClickLanguageButton()
        {
            WaitForElementToBeClickable(ChooseLanguageButton, 10);
            FindElement(ChooseLanguageButton).Click();
        }

        public string GetSectionName()
        {
            WaitForElementToBeVisible(SectionName, 10);
            return FindElement(SectionName).Text;
        }

        public void ClickOnCategory()
        {
            WaitForElementToBeClickable(CategoryName, 10);
            FindElement(CategoryName).Click();
        }

        public void ClickDropdownMenu()
        {
            WaitForElementToBeClickable(AllButton, 10);
            FindElement(AllButton).Click();
        }

        public void ClickSignInButton()
        {
            WaitForElementToBeClickable(SignInButton, 10);
            FindElement(SignInButton).Click();
        }
    }
}
