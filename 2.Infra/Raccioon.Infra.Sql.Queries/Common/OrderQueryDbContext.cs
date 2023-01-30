using Microsoft.EntityFrameworkCore;
using Raccioon.Infra.Sql.Queries.Orders.Entities;
using Raccioon.Infra.Sql.Queries.Persons.Entities;
using Zamin.Infra.Data.Sql.Queries;

namespace Raccioon.Infra.Sql.Queries.Common
{

    public partial class OrderQueryDbContext : BaseQueryDbContext
    {
        public OrderQueryDbContext(DbContextOptions<OrderQueryDbContext> options)
            : base(options)
        {
        }

        #region  DbSets

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Person> Persons { get; set; }

        #endregion

        #region Configurations 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(OrderQueryDbContext).Assembly);
        }

        #endregion

        //#region  old config
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        // optionsBuilder.UseSqlServer("Server =.; Database = MiniBlogDb; User Id =sa; Password= 1qaz!QAZ; MultipleActiveResultSets=true");
        //        base.OnConfiguring(optionsBuilder);
        //    }
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Order>(entity =>
        //    {

        //        entity.Property(e => e.Title).HasMaxLength(50);
        //        entity.Property(e => e.Description).HasMaxLength(250);

        //    });

        //    modelBuilder.Entity<OrderItem>(entity =>
        //    {
        //        entity.HasKey(o => o.CatalogItemId);
        //        entity.Property(e => e.ProductTitle).HasMaxLength(50);
        //    });

        //    modelBuilder.Entity<Person>(entity =>
        //    {
        //        entity.Property(e => e.Name).HasMaxLength(50);
        //        entity.Property(e => e.LastName).HasMaxLength(60);

        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //} 
        // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        //#endregion


    }
}
