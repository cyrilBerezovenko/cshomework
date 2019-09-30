using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean {

	class Program {

		static void Main(string[] args) => Boolean1();

		static int ReadInt() => int.Parse(Console.ReadLine());

		static void Write(object obj) => Console.WriteLine(obj);

		static void Boolean1() {
			int A = ReadInt();
			Console.WriteLine(A > 0);
		}

		static void Boolean2() {
			int A = ReadInt();
			Write(Convert.ToBoolean(A % 2));
		}

		static void Boolean3() {
			int A = ReadInt();
			Write(!Convert.ToBoolean(A % 2));
		}

		static void Boolean4() {
			int A = ReadInt();
			int B = ReadInt();
			Write(A > 2 && B <= 3);
		}

		static void Boolean5() {
			int A = ReadInt();
			int B = ReadInt();
			Write(A >= 0 && B < -2);
		}

		static void Boolean6() {
			int A = ReadInt();
			int B = ReadInt();
			int C = ReadInt();
			Write(A < B && B < C);
		}

		static void Boolean7() {
			int A = ReadInt();
			int B = ReadInt();
			int C = ReadInt();
			Write(A <= B && B <= C);
		}

		static void Boolean8() {
			int A = ReadInt();
			int B = ReadInt();
			Write(Convert.ToBoolean((A % 2) & (B % 2)));
		}

		static void Boolean9() {
			int A = ReadInt();
			int B = ReadInt();
			Write(Convert.ToBoolean((A % 2) | (B % 2)));
		}

		static void Boolean10() {
			int A = ReadInt();
			int B = ReadInt();
			Write(Convert.ToBoolean((A % 2) ^ (B % 2)));
		}

		static void Boolean11() {
			int A = ReadInt();
			int B = ReadInt();
			Write(!Convert.ToBoolean((A % 2) ^ (B % 2)));
		}

		static void Boolean12() {
			int A = ReadInt();
			int B = ReadInt();
			int C = ReadInt();
			Write(A > 0 && B > 0 && C > 0);
		}

		static void Boolean13() {
			int A = ReadInt();
			int B = ReadInt();
			int C = ReadInt();
			Write(A > 0 || B > 0 || C > 0);
		}

		static void Boolean14() {
			int A = ReadInt();
			int B = ReadInt();
			int C = ReadInt();
			Write((A > 0) ^ (B > 0) ^ (C > 0));
		}

		static void Boolean15() {
			int A = ReadInt();
			int B = ReadInt();
			int C = ReadInt();
			Write((A <= 0) ^ (B <= 0) ^ (C <= 0));
		}

		static void Boolean16() {
			int a = ReadInt();
			Write(a / 100 == 0 && a / 10 != 0 && a % 2 == 0);
		}

		static void Boolean17() {
			int a = ReadInt();
			Write(a / 1000 == 0 && a / 100 != 0 && a % 2 != 0);
		}

		static void Boolean18() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			Write(a == b || b == c || a == c);
		}

		static void Boolean19() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			Write(a*b < 0 || b*c < 0 || a*c < 0);
		}

		static void Boolean20() {
			int a = ReadInt();
			int d1 = a / 100;
			int d2 = (a / 10) % 10;
			int d3 = a % 10;
			Write(d1 != d2 && d2 != d3);
		}

		static void Boolean21() {
			int a = ReadInt();
			int d1 = a / 100;
			int d2 = (a / 10) % 10;
			int d3 = a % 10;
			Write(d1 <= d2 && d2 <= d3);
		}

		static void Boolean22() {
			int a = ReadInt();
			int d1 = a / 100;
			int d2 = (a / 10) % 10;
			int d3 = a % 10;
			Write(d1 <= d2 && d2 <= d3 || d1 >= d2 && d2 >= d3);
		}

		static void Boolean23() {
			int a = ReadInt();
			int d1 = a / 1000;
			int d2 = (a / 100) % 10;
			int d3 = (a / 10) % 10;
			int d4 = a % 10;
			Write(d1 == d4 && d2 == d3);
		}

		static void Boolean24() {
			int A = ReadInt();
			int B = ReadInt();
			int C = ReadInt();
			int D = B * B - 4 * A * C;
			Write(D >= 0);
		}

		static void Boolean25() {
			int x = ReadInt();
			int y = ReadInt();
			Write(x <= 0 && y >= 0);
		}

		static void Boolean26() {
			int x = ReadInt();
			int y = ReadInt();
			Write(x >= 0 && y <= 0);
		}

		static void Boolean27() {
			int x = ReadInt();
			int y = ReadInt();
			Write(x <= 0);
		}

		static void Boolean28() {
			int x = ReadInt();
			int y = ReadInt();
			Write(x * y >= 0);
		}

		static void Boolean29() {
			int x = ReadInt();
			int y = ReadInt();
			int x1 = ReadInt();
			int y1 = ReadInt();
			int x2 = ReadInt();
			int y2 = ReadInt();
			Write(x1 <= x && x <= x2 && y1 <= y && y <= y2);
		}

		static void Boolean30() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			Write(a == b && b == c);
		}

		static void Boolean31() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			Write(a == b || b == c || a == c);
		}

		static void Boolean32() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			Write(a*a == b*b + c*c ||
				  b*b == a*a + c*c ||
				  c*c == a*a + b*b);
		}

		static void Boolean33() {
			int a = ReadInt();
			int b = ReadInt();
			int c = ReadInt();
			Write(a < b + c && b < a + c && c < a + b);
		}

		static void Boolean34() {
			int x = ReadInt();
			int y = ReadInt();
			Write(Convert.ToBoolean((x + y) % 2));
		}

		static void Boolean35() {
			int x = ReadInt();
			int y = ReadInt();
			int x1 = ReadInt();
			int y1 = ReadInt();
			Write(((x + y) % 2) == ((x1 + y1) % 2));
		}

		static void Boolean36() {
			int x = ReadInt();
			int y = ReadInt();
			int x1 = ReadInt();
			int y1 = ReadInt();
			Write(x == x1 || y == y1);
		}

		static void Boolean37() {
			int x = ReadInt();
			int y = ReadInt();
			int x1 = ReadInt();
			int y1 = ReadInt();
			Write(Math.Abs(x-x1) < 2 && Math.Abs(y-y1) < 2);
		}

		static void Boolean38() {
			int x = ReadInt();
			int y = ReadInt();
			int x1 = ReadInt();
			int y1 = ReadInt();
			Write(Math.Abs(x - x1) == Math.Abs(y - y1));
		}

		static void Boolean39() {
			int x = ReadInt();
			int y = ReadInt();
			int x1 = ReadInt();
			int y1 = ReadInt();
			Write(Math.Abs(x - x1) == Math.Abs(y - y1)
				  || x == x1 || y == y1);
		}

		static void Boolean40() {
			int x = ReadInt();
			int y = ReadInt();
			int x1 = ReadInt();
			int y1 = ReadInt();
			Write(Math.Abs(x - x1) == 2 && Math.Abs(y - y1) == 1
				  || Math.Abs(x - x1) == 1 && Math.Abs(y - y1) == 2);
		}
	}
}
