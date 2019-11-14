using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace tictactoe {

	[Serializable]
	[System.Xml.Serialization.XmlRoot("TicGame")]
	public class TicGame {

		
		public int size;
		public int players;

		public string initMessage;

		public string pauseMessage;
		public string winMessage;
		public string drawMessage;

		public XmlSerializableDictionary<string, int> keyMapping;

		public XmlSerializableDictionary<int, string> symbolMapping;

		public int[][] wins = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 },
								new int[] { 7, 8, 9 }, new int[] { 1, 4, 7 },
								new int[] { 2, 5, 8 }, new int[] { 3, 6, 9 },
								new int[] { 1, 5, 9 }, new int[] { 3, 5, 7 } }; // todo to xml

		char[] table;
		bool isGameOver = false;
		string gameOverMessage;
		int currentPlayer = 0;

		public void PlayGame() {
			Start();
			while (!isGameOver)
				Update();
			Console.WriteLine(gameOverMessage);
		}

		void Start() {
			Console.WriteLine(initMessage);
			Pause();
			InitTable();
		}

		void Update() {
			Render();

			char input = GetInput();
			if(!IsValidInput(input)) 
				return;
			

			int keyIndex = keyMapping[""+input];
			char symbol = symbolMapping[currentPlayer][0];
			table[keyIndex] = symbol;

			char? winner = FindWinner();
			if (winner.HasValue) {
				gameOverMessage = string.Format(winMessage, winner);
				isGameOver = true;
				Render();
				return;
			}

			if (IsDraw()) {
				gameOverMessage = drawMessage;
				isGameOver = true;
				Render();
				return;
			}

			NextPlayer();
		}

		void Render() {
			ClearOutput();

			for (int line = 0; line < size; line++) {
				for (int char_index = 1; char_index <= size; char_index++) {
					Console.Write(table[line * size + char_index]);
				}
				Console.WriteLine();
			}
		}

		char? FindWinner() {
			char? winner = null;

			foreach (int[] win in wins) {
				if (table[win[0]] == '.') continue;
				if (win.All(index => table[index] == table[win[0]])) {
					winner = table[win[0]];
					break;
				}
			}

			return winner;
		}

		void InitTable() {
			table = new char[size * size + 1];
			for (int index = 0; index < table.Length; index++)
				table[index] = '.';
		}

		void Pause() {
			Console.WriteLine(pauseMessage);
			Console.ReadLine();
		}

		bool IsDraw() => table.Skip(1).All(key => key != '.');

		void ClearOutput() => Console.Clear();

		char GetInput() => Char.ToLower(Console.ReadKey().KeyChar);

		void NextPlayer() => currentPlayer = (currentPlayer + 1) % players;

		bool IsValidInput(char input) =>
			keyMapping.ContainsKey(""+input) && table[keyMapping[""+input]] == '.';
	}
}
