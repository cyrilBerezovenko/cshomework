using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace While {

	class Program {

		static void Main(string[] args) => While15();

		static int ReadInt() => int.Parse(Console.ReadLine());

		static double ReadDouble() => double.Parse(Console.ReadLine());

		static void While15() {
			double S = 1000;
			double P = ReadDouble();
			P /= 100;
			int K = 0;
			while(S <= 1100) {
				S *= 1 + P;
				K++;
			}
			Write(K + " " + S);
		}

		static void While16() {
			double S = 10;
			double P = ReadDouble();
			P /= 100;
			int K = 0;
			while (S <= 200) {
				S = S + S * (1 + P);
				K++;
			}
			Write(K + " " + S);
		}

		static void While17() {
			int n = ReadInt();
			while(n > 0) {
				Write(n % 10 + " ");
				n /= 10;
			}
		}

		static void While18() {
			int n = ReadInt();
			int cnt = 0;
			int sum = 0;
			while (n > 0) {
				cnt++;
				sum += n % 10;
				n /= 10;
			}
			WriteLine(sum + " " + cnt);
		}

		static void While19() {
			int n = ReadInt();
			while (n > 0) {
				Write(n % 10);
				n /= 10;
			}
		}

		static void While22() {
			int n = ReadInt();
			if(n % 2 == 0) {
				WriteLine("false");
				return;
			}
			for(int i = 3; i <= Math.Sqrt(n); i += 2) {
				if(n % i == 0) {
					WriteLine("false");
					return;
				}
			}
			WriteLine("true");
		}

		static void While23() {
			int a = ReadInt();
			int b = ReadInt();
			if(b > a) {
				a ^= b; b ^= a; a ^= b;
			}
			while(b > 0) {
				int t = a;
				a = b;
				b = t % b;
			}
			WriteLine(a);
		}

		static void While24() {
			int n = ReadInt();
			int f1 = 1;
			int f2 = 1;
			int f = 2;
			while(f < n) {
				f2 = f1;
				f1 = f;
				f = f1 + f2;
			}
			WriteLine(f == n);
		}

		static void While29() {
			double eps = ReadDouble();
			double a1 = 1;
			double a2 = 2;
			double a = 5 / 3;
			int k = 3;
			if(Math.Abs(a2-a1) < eps) {
				WriteLine("2 " + a1 + a2);
				return;
			}
			while(Math.Abs(a - a2) >= eps) {
				a1 = a2;
				a2 = a;
				a = (a1 + 2 * a2) / 3;
				k++;
			}
			WriteLine(k + " " + a2 + " " + a);
		}

		static void While30() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			int cnt = 0;
			int x = 0;
			int y = 0;
			while(y < a) {
				while(x < b) {
					x += c;
					cnt++;
				}
				y += c;
			}
			WriteLine(cnt);
		}
	}
}
