using System;
using System.Linq;
using System.Threading;

namespace PageObjectLibrary
{
    internal class AdminPage
    {
        internal static void Logon()
        {
            var UsernameOrEmail = Browser.FindElementById("usernameOrEmail");
            UsernameOrEmail.Click();
            UsernameOrEmail.SendKeys("autotestdotnet@gmail.com");

            var ContinueButton = Browser.FindByXpath("//button[text()='Continue']");
            ContinueButton.First().Click();

            var Password = Browser.FindElementById("password");
            Password.Click();
            Password.SendKeys("P@ssw0rd1");

            var LoginButton = Browser.FindElementById("primary");
            LoginButton.Click();
        }

        internal static void AddPost()
        {
            var PostMenu = Browser.FindByXpath("//*[@id='menu-posts']");
            PostMenu.First().Click();
            var AddNewPostButton = Browser.FindByXpath("//*[@id='menu-posts']/ul/li[3]/a");
            AddNewPostButton.First().Click();
        }

        internal static void LogOff()
        {
            var LogOffMenu = Browser.FindElementById("wp-admin-bar-my-account");
            LogOffMenu.Click();
            var SignOutButton = Browser.FindByXpath("//button[text()='Sign Out']");
            SignOutButton.First().Click();

        }

        internal static void TypePost(PostData PostDetails)
        {
            var titleFrame = Browser.FindElementById("title");
            titleFrame.Click();
            titleFrame.SendKeys(PostDetails.title);

            var contentFrame = Browser.FindElementById("content");
            contentFrame.Click();
            contentFrame.SendKeys(PostDetails.content);

            var PublishPost = Browser.FindElementById("publish");
            Thread.Sleep(2500);
            PublishPost.Click();
            Thread.Sleep(5500);

        }

        internal static void DeletePost(string title)
        {
            var PostMenu = Browser.FindByXpath("//*[@id='menu-posts']");
            PostMenu.First().Click();
            var locator = "//a[text()='" + title + "']";
            var SelectMyNote = Browser.FindByXpath(locator);
            SelectMyNote.First().Click();
            var DeleteNote = Browser.FindElementById("delete-action");
            DeleteNote.Click();
        }
    }
}