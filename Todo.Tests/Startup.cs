using Microsoft.Extensions.DependencyInjection;
using Todo.Configuration;

namespace Todo.Tests
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			EnvironmentVariables.Load();
			DependencyInjection.RegisterDependencies(services);
		}
	}
}
