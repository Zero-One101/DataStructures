using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    /// <summary>
    /// A node structure to serve as a container around a data object, holding references to parent and child nodes.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Parent { get; set; }
        public Node<T> Child { get; set; }

        /// <summary>
        /// Constructs a new node with no parent or child
        /// </summary>
        /// <param name="data">The data contained by the node</param>
        public Node(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Constructs a new node with a parent and child
        /// </summary>
        /// <param name="data">The dat acontained by the node</param>
        /// <param name="parent">The parent to this node</param>
        /// <param name="child">The child of this node</param>
        public Node(T data, Node<T> parent, Node<T> child) : this(data)
        {
            Parent = parent;
            Child = child;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Node<T> n = obj as Node<T>;
            if((object)n == null)
            {
                return false;
            }

            return Data.Equals(n.Data);
        }

        public bool Equals(Node<T> n)
        {
            if ((object)n == null)
            {
                return false;
            }

            return Data.Equals(n.Data);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
