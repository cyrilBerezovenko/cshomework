using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using static Utils.Generator;
using static Utils.ArrayExtension;

namespace Series {

	class Series {

		static void Main(string[] args) => Series1();

		static void Series1() {
			double[] a = GenerateDoubleArray(10, -1, 1);
			double sum = 0;
			foreach(var i in a) sum += i;
			WriteLine(sum);
		}

		static void Series2() {
			double[] a = GenerateDoubleArray(10, -1, 1);
			double p = 1;
			foreach (var i in a) p *= i;
			WriteLine(p);
		}

		static void Series3() {
			double[] a = GenerateDoubleArray(10, -1, 1);
			double sum = 0;
			foreach (var i in a) sum += i;
			WriteLine(sum / a.Length);
		}

		static void Series4() {
			int N = 10;
			double[] a = GenerateDoubleArray(N, -1, 1);
			double sum = 0;
			double p = 1;
			foreach (var i in a) {
				sum += i;
				p *= i;
			}
			WriteLine(sum + " " + p);
		}

		static void Series5() {
			int N = 10;
			double[] a = GenerateDoubleArray(N, -1, 1);
			double[] ints = a.Select(i => Math.Floor(i)).ToArray();
			ints.Print();
			WriteLine(ints.Sum());
		}

		static void Series6() {
			int N = 10;
			double[] a = GenerateDoubleArray(N, -1, 1);
			double[] ints = a.Select(i => i - Math.Floor(i)).ToArray();
			ints.Print();
			WriteLine(ints.Sum());
		}

		static void Series7() {
			int N = 10;
			double[] a = GenerateDoubleArray(N, -1, 1);
			double[] ints = a.Select(i => Math.Round(i)).ToArray();
			ints.Print();
			WriteLine(ints.Sum());
		}

		static void Series8() {
			int N = 10;
			int[] a = GenerateIntArray(N, -10, 10);
			int[] even = a.Where(i => i % 2 == 0).ToArray();
			WriteLine(even.Length);
			even.Print();
		}

		static void Series9() {
			int N = 10;
			int[] a = GenerateIntArray(N, -10, 10);
			int[] odd = a.Where(i => i % 2 == 1).ToArray();
			WriteLine(odd.Length);
			odd.Print();
		}

		static void Series10() {
			int N = 10;
			int[] a = GenerateIntArray(N, -10, 10);
			WriteLine(a.Any(i => i > 0));
		}

		static void Series11() {
			int N = 10;
			int K = 6;
			int[] a = GenerateIntArray(N, -10, 10);
			WriteLine(a.Any(i => i < K));
		}

		static void Series12() {
			int cnt = 0;
			int cur = GetInt(-5, 5);
			while(cur != 0) {
				cnt++;
				cur = GetInt(-5, 5);
			}
			WriteLine(cnt);
		}

		static void Series13() {
			int cnt = 0;
			int sum = 0;
			int cur = GetInt(-5, 5);
			while (cur != 0) {
				cnt++;
				sum += cur * Convert.ToInt32(cur > 0 && cur % 2 == 0);
				cur = GetInt(-5, 5);
			}
			WriteLine(cnt);
		}

		static void Series14() {
			int K = GetInt(-5, 5);
			int cnt = 0;
			int cur = GetInt(-5, 5);
			while (cur != 0) {
				cnt += Convert.ToInt32(cur < K);
				cur = GetInt(-5, 5);
			}
			WriteLine(cnt);
		}

		static void Series15() {
			int K = GetInt(-5, 5);
			int cnt = 0;
			int cur = GetInt(-5, 5);
			while (cur != 0) {
				if(cur > K) {
					WriteLine(cnt);
					return;
				}
				++cnt;
				cur = GetInt(-5, 5);
			}
			WriteLine(0);
		}
	}
}
