#region

using CDCS.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace CDCS.Data.Mappings {

    public class ContactModeConfiguration : IEntityTypeConfiguration<ContactMode> {
        public void Configure(EntityTypeBuilder<ContactMode> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedNever();

            builder.HasQueryFilter(p => p.RemovedOn == null);

            builder.OwnsOne(
                p => p.Name
            );
        }
    }

}