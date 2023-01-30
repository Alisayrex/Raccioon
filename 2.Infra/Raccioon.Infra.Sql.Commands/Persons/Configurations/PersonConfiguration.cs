using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Raccioon.Core.Domain.Persons.Entities;

namespace Raccioon.Infra.Sql.Commands.Persons.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.NationalId).HasConversion(f => f.Value, v => new(v)).HasMaxLength(10);
            builder.Property(p => p.Address).HasConversion(f => f.Value, v => new(v)).HasMaxLength(150);
            builder.Property(p => p.Name).HasConversion(f => f.Value, v => new(v)).HasMaxLength(25);
            builder.Property(p => p.LastName).HasConversion(f => f.Value, v => new(v)).HasMaxLength(50);
        }
    }
}
