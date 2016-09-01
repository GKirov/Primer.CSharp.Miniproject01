using System;

namespace UserInput
{
	public class UInput
	{
		About.Me about = new About.Me ();
		Colours.ForCLI _c = new Colours.ForCLI ();

		public UInput ()
		{
		}


		public void sayHello ()
		{
			_c.Default (); Console.WriteLine ("Добре дошли в " + about.shortName + "\n" + about.version + "\n");
		}

		public void getUserCommands ()
		{
			string _command = "";

			do
			{
				//Взимане на команда
				_c.Prompt();	Console.Write ("$ ");
				_c.Command();	_command = Console.ReadLine ();

				//Проверка за налични команди
				if ( _command.ToLower().Contains ("команда1"))	
				{
					_c.Default();	Console.Write ("Стартирана е ");
					_c.Result(); 	Console.WriteLine ("Команда 1\n");
				}
				if ( _command.ToLower().Contains ("команда2"))	Console.WriteLine ("Стартирана е Команда 2\n");
				if ( _command.ToLower().Contains ("команда3"))	Console.WriteLine ("Стартирана е Команда 3\n");

				
			}while ( _command.ToLower() != "изход");
		}


		public void justTesting ()
		{
			Console.WriteLine ( "Стартиране на UserInput.UInput.justTesting ()" );
		}
	}
}

