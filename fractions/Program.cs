using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractions {

	class Program {

		static void Main(string[] args) {
			Fraction a = new Fraction(8, -9);
			Fraction b = new Fraction(-3, 4);
			Console.WriteLine(a + " + " + 1 + " = " + (a + 1));
			Console.WriteLine(a + " + " + b + " = " + (a + b));
			Console.WriteLine(a + " - " + b + " = " + (a - b));
			Console.WriteLine(a + " * " + b + " = " + (a * b));
			Console.WriteLine(a + " / " + b + " = " + (a / b));

			Console.WriteLine("\n-------\n");

			Fraction naturalLogOf2FractionApproximation = 0;
			int n = 21;
			for(int i = 1; i < n; i++) {
				naturalLogOf2FractionApproximation += new Fraction(-1 + 2 * (i % 2), i);
			}
			Console.WriteLine("ln 2 ~ " + naturalLogOf2FractionApproximation);
			Console.WriteLine("ln 2 ~ " + (double)naturalLogOf2FractionApproximation);
			Console.WriteLine();
		}
	}
}
