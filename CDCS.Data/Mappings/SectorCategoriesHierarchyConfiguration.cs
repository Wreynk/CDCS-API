#region

using CDCS.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace CDCS.Data.Mappings {

    public class SectorCategoriesHierarchyConfiguration : IEntityTypeConfiguration<SectorCategoriesHierarchy> {
        public void Configure(EntityTypeBuilder<SectorCategoriesHierarchy> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedNever();

            builder.HasQueryFilter(p => p.RemovedOn == null);

            builder.HasOne<Category>()
                   .WithMany(c => c.SectorCategoriesHierarchies)
                   .HasForeignKey(p => p.CategoryId)
                ;

            builder.HasOne<Sector>()
                   .WithMany(c => c.SectorCategoriesHierarchies)
                   .HasForeignKey(p => p.SectorId)
                ;

            builder.HasOne<Topic>()
                   .WithMany(c => c.Topic1_SectorCategoriesHierarchies)
                   .HasForeignKey(p => p.Topic1Id)
                   .OnDelete(DeleteBehavior.Restrict)
                ;

            builder.HasOne<Topic>()
                   .WithMany(c => c.Topic2_SectorCategoriesHierarchies)
                   .HasForeignKey(p => p.Topic2Id)
                   .OnDelete(DeleteBehavior.Restrict)
                ;

            builder.HasOne<Topic>()
                   .WithMany(c => c.Topic3_SectorCategoriesHierarchies)
                   .HasForeignKey(p => p.Topic3Id)
                   .OnDelete(DeleteBehavior.Restrict)
                ;

            builder.HasOne<Topic>()
                   .WithMany(c => c.Topic4_SectorCategoriesHierarchies)
                   .HasForeignKey(p => p.Topic4Id)
                   .OnDelete(DeleteBehavior.Restrict)
                ;
        }
    }

}