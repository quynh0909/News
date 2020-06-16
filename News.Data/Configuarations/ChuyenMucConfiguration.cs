using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using News.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Data.Configuarations
{
    public class ChuyenMucConfiguration : IEntityTypeConfiguration<ChuyenMuc>
    {
        public void Configure(EntityTypeBuilder<ChuyenMuc> builder)
        {
            builder.ToTable("ChuyenMucs");

            builder.HasKey(x => x.CateID);

            builder.Property(x => x.CateName).IsRequired();
            builder.Property(x => x.CateHide).HasDefaultValue(CateHide.Hide);
        }
    }
}
