namespace Data.Nodes
{

    /// <summary>
    /// A generic node
    /// </summary>
    /// <typeparam name="T">The type of the element</typeparam>
    public class Node<T>
    {

        /// <summary>
        /// The element
        /// </summary>
        public T Element { get; set; }

        /// <summary>
        /// The next node
        /// </summary>
        public Node<T> Next { get; set; }

        /// <summary>
        /// Default constructor for <see cref="Node{T}"/>
        /// </summary>
        /// <param name="element"></param>
        public Node(T element)
        {
            Element = element;
            Next = default(Node<T>);
        }

    }

}
