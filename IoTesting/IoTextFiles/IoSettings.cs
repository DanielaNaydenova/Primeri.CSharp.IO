using System;

namespace IoTextFiles
{
	public class IoSettings
	{
		private STable _stable;

		public IoSettings (STable stable)
		{
			_stable = stable;
		}

		public bool save ()
		{
			try 
			{
				string _temp = "";
				_temp = string.Join ("\r\n", _stable.stable);

				//Запис на текстов файл
				System.IO.File.WriteAllText ("C:\\aula\\test.txt", _temp);

				return true;
			}catch{
			}

			return false;
		}
	}
}

