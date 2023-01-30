using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Raccioon.Infra.Sql.Queries.Persons.Entities;

namespace Raccioon.Infra.Sql.Queries.Persons.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(20);
            builder.Property(p => p.LastName).HasMaxLength(50);
            builder.Property(p => p.NationalId).IsUnicode(false).IsFixedLength(true).HasMaxLength(10);
        }
    }
}
