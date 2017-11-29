using System;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;
using System.Linq;
using System.Collections.ObjectModel;

namespace PageObjectLibrary
{
    public class AddingBLogCommentTest : IDisposable
    {
        [Fact]
        public void CanAddCommentToTheBlogNote()
        {
            MainPage.Open();
            MainPage.OpenFirstNote();

            //otwórz 1 notkę
            //dodaj komenta
            //sprawdź że jest dodany

        }

        public void Dispose()
        {
            Browser.Close();
        }
    }
}
