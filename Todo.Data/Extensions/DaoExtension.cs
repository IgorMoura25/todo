using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Todo.Data.Dapper;
using Todo.Data.Interfaces;

namespace Todo.Data.Extensions
{
	public static class DaoExtension
	{
		public static void RegisterDao(this IServiceCollection services)
		{
			services.AddSingleton<INoteDao, NoteDaoDapper>();
		}
	}
}
