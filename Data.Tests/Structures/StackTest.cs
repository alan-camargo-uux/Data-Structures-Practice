using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Data.Tests.Structures
{

    [TestClass]
    public class StackTest
    {

        [TestMethod]
        public void ShouldPushElement()
        {
            Data.Structures.Stack<int> stack = new Data.Structures.Stack<int>();
            Assert.IsTrue(stack.IsEmpty);
            int element = 1;
            stack.Push(element);
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void ShouldPushRange_WithIEnumerable()
        {
            Data.Structures.Stack<int> stack = new Data.Structures.Stack<int>();
            IEnumerable<int> elements = new List<int>()
            {
                1, 2, 3, 4, 5
            };
            stack.PushRange(elements);
            Assert.AreEqual(elements.Count(), stack.Count);
        }

        [TestMethod]
        public void ShouldPushRange_WithIList()
        {
            Data.Structures.Stack<int> stack = new Data.Structures.Stack<int>();
            int[] elements = new int[]
            {
                1, 2, 3, 4, 5
            };
            stack.PushRange(elements);
            Assert.AreEqual(elements.Length, stack.Count);
        }

        [TestMethod]
        public void ShouldPopElement()
        {
            Data.Structures.Stack<int> stack = new Data.Structures.Stack<int>();
            int element = 1;
            stack.Push(element);
            int removed = stack.Pop();
            Assert.IsTrue(stack.IsEmpty);
            Assert.AreEqual(element, removed);
        }

        [TestMethod]
        public void ShouldGetTopElement()
        {
            Data.Structures.Stack<int> stack = new Data.Structures.Stack<int>();
            int[] elements = new int[]
            {
                1, 2, 3, 4, 5
            };
            stack.PushRange(elements);
            Assert.AreEqual(5, stack.Top);
        }

    }

}
