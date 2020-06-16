using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using News.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Data.Configuarations
{
    public class TinTucConfiguration : IEntityTypeConfiguration<TinTuc>
    {
        public void Configure(EntityTypeBuilder<TinTuc> builder)
        {
            builder.ToTable("TinTucs");

            builder.HasKey(x => x.TinID);

            builder.Property(x => x.TieuDe).IsRequired().IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.NoiDung).IsRequired().IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.TomTat).IsRequired().IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.UrlImg).IsRequired().IsUnicode(false).HasMaxLength(255);
            builder.HasOne(x => x.LoaiTin).WithMany(q => q.TinTucs).HasForeignKey(x => x.LTID);
        }

        
    }
}
