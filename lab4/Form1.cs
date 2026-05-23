using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static lab3.Form1;

namespace lab4
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void TestBookCreation()
        {
            Book book = new Book
            {
                Title = "C# Programming",
                Author = "John Smith"
            };
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);
        }

        [TestMethod]
        public void TestMagazineCreation()
        {
            Magazine magazine = new Magazine
            {
                Title = "Tech Weekly",
                Author = "Jane Doe",
                IssueNumber = 12
            };
            Assert.AreEqual("Tech Weekly", magazine.Title);
            Assert.AreEqual(12, magazine.IssueNumber);
        }

        [TestMethod]
        public void TestEBook_GetInfo()
        {
            var ebook = new EBook
            {
                Title = "Solo Leveling",
                Author = "Chu-Gong",
                Published = "D&C Media"
            };
            string expected = "Solo Leveling, Written by Chu-Gong published by D&C Media";
            Assert.AreEqual(expected, ebook.GetInfo());
        }
    }
}