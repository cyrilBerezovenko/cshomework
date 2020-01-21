using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree {

	class TreeNode<V> where V : IComparable<V> {

		private TreeNode<V> left;
		private TreeNode<V> right;

		public V value { get; private set; }

		public TreeNode(V value) {
			this.value = value;
			left = null;
			right = null;
		}

		public bool Find(V otherValue) {
			IComparable comparableThisValue = (IComparable)this.value;
			IComparable comparableOtherValue = (IComparable)otherValue;

			if (comparableOtherValue.CompareTo(comparableThisValue) == 0)
				return true;
			else if (comparableOtherValue.CompareTo(comparableThisValue) < 0) 
				return left != null ? left.Find(otherValue) : false;
			else 
				return right != null ? right.Find(otherValue) : false;
		}


		public void Add(V newValue) {
			IComparable comparableThisValue = (IComparable)this.value;
			IComparable comparableNewValue = (IComparable)newValue;

			if (comparableNewValue.CompareTo(comparableThisValue) < 0) {
				if (left == null)
					left = new TreeNode<V>(newValue);
				else
					left.Add(newValue);
			} else {
				if(right == null)
					right = new TreeNode<V>(newValue);
				else
					right.Add(newValue);
			}
		}

		public void ToList(List<V> list) {
			left?.ToList(list);
			list.Add(this.value);
			right?.ToList(list);
		}
	}
}
