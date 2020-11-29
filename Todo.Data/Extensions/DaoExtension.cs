using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

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
