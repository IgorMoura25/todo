using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Todo.Data.Interfaces;

namespace Todo.Data.Extensions
{
	public static class DaoExtension
	{
		public static void RegisterDao(this IServiceCollection services, string connectionString)
		{
			services.TryAddScoped(x => new NoteDao(connectionString));
		}
	}
}
