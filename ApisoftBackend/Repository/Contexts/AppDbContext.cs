using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;



namespace Repository.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<TypeDocument> TypeDocuments { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Repair> Repairs { get; set; } = null!;
        public virtual DbSet<RepairService> RepairsServices { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;

        public virtual DbSet<Brand> Brands { get; set; } = null!;

        public virtual DbSet<CategoryVehicle> CategoryVehicles { get; set; } = null!;
        public virtual DbSet<PriceServiceCategory> PriceServiceCategories { get; set; } = null!;

         public virtual DbSet<StatusVehicle> StatusVehicles { get; set; } = null!;

         public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;



    }
}
