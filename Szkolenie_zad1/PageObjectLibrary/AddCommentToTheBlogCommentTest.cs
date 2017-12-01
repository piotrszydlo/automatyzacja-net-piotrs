using System;
using Xunit;

namespace PageObjectLibrary
{
    public class AddCommentToTheBlogCommentTest : IDisposable
    {
        [Fact]
        public void CanAddCommentToTheBlogComment()
        {
            MainPage.Open();
            MainPage.OpenFirstNote();
            //NotePage.FindCommentAndClick(linkname: "Reply");
            //NotePage.AddAnotherComment();
            var G = new Guid();
            var Coment = new Comment
            {
                Text = "Dzięki za browar :)" + G,
                Mail = G + "spam@spam.pl",
                User = "szydełko czy nóżka"
            };

            NotePage.AddComment(Coment);
            Assert.Contains(Coment.Text, Browser.PageSource());

        }

        public void Dispose()
        {
            Browser.Close();
        }
    }
}
