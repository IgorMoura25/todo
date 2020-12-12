using System;

namespace Todo.CLI
{
	class Program
	{
		static void Main(string[] args)
		{
			var teste = Console.ReadLine();
			var command = teste.Split(' ');
			Console.WriteLine(teste);
		}
	}
}
