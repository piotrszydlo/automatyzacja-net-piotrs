using System;
using System.Threading;
using Xunit;

namespace PageObjectLibrary
{
    public class LogToAdminAddNewNoteTest : IDisposable
    {
        [Fact]
        public void LogToAdminAddNewNote()
        {
            var Admin = "https://autotestdotnet.wordpress.com/wp-admin/";
            PageOpen.Open(url: Admin);
            Thread.Sleep(1500);
            AdminPage.Logon();
            Thread.Sleep(5000);
            //var PageTitle = Browser.FindElementByPageTitle().ToString();
            //Assert.Contains("Dashboard ‹ Automatyzacja Testów .NET — WordPress", PageTitle);
            AdminPage.AddPost();
            var G = new Guid();
            var PostData = new PostData
            {
                title = "Pan Wąski jest The Beściak " + G,
                content = G + " Pan Wąski jest The Beściak i jego Mafia też jest The Beściak"
            };
            AdminPage.TypePost(PostData);

            Thread.Sleep(1500);
            AdminPage.LogOff();

            //var G = new Guid();
            //var Coment = new Comment
            //{
            //    Text = "Dzięki za browar :)" + G,
            //    Mail = G + "spam@spam.pl",
            //    User = "szydełko czy nóżka"
            //};

            //NotePage.AddComment(Coment);
            //Assert.Contains(Coment.Text, Browser.PageSource());

        }

        public void Dispose()
        {
            Browser.Close();
        }
    }
}
