using Data.Nodes;
using System.Collections.Generic;

namespace Data.Structures
{

    /// <summary>
    /// A generic stack
    /// </summary>
    /// <typeparam name="T">The type of the elements composing the stack</typeparam>
    public class Stack<T>
    {

        private Node<T> top;

        /// <summary>
        /// Determines whether the stack is empty
        /// </summary>
        public bool IsEmpty
        {   get
            {
                return Count == 0;
            }
        }

        /// <summary>
        /// Gets the number of elements
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Gets the element at the top
        /// </summary>
        public T Top
        {
            get
            {
                return top.Element;
            }
        }

        /// <summary>
        /// Creates an instance of <see cref="Stack{T}"/>
        /// </summary>
        public Stack()
        {
            Count = 0;
            top = default(Node<T>);
        }

        /// <summary>
        /// Adds an element to the top
        /// </summary>
        /// <param name="element">The element to be added</param>
        public void Push(T element)
        {
            Node<T> node = new Node<T>(element);
            if (IsEmpty)
                top = node;
            else
            {
                node.Next = top;
                top = node;
            }
            Count++;
        }

        /// <summary>
        /// Adds a collection of elements
        /// </summary>
        /// <param name="elements">The elements to be added</param>
        public void PushRange(IEnumerable<T> elements)
        {
            foreach (T element in elements)
                Push(element);
        }

        /// <summary>
        /// Adds a collection of elements
        /// </summary>
        /// <param name="elements">The elements to be added</param>
        public void PushRange(IList<T> elements)
        {
            foreach (T element in elements)
                Push(element);
        }

        /// <summary>
        /// Removes the element at the top
        /// </summary>
        /// <returns>The element removed</returns>
        public T Popsy()
        {
            if (IsEmpty)
                return default(T);
            else
            {
                Node<T> ret = top;
                top = top.Next;
                Count--;
                return ret.Element;
            }
        }

    }

}
