using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils {

    public static class Generator {

		private static Random random;

		public static Random GetRandom() {
			if (random == null) random = new Random();
			return random;
		}

		public static int GetInt(int min, int max) {
			Random random = GetRandom();
			return random.Next(min, max);
		}

		public static double GetDouble(double min, double max) {
			Random random = GetRandom();
			return min + random.NextDouble() * (max - min);
		}

		public static int[] GenerateIntArray(int length, int min = -100, int max = 100) {
			int[] array = new int[length];
			for(int i = 0; i < length; i++) {
				array[i] = GetInt(min, max);
			}
			return array;
		}

		public static double[] GenerateDoubleArray(int length, double min = -100.0, double max = 100.0) {
			double[] array = new double[length];
			for (int i = 0; i < length; i++) {
				array[i] = GetDouble(min, max);
			}
			return array;
		}
	}
}
