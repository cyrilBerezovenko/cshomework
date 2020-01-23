using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Queue {

	class Program {

		static void Main(string[] args) {
			List<int> list = new List<int> { 3, 5, 2, 666, -1, -1 };
			MyQueue<int> queue = new MyQueue<int>(list);
			WriteLine(queue);

			WriteLine(queue.Top());
			WriteLine(queue.Pop());
			WriteLine(queue.Pop());

			queue.Push(12);
			queue.Push(21);

			WriteLine(queue);
		}
	}
}
