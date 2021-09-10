using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechWow.Store.Repositories.EntityFramework.Models;

namespace TechWow.Store.Repositories.EntityFramework.Configuration
{
    public class OrderConfiguration: IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);
            builder.Property(p => p.DateAdded).IsRequired();
            builder.Property(p => p.DateModified).IsRequired();
            builder.HasMany(p => p.OrderItems);
            builder.HasOne(p => p.Customer);
        }
    }
}
