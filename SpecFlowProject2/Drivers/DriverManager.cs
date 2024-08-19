using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SpecFlowProject2.Drivers
{
    public class DriverManager
    {
        private static IWebDriver driver;
        public static IWebDriver Instance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void QuitDriver()
        {
            driver.Quit();
            driver = null;
        }

    }
}
