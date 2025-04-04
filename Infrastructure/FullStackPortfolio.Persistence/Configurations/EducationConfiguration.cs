﻿using FullStackPortfolio.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullStackPortfolio.Persistence.Configurations;

public class EducationConfiguration : BaseConfiguration<Education>
{
    public override void Configure(EntityTypeBuilder<Education> builder)
    {
        base.Configure(builder);
        builder.HasKey(q => q.BaseId);
    }
}
