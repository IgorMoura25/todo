using dotenv.net;

namespace Todo.Configuration
{
	public static class EnvironmentVariables
	{
		public static void Load()
		{
			var path = System.IO.Directory.GetCurrentDirectory();
			DotEnv.Config(filePath: "../../../../.env");
		}
	}
}
