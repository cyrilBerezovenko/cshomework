using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case {

	class Program {

		static void Main(string[] args) => Case1();

		static int ReadInt() => int.Parse(Console.ReadLine());

		static double ReadDouble() => double.Parse(Console.ReadLine());

		static void Write(object obj) => Console.WriteLine(obj);

		static void Case1() {
			int a = ReadInt();
			string s = "";
			switch (a) {
				case 1:
					s = "понедельник"; break;
				case 2:
					s = "вторник"; break;
				case 3:
					s = "среда"; break;
				case 4:
					s = "четверг"; break;
				case 5:
					s = "пятница"; break;
				case 6:
					s = "суббота"; break;
				case 7:
					s = "воскресенье"; break;
			}
			Write(s);
		}

		static void Case2() {
			int a = ReadInt();
			string s;
			switch (a) {
				case 1:
					s = "плохо"; break;
				case 2:
					s = "неудовлетворительно"; break;
				case 3:
					s = "удовлетворительно"; break;
				case 4:
					s = "хорошо"; break;
				case 5:
					s = "отлично"; break;
				default:
					s = "ошибка"; break;
			}
			Write(s);
		}

		static void Case3() {
			int a = ReadInt();
			string s = "";
			switch (a) {
				case 1:
				case 2:
				case 12:
					s = "зима"; break;
				case 3:
				case 4:
				case 5:
					s = "весна"; break;
				case 6:
				case 7:
				case 8:
					s = "лето"; break;
				case 9:
				case 10:
				case 11:
					s = "осень"; break;
			}
			Write(s);
		}

		static void Case4() {
			int a = ReadInt();
			int n;
			switch (a) {
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					n = 31; break;
				case 2:
					n = 28; break;
				default:
					n = 30; break;
			}
			Write(n);
		}

		static void Case5() {
			int n = ReadInt();
			double a = ReadDouble();
			double b = ReadDouble();
			double s = 0;
			switch (n) {
				case 1:
					s = a + b; break;
				case 2:
					s = a - b; break;
				case 3:
					s = a * b; break;
				case 4:
					s = a / b; break;

			}
			Write(s);
		}

		static void Case6() {
			int n = ReadInt();
			double l = ReadDouble();
			switch (n) {
				case 1:
					l *= 10; break;
				case 2:
					l *= 1000; break;
				case 3:
					l *= 1; break;
				case 4:
					l /= 1000; break;
				case 5:
					l /= 100; break;
			}
			Write(l);
		}

		static void Case7() {
			int n = ReadInt();
			double l = ReadDouble();
			switch (n) {
				case 1:
					l *= 1; break;
				case 2:
					l /= 1000000; break;
				case 3:
					l /= 1000; break;
				case 4:
					l *= 1000; break;
				case 5:
					l *= 100; break;
			}
			Write(l);
		}
	}
}
