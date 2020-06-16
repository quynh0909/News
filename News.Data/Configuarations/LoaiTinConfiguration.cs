using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using News.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Data.Configuarations
{
    public class LoaiTinConfiguration : IEntityTypeConfiguration<LoaiTin>
    {
       

        public void Configure(EntityTypeBuilder<LoaiTin> builder)
        {
            builder.ToTable("LoaiTins");

            builder.HasKey(x => x.LTID);

            builder.Property(x => x.LTName).IsRequired().IsUnicode(false).HasMaxLength(255);
           
        }


    }




}
