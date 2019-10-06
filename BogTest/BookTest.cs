using System;
using BogClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookClassLibraryTest
{
    [TestClass]
    public class BookTest
    {
        private Book _book;

        [TestInitialize]
        public void SetUp()
        {
            _book = new Book("Great Ideas", "Anders B", 45, "1234567890123");
        }

        [TestMethod]
        public void TestTitle()
        {
            _book.Title = "An";
            Assert.AreEqual("An", _book.Title);
            Assert.ThrowsException<ArgumentNullException>(() => _book.Title = null);
            Assert.ThrowsException<ArgumentException>(() => _book.Title = "A");
            Assert.ThrowsException<ArgumentException>(() => new Book("B", "Anders B", 12, "1234567890123"));
            Assert.AreEqual("An", _book.Title);
        }

        [TestMethod]
        public void TestNumberOfPages()
        {
            _book.NumberOfPages = 10;
            Assert.AreEqual(10, _book.NumberOfPages);
            _book.NumberOfPages = 1000;
            Assert.AreEqual(1000, _book.NumberOfPages);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _book.NumberOfPages = 9);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _book.NumberOfPages = 10001);
            Assert.AreEqual(1000, _book.NumberOfPages);
        }

        [TestMethod]
        public void TestIsbn13()
        {
            _book.Isbn13 = "1234567890123";
            Assert.AreEqual("1234567890123", _book.Isbn13);
            Assert.ThrowsException<ArgumentNullException>(() => _book.Isbn13 = null);
            Assert.ThrowsException<ArgumentException>(() => _book.Isbn13 = "123456789012");
            Assert.ThrowsException<ArgumentException>(() => _book.Isbn13 = "12345678901234");
            Assert.AreEqual("1234567890123", _book.Isbn13);
        }
    }
}
