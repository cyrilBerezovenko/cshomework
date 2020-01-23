using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue {

	class MyQueue<T> {

		private const int initLength = 100;

		private T[] array;

		public int Length { get; private set; }

		private int _start;
		private int start {
			get => _start;
			set {
				_start = value;
				Length = _end - _start;
			}
		}

		private int _end;
		private int end {
			get => _end;
			set {
				_end = value;
				Length = _end - _start;
			}
		}

		public MyQueue() {
			array = new T[initLength];
			start = 0;
			end = 0;
			Length = 0;
		}

		public MyQueue(List<T> list) {
			array = list.ToArray();
			start = 0;
			end = array.Length;
			Length = array.Length;
		}

		public bool IsEmpty() => Length == 0;

		public T Top() => 
			!IsEmpty() ? array[start  ] : throw new InvalidOperationException();

		public T Pop() =>
			!IsEmpty() ? array[start++] : throw new InvalidOperationException();

		public void Push(T value) {
			if (end == array.Length)
				Enlarge();
			array[end++] = value;
		}

		private void Enlarge() {
			T[] newArray = new T[end * 2 + 1];
			for (int i = 0; i < end; i++)
				newArray[i] = array[i];
			array = newArray;
		}

		public override string ToString() =>
			"[ " + string.Join(", ", array.Skip(start).Take(Length).ToArray()) + " ]";
	}
}
