#region

using System.Collections.Generic;

#endregion

namespace TLT.BaseModel.Helpers {

    public class Node<T> {

        public Node(T value, IEnumerable<Node<T>> children)
        {
            Value    = value;
            Children = new List<Node<T>>(children);
        }

        private T              Value    { get; }
        private IList<Node<T>> Children { get; }

    }

}