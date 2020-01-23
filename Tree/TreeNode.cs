using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{

    internal class TreeNode<V> where V : IComparable<V>
    {

        public TreeNode<V> left; //todo encapsulation
        public TreeNode<V> right;

        public V value;

        public TreeNode(V value)
        {
            this.value = value;
            left = null;
            right = null;
        }

        public bool Find(V otherValue)
        {
            IComparable comparableThisValue = (IComparable)this.value;
            IComparable comparableOtherValue = (IComparable)otherValue;

            if (comparableOtherValue.CompareTo(comparableThisValue) == 0)
                return true;
            else if (comparableOtherValue.CompareTo(comparableThisValue) < 0)
                return left != null ? left.Find(otherValue) : false;
            else
                return right != null ? right.Find(otherValue) : false;
        }


        public bool Add(V newValue)
        {
            IComparable comparableThisValue = (IComparable)this.value;
            IComparable comparableNewValue = (IComparable)newValue;

            if (comparableNewValue.CompareTo(comparableThisValue) < 0)
            {
                if (left == null)
                    left = new TreeNode<V>(newValue);
                else
                    return left.Add(newValue);
            }
            else if (comparableNewValue.CompareTo(comparableThisValue) > 0)
            {
                if (right == null)
                    right = new TreeNode<V>(newValue);
                else
                    return right.Add(newValue);
            }
            else return false;
            return true;
        }

        public void ToList(List<V> list)
        {
            left?.ToList(list);
            list.Add(this.value);
            right?.ToList(list);
        }
    }
}
