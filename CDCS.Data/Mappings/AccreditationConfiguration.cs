#region

using CDCS.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace CDCS.Data.Mappings {

    public class AccreditationConfiguration : IEntityTypeConfiguration<Accreditation> {
        public void Configure(EntityTypeBuilder<Accreditation> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedNever();

            builder.HasQueryFilter(p => p.RemovedOn == null);

            builder.OwnsOne(p => p.Name);

            builder.HasOne(p => p.Accreditor)
                   .WithMany(x => x.Accreditations)
                   .HasForeignKey(x => x.AccreditorId)
                ;
        }
    }

}