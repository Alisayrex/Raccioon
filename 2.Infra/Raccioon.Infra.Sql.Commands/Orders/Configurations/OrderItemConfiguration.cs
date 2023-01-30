using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Raccioon.Core.Domain.Orders.Entities;

namespace Raccioon.Infra.Sql.Commands.Orders.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(x => x.Id);  
            builder.Property(p =>p.Price).HasConversion(f => f.Value, v => new(v)).HasMaxLength(20);
        }
    }
}
