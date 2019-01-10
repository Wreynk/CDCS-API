#region

using CDCS.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace CDCS.Data.Mappings
{

    public class OrganisationLegalStatusConfiguration : IEntityTypeConfiguration<OrganisationLegalStatus>
    {
        public void Configure(EntityTypeBuilder<OrganisationLegalStatus> builder)
        {
            // builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedNever();

            builder.HasQueryFilter(p => p.RemovedOn == null);

            builder.OwnsOne(p => p.Name);
        }
    }

}