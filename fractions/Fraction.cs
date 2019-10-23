using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractions {

	struct Fraction {

		public readonly int numerator;
		public readonly int denominator;

		public Fraction(int numerator) {
			this.numerator = numerator;
			this.denominator = 1;
		}

		public Fraction(int numerator, int denominator) {
			if(denominator == 0) throw new DivideByZeroException();

			int gcd = Gcd(numerator, denominator);
			numerator /= gcd;
			denominator /= gcd;
			if (denominator < 0) {
				denominator *= -1;
				numerator *= -1;
			}

			this.numerator = numerator;
			this.denominator = denominator;
		}

		public Fraction Reciprocal() => new Fraction(denominator, numerator);

		public override String ToString() => numerator + (denominator == 1 ? "" : "/" + denominator);

		public String ToMixedString() {
			if (denominator == 1) return "" + numerator;
			int intPart = (int)this;
			int top = Math.Abs(numerator - intPart * denominator);
			return intPart + " " + top + "/" + denominator;
		}
		
		private static int Gcd(int a, int b) => b == 0 ? a : Gcd(b, a % b);

		private static int Lcm(int a, int b) => Math.Abs(a * b) / Gcd(a, b);

		public static Fraction operator - (Fraction a) => new Fraction(-a.numerator, a.denominator);

		public static Fraction operator + (Fraction a, Fraction b) {
			int lcm = Lcm(a.denominator, b.denominator);
			return new Fraction(a.numerator * (lcm / a.denominator) + b.numerator * (lcm / b.denominator), lcm);
		}

		public static Fraction operator - (Fraction a, Fraction b) => a + (-b);

		public static Fraction operator * (Fraction a, Fraction b) => 
			new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);

		public static Fraction operator / (Fraction a, Fraction b) => a * b.Reciprocal();

		public static implicit operator Fraction(int f) => new Fraction(f, 1);

		public static explicit operator int(Fraction f) => f.numerator / f.denominator;

		public static explicit operator double(Fraction f) => (double)f.numerator / f.denominator;

		public static explicit operator Fraction(double d) {
			double fr = d - Math.Floor(d);
			int len = Convert.ToString(fr).Length - 2;
			int power = (int)Math.Pow(10, len);
			d *= power;
			return new Fraction((int)d, power);
		}
	}
}
