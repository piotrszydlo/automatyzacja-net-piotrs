using System;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;
using System.Linq;
using System.Collections.ObjectModel;

namespace SeleniumTests
{
    public class Example : IDisposable
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;

        private const string SearchTextBoxId = "lst-ib";
        private const string Gugiel = "https://www.google.pl/";
        private const string SearchText = "Poznaj nasze podejście";
        private const string SearchHeaderText = "WIEDZA NA PIERWSZYM MIEJSCU";
        private const string CookiesAcceptanceText = "Akceptuję";
        private const string PageTitle = "Code Sprinters -";
        private const string SearchTextInGugiel = "code sprinters";

        public Example()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(100);
            verificationErrors = new StringBuilder();
        }

        [Fact]
        public void TheExampleTest()
        {
            GoToGugiel();
            SearchInGugiel(SearchTextInGugiel);
            OpenSearchResultByPageTitle(PageTitle);
            SearchingWebElement(SearchText);

            //ver1
            var element = driver.FindElement(By.LinkText(SearchText));
            Assert.NotNull(element);

            //ver2
            //var elements = GetWebElementsLink(SearchText);
            //Assert.Single(elements);

            Assert.Single(GetWebElementsLink(SearchText));

            AcceptCookiesAndOpenPage();

            //ver1
            Assert.Contains(SearchHeaderText, driver.PageSource);

            //ver2
            Assert.Single(driver.FindElements(By.TagName("h2"))
                .Where(tag => tag.Text == SearchHeaderText));

        }

        private void AcceptCookiesAndOpenPage()
        {
            SearchAndClickWebElement(CookiesAcceptanceText);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.InvisibilityOfElementWithText(By.LinkText(CookiesAcceptanceText), CookiesAcceptanceText));

            waitForElementPresent(By.LinkText(SearchText), 2);
            SearchAndClickWebElement(SearchText);
        }

        private ReadOnlyCollection<IWebElement> GetWebElementsLink(string webText)
        {
            return driver.FindElements(By.LinkText(webText));
        }

        private void SearchAndClickWebElement(string SearchedElementToClick)
        {
            driver.FindElement(By.LinkText(SearchedElementToClick)).Click();
        }

        private void SearchingWebElement(string WebText)
        {
            driver.FindElement(By.LinkText(WebText));
        }

        private void SearchInGugiel(string SearchTextInGugiel)
        {
            var searchBox = GetSearchBox();
            searchBox.Clear();
            searchBox.SendKeys(SearchTextInGugiel);
            searchBox.Submit();
        }

        private void OpenSearchResultByPageTitle(string PageTitle)
        {
            driver.FindElement(By.LinkText(PageTitle)).Click();
        }

        private void GoToGugiel()
        {
            driver.Navigate().GoToUrl(Gugiel);
        }

        private IWebElement GetSearchBox()
        {
            return driver.FindElement(By.Id(SearchTextBoxId));
        }

        protected void waitForElementPresent(By by, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        protected void waitForElementPresent(IWebElement by, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        //private bool IsElementPresent(By by)
        //{
        //    try
        //    {
        //        driver.FindElement(by);
        //        return true;
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        return false;
        //    }
        //}

        //private bool IsAlertPresent()
        //{
        //    try
        //    {
        //        driver.SwitchTo().Alert();
        //        return true;
        //    }
        //    catch (NoAlertPresentException)
        //    {
        //        return false;
        //    }
        //}

        //private string CloseAlertAndGetItsText()
        //{
        //    try
        //    {
        //        IAlert alert = driver.SwitchTo().Alert();
        //        string alertText = alert.Text;
        //        if (acceptNextAlert)
        //        {
        //            alert.Accept();
        //        }
        //        else
        //        {
        //            alert.Dismiss();
        //        }
        //        return alertText;
        //    }
        //    finally
        //    {
        //        acceptNextAlert = true;
        //    }
        //}

        public void Dispose()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.Equal("", verificationErrors.ToString());
        }
    }
}