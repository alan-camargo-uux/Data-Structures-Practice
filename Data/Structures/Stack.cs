using Data.Nodes;

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
            private set
            {
                Top = value;
            }
        }

        /// <summary>
        /// Default constructor for <see cref="Stack{T}"/>
        /// </summary>
        public Stack()
        {
            Count = 0;
        }

        /// <summary>
        /// Adds an element to the top of the stack
        /// </summary>
        /// <param name="element">The element to be added</param>
        public void Push(T element)
        {
            if (IsEmpty)
                top = new Node<T>(element);
            else
            {
                Node<T> node = new Node<T>(element);
                node.Next = top;
                top = node;
            }
            Count++;
        }

        /// <summary>
        /// Removes the element at the top of the stack
        /// </summary>
        /// <returns>The element removed</returns>
        public T Pop()
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
