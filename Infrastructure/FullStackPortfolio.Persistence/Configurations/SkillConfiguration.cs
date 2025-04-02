using FullStackPortfolio.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullStackPortfolio.Persistence.Configurations;

public class SkillConfiguration : BaseConfiguration<Skill>
{
    public override void Configure(EntityTypeBuilder<Skill> builder)
    {
        base.Configure(builder);
        builder.HasKey(q => q.BaseId);
    }
}
