﻿using System;
using Xunit;

namespace PageObjectLibrary
{
    public class AddingBLogCommentTest : IDisposable
    {
        [Fact]
        public void CanAddCommentToTheBlogNote()
        {
            MainPage.Open();
            MainPage.OpenFirstNote();
            var G = new Guid();
            var Coment = new Comment
            {
                Text = "Dzięki za browar :)" + G,
                Mail = G+"spam@spam.pl",
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
