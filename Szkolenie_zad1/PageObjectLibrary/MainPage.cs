using System;
using System.Linq;

namespace PageObjectLibrary
{
    internal class MainPage
    {
        private const string url = "https://autotestdotnet.wordpress.com/";
        internal static void Open()
        {
            Browser.NavigateTo(url);
        }

        internal static void OpenFirstNote()
        {
            var elements = Browser.FindByXpath("//article/header");
            elements.First().Click();
        }

        internal static void OpenMyNote(string title)
        {
            var locator = "//a[text()='"+title+"']";
            var SelectMyNote = Browser.FindByXpath(locator);
            SelectMyNote.First().Click();
        }
    }
}