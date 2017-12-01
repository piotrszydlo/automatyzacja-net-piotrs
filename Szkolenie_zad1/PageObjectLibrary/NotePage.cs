using System;
using System.Linq;
using System.Threading;

namespace PageObjectLibrary
{
    internal class NotePage
    {
        internal static void AddComment(Comment testData)
        {
            var commentBox = Browser.FindElementById("comment");
            commentBox.Click();
            commentBox.SendKeys(testData.Text);

            var mailBoxLabel = Browser.FindByXpath("//label[@for='email']").First();
            mailBoxLabel.Click();

            var mailBox = Browser.FindElementById("email");
            mailBox.Click();
            mailBox.SendKeys(testData.Mail);

            var nameLabel = Browser.FindByXpath("//label[@for='author']").First();
            nameLabel.Click();

            var nameBox = Browser.FindElementById("author");
            nameBox.Click();
            //Thread.Sleep(11500);
            //Browser.WaitForInvisible(By.Id('author'));

            //nameLabel.Click();
            nameBox.SendKeys(testData.User);
            //var authorBox = Browser.FindElementById("author");
            //authorBox.Click();
            //authorBox.SendKeys(testData.User);

            var submitButton = Browser.FindElementById("comment-submit");
            submitButton.Click();
        }

        //internal static void FindCommentAndClick(string linkname)
        //{
        //    var FindElement=Browser.FindByLink(linkname);
        //    Browser.Click();
        //}
    }
}