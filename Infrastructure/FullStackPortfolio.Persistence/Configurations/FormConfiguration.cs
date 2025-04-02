using FullStackPortfolio.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullStackPortfolio.Persistence.Configurations;

public class FormConfiguration : BaseConfiguration<Form>
{
    public override void Configure(EntityTypeBuilder<Form> builder)
    {
        base.Configure(builder);
        builder.HasKey(q => q.BaseId);
    }
}
