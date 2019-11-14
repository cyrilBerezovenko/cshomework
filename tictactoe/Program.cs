using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe {

	class Program {

		static void Main(string[] args) {
			string file = "../../resources/TicGameConfig.xml";
			TicGameFactory factory = new TicGameFactory();
			TicGame game = factory.CreateTicGame(file);
			game.PlayGame();
		}
	}
}
