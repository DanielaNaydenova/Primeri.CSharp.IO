using System;

namespace IoTextFiles
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			STable _STable = new STable ();
			IoSettings _io = new IoSettings (_STable);

			Console.WriteLine (_STable.stable [0]);

			if (_io.save ()) {
				Console.WriteLine ("Таблицата е запаметена успешно.");
			} else {
				Console.WriteLine ("Таблицата НЕ е запаметена.");

			}
		}
	}
}
