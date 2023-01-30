using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Raccioon.Infra.Sql.Queries.Orders.Entities;

namespace Raccioon.Infra.Sql.Queries.Orders.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
           
        }
    }
}
