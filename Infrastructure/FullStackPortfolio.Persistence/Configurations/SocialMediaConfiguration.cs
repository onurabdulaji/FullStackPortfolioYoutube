using FullStackPortfolio.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullStackPortfolio.Persistence.Configurations;

public class SocialMediaConfiguration : BaseConfiguration<SocialMedia>
{
    public override void Configure(EntityTypeBuilder<SocialMedia> builder)
    {
        base.Configure(builder);
    }
}
