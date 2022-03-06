using Data.Mappings;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options) : base(options)
        {
        }
        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<State> State { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Client>(new ClientMap().Configure);
            modelBuilder.Entity<Provider>(new ProviderMap().Configure);
            modelBuilder.Entity<Employee>(new EmployeeMap().Configure);
            modelBuilder.Entity<State>(new StateMap().Configure);
            modelBuilder.Entity<City>(new CityMap().Configure);
        }
    }
}
