using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue {

	class MyQueue<T> {

		private class Node {

			public Node next;
			public T value;

			public Node(T value) {
				this.value = value;
			}
		}

		Node start;
		Node end;
		int length;

		public MyQueue(List<T> list) {
			foreach(T value in list)
				Push(value);
		}

		public T Top() =>
			length != 0 ? start.value : throw new InvalidOperationException();

		public T Pop() {
			T value = Top();
			start = start.next;
			--length;
			return value;
		}

		public void Push(T value) {
			Node newNode = new Node(value);
			if (length == 0)
				start = end = newNode;
			else {
				end.next = newNode;
				end = newNode;
			}
			++length;
		}

		public override string ToString() {
			string res = "";
			Node cur = start;
			while(cur != null) {
				res += cur.value + " ";
				cur = cur.next;
			}
			return res.Trim();
		}
	}
}
