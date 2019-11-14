using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tictactoe {

	class TicGameFactory {

		public TicGame CreateTicGame(string file) {

			XmlSerializer serializer = new XmlSerializer(typeof(TicGame));

			StreamReader reader = new StreamReader(file);
			TicGame game = (TicGame)serializer.Deserialize(reader);
			reader.Close();

			return game;
		}
	}
}
