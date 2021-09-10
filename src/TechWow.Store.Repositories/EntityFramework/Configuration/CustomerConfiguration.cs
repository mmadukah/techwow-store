using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechWow.Store.Repositories.EntityFramework.Models;

namespace TechWow.Store.Repositories.EntityFramework.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.Surname).IsRequired();
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.DateAdded).IsRequired();
            builder.Property(p => p.DateModified).IsRequired();
        }
    }
}
