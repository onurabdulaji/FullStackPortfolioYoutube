using FullStackPortfolio.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullStackPortfolio.Persistence.Configurations;

public class ServiceConfiguration : BaseConfiguration<Service>
{
    public override void Configure(EntityTypeBuilder<Service> builder)
    {
        base.Configure(builder);
        builder.HasKey(q => q.BaseId);
    }
}
