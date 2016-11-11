using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Data.Tests.Structures
{

    [TestClass]
    public class QueueTest
    {

        [TestMethod]
        public void ShouldEnqueueElement()
        {
            Data.Structures.Queue<int> queue = new Data.Structures.Queue<int>();
            Assert.IsTrue(queue.IsEmpty);
            int element = 1;
            queue.Enqueue(element);
            Assert.AreEqual(1, queue.Count);
        }

        [TestMethod]
        public void ShouldEnqueueRange_WithIEnumerable()
        {
            Data.Structures.Queue<int> queue = new Data.Structures.Queue<int>();
            IEnumerable<int> elements = new List<int>()
            {
                1, 2, 3, 4, 5
            };
            queue.EnqueueRange(elements);
            Assert.AreEqual(elements.Count(), queue.Count);
        }

        [TestMethod]
        public void ShouldEnqueueRange_WithIList()
        {
            Data.Structures.Queue<int> queue = new Data.Structures.Queue<int>();
            IList<int> elements = new int[]
            {
                1, 2, 3, 4, 5
            };
            queue.EnqueueRange(elements);
            Assert.AreEqual(elements.Count(), queue.Count);
        }

        [TestMethod]
        public void ShouldDequeue()
        {
            Data.Structures.Queue<int> queue = new Data.Structures.Queue<int>();
            int element = 1;
            queue.Enqueue(element);
            int removed = queue.Dequeue();
            Assert.IsTrue(queue.IsEmpty);
            Assert.AreEqual(element, removed);
        }

        [TestMethod]
        public void ShouldGetFrontElement()
        {
            Data.Structures.Queue<int> queue = new Data.Structures.Queue<int>();
            int[] elements = new int[]
            {
                1, 2, 3, 4, 5
            };
            queue.EnqueueRange(elements);
            Assert.AreEqual(1, queue.Front);
        }

    }

}
