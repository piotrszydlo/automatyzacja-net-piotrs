using System;
using System.Threading;
using Xunit;

namespace PageObjectLibrary
{
    public class FullProcessTest : IDisposable
    {
        [Fact]
        public void FullProcess()
        {
            var Admin = "https://autotestdotnet.wordpress.com/wp-admin/";
            PageOpen.Open(url: Admin);
            Thread.Sleep(1500);
            AdminPage.Logon();
            Thread.Sleep(5000);
            var G = new Guid();
            var PostData = new PostData
            {
                title = "Pan Wąski jest The Beściak " + G,
                content = G + " Pan Wąski jest The Beściak i jego Mafia też jest The Beściak"
            };
            AdminPage.AddPost();
            AdminPage.TypePost(PostData);

            Thread.Sleep(1500);
            AdminPage.LogOff();
            Thread.Sleep(1500);

            MainPage.Open();
            MainPage.OpenMyNote(PostData.title);

            Thread.Sleep(5500);


            var Coment = new Comment
            {
                Text = "Dzięki za browar :)" + G,
                Mail = G + "spam@spam.pl",
                User = "szydełko czy nóżka"
            };

            NotePage.AddComment(Coment);
            Assert.Contains(Coment.Text, Browser.PageSource());

            PageOpen.Open(url: Admin);
            Thread.Sleep(1500);
            AdminPage.Logon();
            Thread.Sleep(5000);
            AdminPage.DeletePost(PostData.title);
            Thread.Sleep(1500);
            AdminPage.LogOff();
        }

        public void Dispose()
        {
            Browser.Close();
        }
    }
}
