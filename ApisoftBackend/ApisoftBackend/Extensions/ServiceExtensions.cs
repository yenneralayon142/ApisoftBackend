using Contracts;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Contexts;
using ServiceContracts;
using Services;

namespace ApisoftBackend.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                );

        });

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("sqlConnectionMySql");
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

            services.AddDbContext<AppDbContext>(options => options.UseMySql(connection, serverVersion, b => b.MigrationsAssembly("ApisoftBackend")));

        }

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();
    }
}
