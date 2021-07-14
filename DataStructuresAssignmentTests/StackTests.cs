using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresAssignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment.Tests
{
    [TestClass()]
    public class StackTests
    {
        [TestMethod()]
        public void PopTest()
        {
            var s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(3, s.Pop());
            s.Push(4);
            Assert.AreEqual(4, s.Pop());
            Assert.AreEqual(2, s.Pop());
            Assert.AreEqual(1, s.Pop());
        }

        [TestMethod()]
        [ExpectedException(typeof(NotSupportedException),
                    "Queues shouldnt be empty")]
        public void popExceptionTest()
        {
            var s = new Stack();
            s.Pop();

        }
    }
}