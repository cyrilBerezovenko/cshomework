using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer {

	class Program {

		static int ReadInt() => int.Parse(Console.ReadLine());

		static void Write(object obj) => Console.WriteLine(obj);

		static void Integer1() {
			int L = ReadInt();
			int lm = L / 100;
			Write(lm);
		}

		static void Integer2() {
			int M = ReadInt();
			int r = M / 1000;
			Write(r);
		}

		static void Integer3() {
			int b = ReadInt();
			int kb = b / 1024;
			Write(kb);
		}

		static void Integer4() {
			int a = ReadInt();
			int b = ReadInt();
			Write(a / b);
		}

		static void Integer5() {
			int a = ReadInt();
			int b = ReadInt();
			Write(a % b);
		}

		static void Integer6() {
			int a = ReadInt();
			Write(a / 10 + " " + a % 10);
		}

		static void Integer7() {
			int a = ReadInt();
			int b = a / 10;
			int c = a % 10;
			Write((b + c) + " " + (b * c));
		}

		static void Integer8() {
			int a = ReadInt();
			int b = a / 10;
			int c = a % 10;
			Write(c + " " + b);
		}

		static void Integer9() {
			int a = ReadInt();
			Write(a / 100);
		}

		static void Integer10() {
			int a = ReadInt();
			Write((a % 10) + " " + ((a / 10) % 10));
		}

		static void Integer11() {
			int a = ReadInt();
			int b = a / 100;
			int c = (a / 10) % 10;
			int d = a % 10;
			Write((b + c + d) + " " + (b * c * d));
		}

		static void Integer12() {
			int a = ReadInt();
			int b = a / 100;
			int c = (a / 10) % 10;
			int d = a % 10;
			Write("" + d + c + b);
		}

		static void Integer13() {
			int a = ReadInt();
			int d = a / 100;
			Write((a - d * 100) * 10 + d);
		}

		static void Integer14() {
			int a = ReadInt();
			int d = a % 10;
			Write(d*100 + a/10);
		}

		static void Integer15() {
			int a = ReadInt();
			int b = a / 100;
			int c = (a / 10) % 10;
			Write(c*100 + b*10 + (a%10));
		}

		static void Integer16() {
			int a = ReadInt();
			int b = a % 10;
			int c = (a / 10) % 10;
			int d = a / 100;
			Write(d*100 + b*10 + c);
		}

		static void Integer17() {
			int a = ReadInt();
			Write((a / 100) % 10);
		}

		static void Integer18() {
			int a = ReadInt();
			Write((a / 1000) % 10);
		}

		static void Integer19() {
			int N = ReadInt();
			Write(N / 60);
		}

		static void Integer20() {
			int N = ReadInt();
			Write(N / 3600);
		}

		static void Integer21() {
			int N = ReadInt();
			Write(N % 60);
		}

		static void Integer22() {
			int N = ReadInt();
			Write(N % 3600);
		}

		static void Integer23() {
			int N = ReadInt();
			Write((N / 60) % 60);
		}

		static void Integer24() {
			int K = ReadInt();
			Write(K % 7);
		}

		static void Integer25() {
			int K = ReadInt();
			K += 3;
			Write(K % 7);
		}

		static void Integer26() {
			int K = ReadInt();
			Write((K % 7) + 1);
		}

		static void Integer27() {
			int K = ReadInt();
			K += 4;
			Write((K % 7) + 1);
		}

		static void Integer28() {
			int K = ReadInt();
			int N = ReadInt();
			K += Math.Max(0, N - 2);
			Write((K % 7) + 1);
		}

		static void Integer29() {
			int A = ReadInt();
			int B = ReadInt();
			int C = ReadInt();
			int n = (A / C) * (B / C);
			int s = C * C * n;
			Write(n + " " + s);
		}

		static void Integer30() {
			int n = ReadInt();
			Write(n/100 + Convert.ToInt32(n % 100 != 0));
		}

		static void Main(string[] args) => Integer30();
	}
}
