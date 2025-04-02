using FullStackPortfolio.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullStackPortfolio.Persistence.Configurations;

public class SummaryConfiguration : BaseConfiguration<Summary>
{
    public override void Configure(EntityTypeBuilder<Summary> builder)
    {
        base.Configure(builder);
    }
}