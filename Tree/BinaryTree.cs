using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree {

	class BinaryTree<V> where V : IComparable<V> {

		TreeNode<V> root = null;
		long length = 0;

		public BinaryTree() {}

		public BinaryTree(List<V> list) {
			foreach (V el in list)
				Add(el);
		}

		public override string ToString() =>
			string.Join(" ", ToList());

		public bool Find(V value) => 
			root != null ? root.Find(value) : false;

		public List<V> ToList() {
			List<V> list = new List<V>();
			root?.ToList(list);
			return list;
		}

		public void Add(V newValue) {
			if (root == null)
				root = new TreeNode<V>(newValue);
			else
				root.Add(newValue);
			++length;
		}
	}
}
