using Final_Task.Pages;
using OpenQA.Selenium;
using SpecFlowProject2.Drivers;

namespace SpecFlowProject2.Page
{
    public class SearchResultsPage : BasePage
    {
        public SearchResultsPage() { }
        private static SearchResultsPage _resultsPage;
        public static SearchResultsPage Instance => _resultsPage ?? (_resultsPage = new SearchResultsPage());

        By ActualItem => By.XPath("//span[@class='a-size-base-plus a-color-base a-text-normal']");

        public string GetItemName()
        {
            return FindElement(ActualItem).Text;
        }
    }
}
