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

		public string getPath ()
		{
			//Програма\Settings\settings.txt
			string _path = System.IO.Path.Combine (AppDomain.CurrentDomain.BaseDirectory, "Settings");
			_path = System.IO.Path.Combine (_path, "settings.txt");

			//Други видове директории
			//string _user = Environment.GetFolderPath (Environment.SpecialFolder.LocalApplicationData); 	
			//Console.WriteLine (_user);

			//string _desktop = Environment.GetFolderPath ( Environment.SpecialFolder.Desktop);				
			//Console.WriteLine (_desktop);

			return _path;
		}

		public bool save ()
		{
			try 
			{
				string _temp = "";
				_temp = string.Join ("\r\n", _stable.stable);

				//Запис на текстов файл
				System.IO.File.WriteAllText (getPath (), _temp);

				return true;
			}catch{
			}

			return false;
		}

		public bool open ()
		{
			try
			{
				iniSettings ();

				string _temp = "", _filePath = getPath () ;

				if (System.IO.File.Exists (_filePath)) 	//Проверка дали пътят е валиден
				{
					System.IO.File.ReadAllText (_filePath);

					string[] _table = _temp.Replace("\r","").Split ('\n');

					for (int i = 0; i < _table.Length; i++)
					{
						_stable.stable [i] = _table[i];
					}
				}else{
						//Console.WriteLine ("Не е намерен такъв път.");
						return false;
					}
		
			return true;
			}catch{
			}

			return false;
		}

		private void iniSettings ()
		{
			try
			{
				bool _fileExist = System.IO.File.Exists ( getPath () );

				if (!_fileExist)
				{
					string _directory = System.IO.Path.GetDirectoryName (getPath ());

					//Застраховаме се, че директорията съществува
					if (!System.IO.Directory.Exists (_directory) )
					{
						System.IO.Directory.CreateDirectory (_directory);
					}

					//Запаметяване съдържанието на файла
					save ();
				}

			}catch{
			}
		}
	}
}

