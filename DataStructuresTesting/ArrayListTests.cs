using System;
using System.Linq;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresTesting
{
    [TestClass]
    public class ArrayListTests
    {
        [TestMethod]
        public void AddAddsElementToEmptyList()
        {
            Assert.IsTrue(new ArrayList<string> { "hello" }.Contains("hello"));
        }

        [TestMethod]
        public void AddAddsElementToNonEmptyList()
        {
            var list = new ArrayList<string> { "Hello," };
            list.Add("World!");
            Assert.IsTrue(list.Contains("World!"));
        }

        [TestMethod]
        public void RemoveReturnsTrueWhenRemovingElementInList()
        {
            var list = new ArrayList<string> { "Hello,", "World!" };
            Assert.IsTrue(list.Remove("World!"));
        }

        [TestMethod]
        public void RemoveRemovesElementInList()
        {
            var list = new ArrayList<string> { "Hello,", "World!" };
            list.Remove("World!");
            Assert.IsFalse(list.Contains("World!"));
        }

        [TestMethod]
        public void RemoveReturnsFalseWhenElementIsNotInList()
        {
            var list = new ArrayList<string> { "Hello," };
            Assert.IsFalse(list.Remove("World!"));
        }
    }
}
