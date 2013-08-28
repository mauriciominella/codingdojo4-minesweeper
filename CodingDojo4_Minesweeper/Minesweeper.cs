using System;
using System.Text;
using System.Linq;

namespace CodingDojo4_Minesweeper
{
	public class Minesweeper
	{
		const int width = 4;
		const int height = 4;
		const char blankMark = '.';
		const char bombMark = '*';
		const char blankValue = '0';
		public char[,] Fields { get; private set; }

		public Minesweeper()
		{
			Fields = new char[width,height];
		}

		public void AddBombToFieldAt(int row, int col)
		{
			Fields[row, col] = bombMark;
		}

		public override string ToString()
		{
			var sb = new StringBuilder ();
			GoThroughAllFields (field => sb.Append (field == char.MinValue ? blankMark : field));
			return sb.ToString ();
		}

		public string Solve()
		{
			var sb = new StringBuilder ();
			GoThroughAllFields (field => sb.Append (field == char.MinValue ? blankValue : field));
			return sb.ToString ();
		}

		private void GoThroughAllFields(Action<char> forEachFieldDo)
		{
			for (int row = 0; row < height; row++) {
				for (int col = 0; col < width; col++) {
					forEachFieldDo (Fields [row, col]);
				}
			}
		}
	}
}

