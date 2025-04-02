using FullStackPortfolio.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullStackPortfolio.Persistence.Configurations;

public class HeroConfiguration : BaseConfiguration<Hero>
{
    public override void Configure(EntityTypeBuilder<Hero> builder)
    {
        base.Configure(builder);
        builder.HasKey(q => q.BaseId);
    }
}
