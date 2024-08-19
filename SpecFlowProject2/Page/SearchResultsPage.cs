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
    public class SearchResultsPage : BasePage
    {
        public SearchResultsPage() { }
        private static SearchResultsPage _resultsPage;
        public static SearchResultsPage Instance => _resultsPage ?? (_resultsPage = new SearchResultsPage());
        IWebElement ActualItem => DriverManager.Instance().FindElement(By.XPath("//span[@class='a-size-base-plus a-color-base a-text-normal']"));
        public string GetItemName()
        {
            return ActualItem.Text;
        }
    }
}
