using dotenv.net;
using Todo.Configuration.Exceptions;
using Todo.Configuration.services;
using System;

namespace Todo.Configuration
{
	public static class EnvironmentVariables
	{
		public static void Load()
		{
			try
			{
				var directory = FindEnvFileService.TryGetEnvDirectoryInfo();
				if (directory == null)
				{
					throw new EnvFileNotFoundException();
				}
				DotEnv.Config(filePath: $"{directory.FullName}/.env");
			}
			catch (EnvFileNotFoundException ex)
			{
				throw new Exception($"Não foi possível localizar o arquivo .env no escopo do projeto.");
			}
			catch (Exception)
			{
				throw;
			}


		}
	}
}
