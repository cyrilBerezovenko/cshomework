using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace For {

	class Program {

		static void Main(string[] args) => For29();

		static int ReadInt() => int.Parse(Console.ReadLine());

		static double ReadDouble() => double.Parse(Console.ReadLine());

		static void For25() {
			double X = ReadDouble();
			double N = ReadInt();
			double ln = 0;
			double product = X;
			for(int i = 1; i <= N; i++) {
				ln += (i % 2 == 1 ? 1 : -1) * product / i;
				product *= X;
			}
			WriteLine(ln);
		}

		static void For29() {
			int N = ReadInt();
			double A = ReadDouble();
			double B = ReadDouble();
			double H = (B - A) / N;
			WriteLine(H);
			for (int i = 0; i <= N; i++) Write(A + i * H + " ");
		}

		static void For30() {
			int N = ReadInt();
			double A = ReadDouble();
			double B = ReadDouble();
			double H = (B - A) / N;
			WriteLine(H);
			for (int i = 0; i <= N; i++) Write(1 - Math.Sin(A + i * H) + " ");
		}

		static void For31() {
			int N = ReadInt();
			double An = 0;
			for(int i = 1; i <= N; i++) {
				An = 2 + 1 / An;
				Write(An + " ");
			}
		}

		static void For35() {
			int N = ReadInt();
			double A1 = 1;
			double A2 = 2;
			double A3 = 3;
			double A;
			Write(A1 + " " + A2 + " " + A3);
			for (int i = 1; i <= N; i++) {
				A = A1 + A2 - 2 * A3;
				Write(A + " ");
				A3 = A2;
				A2 = A1;
				A1 = A;
			}
		}

		static void For36() {
			double N = ReadDouble();
			double K = ReadDouble();
			double sum = 0;
			for(int i = 1; i <= N; i++) {
				sum += Math.Pow(i, K);
			}
			WriteLine(sum);
		}

		static void For37() {
			double N = ReadDouble();
			double sum = 0;
			for (int i = 1; i <= N; i++) {
				sum += Math.Pow(i, i);
			}
			WriteLine(sum);
		}

		static void For38() {
			double N = ReadDouble();
			double sum = 0;
			for (int i = 1; i <= N; i++) {
				sum += Math.Pow(i, N-i+1);
			}
			WriteLine(sum);
		}

		static void For39() {
			int A = ReadInt();
			int B = ReadInt();
			for(int i = A; i <= B; i++) {
				for (int j = 0; j < i; j++) Write(i + " ");
				WriteLine();
			}
		}

		static void For40() {
			int A = ReadInt();
			int B = ReadInt();
			for (int i = A; i <= B; i++) {
				for (int j = 0; j < i-A+1; j++) Write(i + " ");
				WriteLine();
			}
		}
	}
}
