using GlucoControl.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;

namespace GlucoControl.Repository.Context
{
    public class GlucoControlDbContext : DbContext
    {
        public DbSet<Control> Controls { get; set; }
        public DbSet<Insulin> Insulins { get; set; }
        public DbSet<InsulinType> InsulinTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        readonly string connectionString;

        public GlucoControlDbContext(DbContextOptions<GlucoControlDbContext> options) : base(options)
        {
            connectionString = options.GetExtension<SqlServerOptionsExtension>().ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(connectionString);

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
