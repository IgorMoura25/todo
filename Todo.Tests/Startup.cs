using dotenv.net;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using Todo.Data.Dapper;
using Todo.Data.Interfaces;

namespace Todo.Tests
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			DotEnv.Config(filePath: "../../../../todo.api/.env");
			services.AddSingleton<INoteDao, NoteDaoDapper>();
		}
	}
}
