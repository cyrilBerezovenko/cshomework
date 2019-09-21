using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework {

	class Program {

		static void Main(string[] args) {
			Begin1();
		}

		static void Begin1() {
			int a = int.Parse(Console.ReadLine());
			int P = 4 * a;
			Console.WriteLine(P);
		}

		static void Begin2() {
			int a = int.Parse(Console.ReadLine());
			int S = a * a;
			Console.WriteLine(S);
		}

		static void Begin3() {
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int S = a * b;
			int P = 2 * (a + b);
			Console.WriteLine(S + " " + P);
		}

		static void Begin4() {
			double d = double.Parse(Console.ReadLine());
			double L = Math.PI * d;
			Console.WriteLine(L);
		}

		static void Begin5() {
			int a = int.Parse(Console.ReadLine());
			int V = a * a * a;
			int S = 6 * a * a;
			Console.WriteLine(V + " " + S);
		}

		static void Begin6() {
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			int V = a * b * c;
			int S = 2 * (a * b + b * c + a * c);
			Console.WriteLine(V + " " + S);
		}

		static void Begin7() {
			double R = double.Parse(Console.ReadLine());
			double L = 2 * Math.PI * R;
			double S = Math.PI * R * R;
			Console.WriteLine(L + " " + S);
		}

		static void Begin8() {
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double average = (a + b) / 2;
			Console.WriteLine(average);
		}

		static void Begin9() {
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double average = Math.Sqrt(a * b);
			Console.WriteLine(average);
		}

		static void Begin10() {
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double a2 = a * a;
			double b2 = b * b;
			Console.WriteLine(a2 + b2);
			Console.WriteLine(a2 - b2);
			Console.WriteLine(a2 * b2);
			Console.WriteLine(a2 / b2);
		}

		static void Begin11() {
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double a_abs = Math.Abs(a);
			double b_abs = Math.Abs(b);
			Console.WriteLine(a_abs + b_abs);
			Console.WriteLine(a_abs - b_abs);
			Console.WriteLine(a_abs * b_abs);
			Console.WriteLine(a_abs / b_abs);
		}

		static void Begin12() {
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double c = Math.Sqrt(a * a + b * b);
			double P = a + b + c;
			Console.WriteLine(c + " " + P);
		}
	
		static void Begin13() {
			double R1 = double.Parse(Console.ReadLine());
			double R2 = double.Parse(Console.ReadLine());
			double S1 = Math.PI * R1 * R1;
			double S2 = Math.PI * R2 * R2;
			double S3 = S1 - S2;
			Console.WriteLine(S1 + " " + S2 + " " + S3);
		}

		static void Begin14() {
			double L = double.Parse(Console.ReadLine());
			double R = L / (2 * Math.PI);
			double S = Math.PI * R * R;
			Console.WriteLine(R + " " + S);
		}

		static void Begin15() {
			double S = double.Parse(Console.ReadLine());
			double R = Math.Sqrt(S / Math.PI);
			double L = 2 * Math.PI * R;
			double D = 2 * R;
			Console.WriteLine(L + " " + D);
		}

		static void Begin16() {
			double x1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double r = Math.Abs(x1 - x2);
			Console.WriteLine(r);
		}

		static void Begin17() {
			double A = double.Parse(Console.ReadLine());
			double B = double.Parse(Console.ReadLine());
			double C = double.Parse(Console.ReadLine());
			double AC = Math.Abs(A - C);
			double BC = Math.Abs(B - C);
			Console.WriteLine(AC + " " + BC + " " + (AC + BC));
		}

		static void Begin18() {
			double A = double.Parse(Console.ReadLine());
			double B = double.Parse(Console.ReadLine());
			double C = double.Parse(Console.ReadLine());
			double AC = Math.Abs(A - C);
			double BC = Math.Abs(B - C);
			double p = AC * BC;
			Console.WriteLine(p);
		}

		static void Begin19() {
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());
			double a = Math.Abs(x1 - x2);
			double b = Math.Abs(y1 - y2);
			double P = 2 * (a + b);
			double S = a * b;
			Console.WriteLine(P + " " + S);
		}

		static double Distance(double x1, double y1, double x2, double y2) {
			return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
		}

		static void Begin20() {
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());
			double r = Distance(x1, y1, x2, y2);
			Console.WriteLine(r);
		}

		static void Begin21() {
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());
			double x3 = double.Parse(Console.ReadLine());
			double y3 = double.Parse(Console.ReadLine());
			double a = Distance(x1, y1, x2, y2);
			double b = Distance(x1, y1, x3, y3);
			double c = Distance(x3, y3, x2, y2);
			double p = (a + b + c) / 2;
			double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
			double P = 2 * p;
			Console.WriteLine(P + " " + S);
		}

		static void Begin22() {
			int A = int.Parse(Console.ReadLine());
			int B = int.Parse(Console.ReadLine());
			A ^= B;
			B ^= A;
			A ^= B;
			Console.WriteLine(A + " " + B);
		}

		static void Begin23() {
			int A = int.Parse(Console.ReadLine());
			int B = int.Parse(Console.ReadLine());
			int C = int.Parse(Console.ReadLine());
			int t = C;
			C = B;
			B = A;
			A = t;
			Console.WriteLine(A + " " + B + " " + C);
		}

		static void Begin24() {
			int A = int.Parse(Console.ReadLine());
			int B = int.Parse(Console.ReadLine());
			int C = int.Parse(Console.ReadLine());
			int t = A;
			A = B;
			B = C;
			C = t;
			Console.WriteLine(A + " " + B + " " + C);
		}

		static void Begin25() {
			double x = double.Parse(Console.ReadLine());
			double y = 3 * Math.Pow(x, 6) - 6 * x * x - 7;
			Console.WriteLine(y);
		}

		static void Begin26() {
			double x = double.Parse(Console.ReadLine());
			double y = y = 4*Math.Pow(x-3, 6) - 7*Math.Pow(x-3, 3) + 2;
			Console.WriteLine(y);
		}

		static void Begin27() {
			int A = int.Parse(Console.ReadLine());
			int t = A * A;
			for(int i = 0; i < 3; i++) {
				Console.Write(t + " ");
				t = t * t;
			}
			Console.WriteLine();
		}

		static void Begin28() {
			int A = int.Parse(Console.ReadLine());
			int t = A * A;
			int u = A * A * A;
			Console.Write(t + " " + u + " ");
			t = t * u;
			u = t * t;
			Console.Write(t + " " + u + " " + t * u);
		}

		static void Begin29() {
			double alpha = double.Parse(Console.ReadLine());
			double rad = alpha / 360 * 2 * Math.PI;
			Console.WriteLine(rad);
		}

		static void Begin30() {
			double alpha = double.Parse(Console.ReadLine());
			double rad = alpha / (2 * Math.PI) * 360;
			Console.WriteLine(rad);
		}

		static void Begin31() {
			double TF = double.Parse(Console.ReadLine());
			double TC = (TF - 32) * 5 / 9;
			Console.WriteLine(TC);
		}

		static void Begin32() {
			double TC = double.Parse(Console.ReadLine());
			double TF = TC * 9 / 5 + 32;
			Console.WriteLine(TF);
		}

		static void Begin33() {
			double A = double.Parse(Console.ReadLine());
			double X = double.Parse(Console.ReadLine());
			double Y = double.Parse(Console.ReadLine());
			double kg = A / X;
			double ykg = kg * Y;
			Console.WriteLine(kg + " " + ykg);
		}

		static void Begin34() {
			double A = double.Parse(Console.ReadLine());
			double B = double.Parse(Console.ReadLine());
			double X = double.Parse(Console.ReadLine());
			double Y = double.Parse(Console.ReadLine());
			double kg1 = A / X;
			double kg2 = B / Y;
			double p = kg2 / kg1;
			Console.WriteLine(kg1 + " " + kg2 + " " + p);
		}

		static void Begin35() {
			double V = double.Parse(Console.ReadLine());
			double U = double.Parse(Console.ReadLine());
			double T1 = double.Parse(Console.ReadLine());
			double T2 = double.Parse(Console.ReadLine());
			double S = T1 * V + T2 * (V - U);
			Console.WriteLine(S);
		}

		static void Begin36() {
			double V1 = double.Parse(Console.ReadLine());
			double V2 = double.Parse(Console.ReadLine());
			double S = double.Parse(Console.ReadLine());
			double T = double.Parse(Console.ReadLine());
			double S0 = S + (V1 + V2) * T;
			Console.WriteLine(S0);
		}

		static void Begin37() {
			double V1 = double.Parse(Console.ReadLine());
			double V2 = double.Parse(Console.ReadLine());
			double S = double.Parse(Console.ReadLine());
			double T = double.Parse(Console.ReadLine());
			double S0 = S + (V1 - V2) * T;
			Console.WriteLine(S0);
		}

		static void Begin38() {
			double A = double.Parse(Console.ReadLine());
			double B = double.Parse(Console.ReadLine());
			double x = -B / A;
			Console.WriteLine(x);
		}

		static void Begin39() {
			double A = double.Parse(Console.ReadLine());
			double B = double.Parse(Console.ReadLine());
			double C = double.Parse(Console.ReadLine());
			double D = B * B - 4 * A * C;
			double x1 = (-B + Math.Sqrt(D)) / (2 * A);
			double x2 = (-B - Math.Sqrt(D)) / (2 * A);
			Console.WriteLine(x1 + " " + x2);
		}

		static void Begin40() {
			double A1 = double.Parse(Console.ReadLine());
			double B1 = double.Parse(Console.ReadLine());
			double C1 = double.Parse(Console.ReadLine());
			double A2 = double.Parse(Console.ReadLine());
			double B2 = double.Parse(Console.ReadLine());
			double C2 = double.Parse(Console.ReadLine());
			double D = A1 * B2 - A2 * B1;
			double x = (C1 * B2 - C2 * B1) / D;
			double y = (A1 * C2 - A2 * C1) / D;
			Console.WriteLine(x + " " + y);
		}
	}
}
