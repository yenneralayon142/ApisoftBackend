using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository.Contexts; 
using System;

namespace ApisoftBackend.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            var connection = configuration.GetConnectionString("sqlConnectionMySql");
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

            var builder = new DbContextOptionsBuilder<AppDbContext>().UseMySql(connection, serverVersion, b => b.MigrationsAssembly("ApisoftBackend"));

            return new AppDbContext(builder.Options);
        }
    }
}
