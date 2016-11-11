using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.Structures;

namespace Data.Tests.Structures
{

    [TestClass]
    public class StackTest
    {

        [TestMethod]
        public void ShouldPushElement()
        {
            Stack<int> stack = new Stack<int>();
            Assert.IsTrue(stack.IsEmpty);
            int element = 1;
            stack.Push(element);
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void ShouldPopElement()
        {
            Stack<int> stack = new Stack<int>();
            int element = 1;
            stack.Push(element);
            int removed = stack.Pop();
            Assert.IsTrue(stack.IsEmpty);
            Assert.AreEqual(element, removed);
        }

        [TestMethod]
        public void ShouldGetTopElement()
        {
            Stack<int> stack = new Stack<int>();
            int element = 1;
            stack.Push(element);
            Assert.AreEqual(element, stack.Top);
        }

    }

}
