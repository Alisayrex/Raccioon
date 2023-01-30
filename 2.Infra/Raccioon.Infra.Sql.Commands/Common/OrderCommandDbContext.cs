using Microsoft.EntityFrameworkCore;
using Raccioon.Core.Domain.Orders.Entities;
using Raccioon.Core.Domain.Persons.Entities;
using Zamin.Infra.Data.Sql.Commands;

namespace Raccioon.Infra.Sql.Commands.Common
{
    public class OrderCommandDbContext:BaseCommandDbContext
    {
        public  DbSet<Order> Orders { get; set; }
        public  DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Person> Persons { get; set; }

        public OrderCommandDbContext(DbContextOptions<OrderCommandDbContext>options)
            : base(options)
        {
        }

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
            builder.ApplyConfigurationsFromAssembly(typeof(OrderCommandDbContext).Assembly);
        }

    }
}
