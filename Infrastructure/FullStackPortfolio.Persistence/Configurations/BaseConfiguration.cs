using FullStackPortfolio.Domain.Entities.IBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullStackPortfolio.Persistence.Configurations;

public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IBaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.Property(q => q.CreatedDate).IsRequired();
    }
}
