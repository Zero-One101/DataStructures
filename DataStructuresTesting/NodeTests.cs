using System;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresTesting
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void NodeCorrectlyStoresData()
        {
            var node = new Node<string>("hello");
            Assert.IsTrue(node.Data == "hello");
        }

        [TestMethod]
        public void NodeCorrectlyStoresParent()
        {
            var parentNode = new Node<string>("hello");
            var childNode = new Node<string>("world", parentNode, null);
            Assert.IsTrue(childNode.Parent == parentNode);
        }

        [TestMethod]
        public void NodeCorrectlyStoresChild()
        {
            var childNode = new Node<string>("world");
            var parentNode = new Node<string>("hello", null, childNode);
            Assert.IsTrue(parentNode.Child == childNode);
        }
    }
}
