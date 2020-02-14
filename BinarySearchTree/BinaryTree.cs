using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{

    public class BinaryTree<V> : IEnumerable<V> where V : IComparable<V>
    {

        internal TreeNode<V> root = null;
        public long length { get; private set; }

        public BinaryTree() { }

        public BinaryTree(List<V> list)
        {
            foreach (V el in list)
                Add(el);
        }

		public override string ToString() =>
            string.Join(" ", ToList());

        public bool Find(V value) =>
            root != null ? root.Find(value) : false;

        public List<V> ToList()
        {
            List<V> list = new List<V>();
            root?.ToList(list);
			list.GetEnumerator();
            return list;
        }

        public bool Add(V newValue)
        {
            if (root == null)
            {
                root = new TreeNode<V>(newValue);
                ++length;
                return true;
            }
            else
            {
                bool isAdded = root.Add(newValue);
                length += Convert.ToInt32(isAdded);
                return isAdded;
            }
        }

        public bool Delete(V value)
        {
            IComparable compValue = (IComparable)value;
            TreeNode<V> currentNode = root;
            TreeNode<V> prevNode = null;

            for(;;)
            {
                if (currentNode == null) return false;
                if (((IComparable)(currentNode.value)).CompareTo(compValue) == 0)
                    break;
                else if (((IComparable)(currentNode.value)).CompareTo(compValue) > 0)
                {
                    prevNode = currentNode;
                    currentNode = currentNode.left;
                }
                else
                {
                    prevNode = currentNode;
                    currentNode = currentNode.right;
                }
            }

            if(currentNode.left == null && currentNode.right == null)
            {
                if (prevNode.left == currentNode) prevNode.left = null;
                else prevNode.right = null;
            } else if (currentNode.left != null && currentNode.right == null)
            {
                if (prevNode.left == currentNode) prevNode.left = currentNode.left;
                else prevNode.right = currentNode.left;
            } else if (currentNode.left == null && currentNode.right != null)
            {
                if (prevNode.left == currentNode) prevNode.left = currentNode.right;
                else prevNode.right = currentNode.right;
            } else
            {
                TreeNode<V> newNode = currentNode.right;
                TreeNode<V> prevNewNode = null;

                while (newNode.left != null)
                {
                    prevNewNode = newNode;
                    newNode = newNode.left;
                }

                if (prevNewNode.left == newNode) prevNewNode.left = null;
                else prevNewNode.right = null;

                currentNode.value = newNode.value;
            }

            --length;
            return true;
        }

		public IEnumerator<V> GetEnumerator() => ToList().GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => (IEnumerator)GetEnumerator();
	}
}
