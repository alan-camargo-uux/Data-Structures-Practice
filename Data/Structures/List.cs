using Data.Nodes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Structures
{

    /// <summary>
    /// A generic list
    /// </summary>
    /// <typeparam name="T">The type of the elements composing the list</typeparam>
    public class List<T> : IEnumerable<T>, IEnumerable, IList, IList<T>
    {

        private Node<T> head;

        /// <summary>
        /// Determines whether the list is empty
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
        /// Creates an instance of <see cref="List{T}"/>
        /// </summary>
        public List()
        {
            Count = 0;
            head = default(Node<T>);
        }

        /// <summary>
        /// Creates an instance of <see cref="List{T}"/>
        /// </summary>
        /// <param name="elements">The elements to populate the list with</param>
        public List(T[] elements)
        {
            // TODO: implement
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }

}
