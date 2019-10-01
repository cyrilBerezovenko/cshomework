using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If {

	class Program {

		static void Main(string[] args) => If1();

		static int ReadInt() => int.Parse(Console.ReadLine());

		static double ReadDouble() => double.Parse(Console.ReadLine());

		static void Write(object obj) => Console.WriteLine(obj);

		static void If1() {
			int a = ReadInt();
			if (a > 0) ++a;
			Write(a);
		}

		static void If2() {
			int a = ReadInt();
			if (a > 0) ++a;
			else a -= 2;
			Write(a);
		}

		static void If3() {
			int a = ReadInt();
			if (a > 0) ++a;
			else if (a < 0) a -= 2;
			else a = 10;
			Write(a);
		}

		static void If4() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			int s = Convert.ToInt32(a > 0)
				+ Convert.ToInt32(b > 0)
				+ Convert.ToInt32(c > 0);
			Write(s);
		}

		static void If5() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			int s = Convert.ToInt32(a > 0)
				+ Convert.ToInt32(b > 0)
				+ Convert.ToInt32(c > 0);
			int ss = Convert.ToInt32(a < 0)
				+ Convert.ToInt32(b < 0)
				+ Convert.ToInt32(c < 0);
			Write(s + " " + ss);
		}

		static void If6() {
			int a = ReadInt();
			int b = ReadInt();
			Write(a > b ? a : b);
		}

		static void If7() {
			int a = ReadInt();
			int b = ReadInt();
			Write(a < b ? 0 : 1);
		}

		static void If8() {
			int a = ReadInt();
			int b = ReadInt();
			if(b > a) {
				a ^= b;
				b ^= a;
				a ^= b;
			}
			Write(a + " " + b);
		}

		static void If9() {
			double A = ReadDouble();
			double B = ReadDouble();
			if(B - A < 1e-6) {
				double t = A;
				A = B;
				B = t;
			}
			Write(A + " " + B);
		}

		static void If10() {
			int A = ReadInt();
			int B = ReadInt();
			if (A == B) A = B = 0;
			else A = (B = A + B);
			Write(A + " " + B);
		}

		static void If11() {
			int A = ReadInt();
			int B = ReadInt();
			if (A == B) A = B = 0;
			else A = (B = Math.Max(A,B));
			Write(A + " " + B);
		}

		static void If12() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			Write(Math.Min(a, Math.Min(b, c)));
		}

		static void If13() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			int mx = Math.Max(a, Math.Max(b, c));
			int mn = Math.Min(a, Math.Min(b, c));
			Write(a + b + c - mx - mn);
		}

		static void If14() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			int mx = Math.Max(a, Math.Max(b, c));
			int mn = Math.Min(a, Math.Min(b, c));
			Write(mn + " " + mx);
		}

		static void If15() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			int mn = Math.Min(a, Math.Min(b, c));
			Write(a + b + c - mn);
		}

		static void If16() {
			double a = ReadDouble();
			double b = ReadDouble();
			double c = ReadDouble();
			if (a - b < 1e-6 && b - c < 1e-6) {
				a *= 2; b *= 2; c *= 2;
			} else {
				a = -a; b = -b; c = -c;
			}
			Write(a + " " + b + " " + c);
		}

		static void If17() {
			double a = ReadDouble();
			double b = ReadDouble();
			double c = ReadDouble();
			if (a - b < 1e-6 && b - c < 1e-6 || a - b > -1e-6 && b - c > -1e-6) {
				a *= 2; b *= 2; c *= 2;
			} else {
				a = -a; b = -b; c = -c;
			}
			Write(a + " " + b + " " + c);
		}

		static void If18() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			Write(a == b ? 2 : a == c ? 1 : 0);
		}

		static void If19() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			int d = ReadInt();
			Write(a == b ? (c == a ? 3 : 2) : (a == c ? 1 : 0));
		}

		static void If20() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			int ba = Math.Abs(a - b);
			int ca = Math.Abs(a - c);
			Write(ba < ca ? ba : ca);
		}

		static void If21() {
			int x = ReadInt();
			int y = ReadInt();
			int a;
			if (x == 0 && y == 0) a = 0;
			else if (x == 0) a = 2;
			else if (y == 0) a = 1;
			else a = 3;
			Write(a);
		}

		static void If22() {
			int x = ReadInt();
			int y = ReadInt();
			Write(x * y > 0 ? (x > 0 ? 1 : 3) : (x > 0 ? 4 : 2));
		}

		static void If23() {
			int x1 = ReadInt();
			int y1 = ReadInt();
			int x2 = ReadInt();
			int y2 = ReadInt();
			int x3 = ReadInt();
			int y3 = ReadInt();
			int x4 = x1 == x2 ? x3 : (x2 == x3 ? x1 : x2);
			int y4 = y1 == y2 ? y3 : (y2 == y3 ? y1 : y2);
			Write(x4 + " " + y4);
		}

		static void If24() {
			double x = ReadDouble();
			double f = x > 0 ? 2 * Math.Sin(x) : 6 - x;
			Write(f);
		}

		static void If25() {
			double x = ReadDouble();
			double f = x < -2 || x > 2 ? 2 * x : -3 * x;
			Write(f);
		}

		static void If26() {
			double x = ReadDouble();
			double f = x <= 0 ? -x : (x >= 2 ? 4 : x * x);
			Write(f);
		}

		static void If27() {
			double x = ReadDouble();
			double f = x < 0 ? 0 : (Convert.ToInt32(Math.Floor(x)) % 2 == 1 ? -1 : 1);
			Write(f);
		}

		static void If28() {
			int n = ReadInt();
			Write(365 + Convert.ToInt32(n % 4 == 0 && n % 100 != 0 && n % 400 != 0));
		}

		static void If29() {
			int n = ReadInt();
			if(n == 0) {
				Write("нулевое число");
				return;
			}
			Write(n > 0 ? "положительное " : "отрицательное ");
			if (n % 2 == 1) Write("не");
			Write("четное число");
		}

		static void If30() {
			int n = ReadInt();
			if (n % 2 == 1) Write("не");
			Write("четное ");
			Write(n / 100 > 0 ? "трех" : (n / 10 > 0 ? "двух" : "одно"));
			Write("значное число");
		}
	}
}
