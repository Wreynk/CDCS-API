#region

using CDCS.Model.Base;
using CDCS.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace CDCS.Data.Mappings {

    public class Keyword_FR_Configuration : IEntityTypeConfiguration<Keyword_FR> {
        public void Configure(EntityTypeBuilder<Keyword_FR> builder)
        {
            builder.HasBaseType<CategoryString_FR>();

            builder.HasOne<Category>()
                   .WithMany(c => c.Keywords_FR)
                   .HasForeignKey(p => p.RefId)
                   .OnDelete(DeleteBehavior.Restrict)
                ;
        }
    }

    public class Keyword_NL_Configuration : IEntityTypeConfiguration<Keyword_NL> {
        public void Configure(EntityTypeBuilder<Keyword_NL> builder)
        {
            builder.HasBaseType<CategoryString_NL>();

            builder.HasOne<Category>()
                   .WithMany(c => c.Keywords_NL)
                   .HasForeignKey(p => p.RefId)
                   .OnDelete(DeleteBehavior.Restrict)
                ;
        }
    }

}