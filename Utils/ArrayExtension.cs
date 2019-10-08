using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils {

	public static class ArrayExtension {

		public static void Print(this Array array) {
			foreach (var i in array)
				Console.Write(i + " ");
			Console.WriteLine();
		}
	}
}
