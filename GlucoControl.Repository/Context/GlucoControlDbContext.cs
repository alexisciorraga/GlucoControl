using GlucoControl.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

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

        //public GlucoControlDbContext(DbContextOptions<GlucoControlDbContext> options) : base(options)
        //{
        //    //connectionString = options.GetExtension<SqlServerOptionsExtension>().ConnectionString;
        //    connectionString = "";
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["GlucoControlDB"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}