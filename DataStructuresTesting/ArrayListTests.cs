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
    }
}
