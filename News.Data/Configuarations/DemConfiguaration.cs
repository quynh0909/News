using Microsoft.EntityFrameworkCore;
using News.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Data.Configuarations
{
    public class DemConfiguration : IEntityTypeConfiguration<Dem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Dem> builder)
        {
            builder.ToTable("Dems");

            builder.HasKey(x => x.CountID);
        }
    }
}
