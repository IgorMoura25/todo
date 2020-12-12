using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.CLI.Exceptions
{
	class CommandNotFoundException : ApplicationException
	{
		public CommandNotFoundException()
		{
		}

		public CommandNotFoundException(string message) : base(message)
		{
		}
	}
}
