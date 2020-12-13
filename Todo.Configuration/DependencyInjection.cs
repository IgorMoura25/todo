using Microsoft.Extensions.DependencyInjection;
using Todo.Data.Dapper;
using Todo.Data.Interfaces;

namespace Todo.Configuration
{
    public static class DependencyInjection
    {
		public static void RegisterDependencies(this IServiceCollection services)
		{
			services.AddSingleton<INoteDao, NoteDaoDapper>();
		}
	}
}
