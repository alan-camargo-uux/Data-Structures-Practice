using Data.Nodes;
using System.Collections.Generic;

namespace Data.Structures
{

    /// <summary>
    /// A generic queue
    /// </summary>
    /// <typeparam name="T">The type of the elements composing the queue</typeparam>
    public class Queue<T>
    {

        private Node<T> front;

        /// <summary>
        /// Determines whether the queue is empty
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return Count == 0;
            }
        }

        /// <summary>
        /// Gets the number of elements
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Gets the element at the front
        /// </summary>
        public T Front
        {
            get
            {
                return front.Element;
            }
        }

        /// <summary>
        /// Creates an instance of <see cref="Queue{T}"/>
        /// </summary>
        public Queue()
        {
            Count = 0;
            front = default(Node<T>);
        }

        /// <summary>
        /// Adds an element to the end
        /// </summary>
        /// <param name="element">The element to be added</param>
        public void Enqueue(T element)
        {
            Node<T> node = new Node<T>(element);
            if (IsEmpty)
                front = node;
            else
            {
                Node<T> back = front;
                while (back.Next != default(Node<T>))
                    back = back.Next;
                back.Next = node;
            }
            Count++;
        }

        /// <summary>
        /// Adds a collection of elements
        /// </summary>
        /// <param name="elements">The elements to be added</param>
        public void EnqueueRange(IEnumerable<T> elements)
        {
            foreach (T element in elements)
                Enqueue(element);
        }

        /// <summary>
        /// Adds a collection of elements
        /// </summary>
        /// <param name="elements">The elements to be added</param>
        public void EnqueueRange(IList<T> elements)
        {
            foreach (T element in elements)
                Enqueue(element);
        }

        /// <summary>
        /// Removes the element at the front
        /// </summary>
        /// <returns>The element removed</returns>
        public T Dequeue()
        {
            if (IsEmpty)
                return default(T);
            else
            {
                Node<T> ret = front;
                front = front.Next;
                Count--;
                return ret.Element;
            }
        }

    }

}
