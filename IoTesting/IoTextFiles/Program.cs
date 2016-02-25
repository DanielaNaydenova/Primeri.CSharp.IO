using System;

namespace IoTextFiles
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			STable _STable = new STable ();
			IoSettings _io = new IoSettings (_STable);


			if (_io.open ()) {		//_io.save ()) {
				Console.WriteLine ("Таблицата е прочетена успешно.");
			} else {
				Console.WriteLine ("Таблицата НЕ е прочетена.");

			}
			Console.WriteLine (_STable.stable [2]);
		}
	}
}
