using GlucoControl.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure.Internal;

namespace GlucoControl.Repository.Context
{
    public class GlucoControlDbContext : DbContext
    {
        public DbSet<Control> Controls { get; set; }
        public DbSet<Insulin> Insulins { get; set; }
        public DbSet<InsulinType> InsulinTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        private readonly string connectionString;

        public GlucoControlDbContext(DbContextOptions<GlucoControlDbContext> options) : base(options)
        {
            connectionString = options.GetExtension<MySqlOptionsExtension>().ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(connectionString, builder => builder.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}