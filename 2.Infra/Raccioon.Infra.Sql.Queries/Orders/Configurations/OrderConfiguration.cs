using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Raccioon.Infra.Sql.Queries.Orders.Entities;

namespace Raccioon.Infra.Sql.Queries.Orders.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(p => p.Title).HasMaxLength(250);
         //   builder.ToSqlQuery(_queryView);
              

        }
      // private readonly string _queryView = "SELECT * FROM Orders";
    }

}
