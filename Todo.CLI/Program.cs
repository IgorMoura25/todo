using System;
using System.Linq;
using Todo.CLI.Exceptions;

namespace Todo.CLI
{
	class Program
	{
		static void Main(string[] args)
		{
			//mainWord action params
			//notes list -homolog -1
			//notes list -5
			//user remove -prod -2
			//tests run -prod
			try
			{
				var input = Console.ReadLine();
				var inputSplited = input.Split(' ');

				if (inputSplited.Length == 0)
					throw new CommandNotFoundException();

				var mainCommand = inputSplited.FirstOrDefault();

				switch (mainCommand)
				{
					case "notes":
						break; // go to specific 'controller' to handle the remaining params
					case "users":
						break;
					default:
						break;
				}

				Console.WriteLine(input);
			}
			catch(CommandNotFoundException ex)
			{
				Console.WriteLine($"command not found. The commands available are: ...");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Internal error {ex.Message}");
			}

		}
	}
}
