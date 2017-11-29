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

            var mailBox = Browser.FindElementById("email");
            mailBox.Click();
            mailBox.SendKeys(testData.Mail);

            var nameLabel = Browser.FindByXpath("//label[@for='author']").First();
            nameLabel.Click();
            Thread.Sleep(11500);
            //Browser.WaitForInvisible(By.Id('author'));

            var authorBox = Browser.FindElementById("author");
            authorBox.Click();
            authorBox.SendKeys(testData.User);

            var submitButton = Browser.FindElementById("comment-submit");
            submitButton.Click();
        }
    }
}