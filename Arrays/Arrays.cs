using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using static Utils.Generator;
using static Utils.ArrayExtension;

namespace Arrays {

	class Arrays {

		static void Main(string[] args) => Arrays1();

		static void Arrays1() {
			int N = GetInt(1, 20);
			int[] a = new int[N];
			for (int i = 0; i < N; i++)
				a[i] = 2 * i + 1;
			a.Print();
		}

		static void Arrays2() {
			int N = GetInt(1, 20);
			int[] a = new int[N];
			for (int i = 0; i < N; i++)
				a[i] = 1 << (i+1);
			a.Print();
		}

		static void Arrays3() {
			int N = GetInt(2, 20);
			int A = GetInt(-19, 19);
			int D = GetInt(-5, 5);
			int[] a = new int[N];
			a[0] = A;
			for(int i = 1; i < N; i++) {
				a[i] = a[i - 1] + D;
			}
			a.Print();
		}

		static void Arrays4() {
			int N = GetInt(2, 20);
			int A = GetInt(-19, 19);
			int D = GetInt(-5, 5);
			int[] a = new int[N];
			a[0] = A;
			for (int i = 1; i < N; i++) {
				a[i] = a[i - 1] * D;
			}
			a.Print();
		}

		static void Arrays5() {
			int N = GetInt(3, 20);
			int[] f = new int[N];
			f[0] = 1;
			f[1] = 1;
			for (int i = 2; i < N; i++)
				f[i] = f[i - 1] + f[i - 2];
			f.Print();
		}

		static void Arrays6() {
			int N = GetInt(3, 20);
			int A = GetInt(-10, 10);
			int B = GetInt(-10, 10);
			int[] a = new int[N];
			a[0] = A;
			a[1] = B;
			a[2] = A + B;
			for (int i = 3; i < N; i++)
				a[i] = 2 * a[i - 1];
			a.Print();
		}

		static void Arrays7() {
			int N = GetInt(1, 20);
			int[] a = GenerateIntArray(N);
			for (int i = N - 1; i >= 0; i--)
				Write(a[i] + " ");
			WriteLine();
		}

		static void Arrays8() {
			int N = GetInt(1, 20); ;
			int[] a = GenerateIntArray(N);
			int[] odd = a.Where(i => i % 2 == 1).ToArray();
			WriteLine(odd.Length);
			odd.Print();
		}

		static void Arrays9() {
			int N = GetInt(1, 20);
			int[] a = GenerateIntArray(N);
			int[] even = a.Where(i => i % 2 == 0).ToArray();
			WriteLine(even.Length);
			even.Print();
		}

		static void Arrays10() {
			int N = 10;
			int[] a = GenerateIntArray(N);
			int[] odd = a.Where(i => i % 2 == 1).ToArray();
			int[] even = a.Where(i => i % 2 == 0).ToArray();
			WriteLine(odd.Length);
			odd.Print();
			WriteLine(even.Length);
			even.Print();
		}

		static void Arrays11() {
			int N = GetInt(1, 20);
			int K = GetInt(1, 20);
			int[] a = GenerateIntArray(N);
			for (int i = K; i < N; i += K)
				Write(a[i] + " ");
			WriteLine();
		}

		static void Arrays12() {
			int N = 2*GetInt(1, 20);
			int K = GetInt(1, 20);
			int[] a = GenerateIntArray(N);
			for (int i = 0; i < N; i += 2)
				Write(a[i] + " ");
			WriteLine();
		}

		static void Arrays13() {
			int N = 2 * GetInt(1, 20) + 1;
			int K = GetInt(1, 20);
			int[] a = GenerateIntArray(N);
			for (int i = N; i >= 0; i -= 2)
				Write(a[i] + " ");
			WriteLine();
		}

		static void Arrays14() {
			int N = GetInt(1, 20);
			int K = GetInt(1, 20);
			int[] a = GenerateIntArray(N);
			for (int i = 0; i < N; i += 2)
				Write(a[i] + " ");
			WriteLine();
			for (int i = 1; i < N; i += 2)
				Write(a[i] + " ");
			WriteLine();
		}

		static void Arrays15() {
			int N = GetInt(1, 20);
			int K = GetInt(1, 20);
			int[] a = GenerateIntArray(N);
			for (int i = 1; i < N; i += 2)
				Write(a[i] + " ");
			WriteLine();
			for (int i = N - (N % 2); i >= 0; i -= 2)
				Write(a[i] + " ");
			WriteLine();
		}
	}
}
