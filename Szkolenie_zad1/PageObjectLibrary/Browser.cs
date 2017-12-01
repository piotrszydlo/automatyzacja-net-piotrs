using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.ObjectModel;
using Xunit;

namespace PageObjectLibrary
{
    internal class Browser
    {
        private static IWebDriver driver;

        internal static IWebElement FindElementById(string id)
        {
            return driver.FindElement(By.Id(id));
        }

        static Browser()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(100);
        }

        internal static ReadOnlyCollection<IWebElement> FindByXpath(string xpath)
        {
            return driver.FindElements(By.XPath(xpath));
        }

        internal static void WaitForInvisible(By by)
        {
            
            //new WebDriverWait(driver, TimeSpan.FromSeconds(5))
            //.Until(ExpectedConditions.InvisibilityOfElementLocated(by);
        }

        internal static void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        internal static void Close()
        {
            driver.Quit();
        }

        internal static string PageSource()
        {
            return driver.PageSource;
        }

        internal static void FindElement(string linkname)
        {
            driver.FindElement(By.LinkText(linkname));
        }

        internal static IWebElement FindElementByPageTitle()
        {
            return driver.FindElement(By.XPath("/html/head/title"));
        }
    }
    
    
}