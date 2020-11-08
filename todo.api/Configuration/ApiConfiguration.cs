using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Api.Configuration
{
	public class ApiConfiguration : IApiConfiguration
	{
		public string ConnectionString { get; }

		public ApiConfiguration()
		{
			ConnectionString = ReadVariableString("TODO_API_CONNECTION_STRING");
		}

		private string ReadVariableString(string variableName)
		{
			var environmentVariable = Environment.GetEnvironmentVariable(variableName);

			//TODO: Tratar se não encontrar

			return environmentVariable;
		}
	}
}
