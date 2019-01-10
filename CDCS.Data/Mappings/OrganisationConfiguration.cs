#region

using CDCS.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace CDCS.Data.Mappings
{

    public class OrganisationConfiguration : IEntityTypeConfiguration<Organisation>
    {
        public void Configure(EntityTypeBuilder<Organisation> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.Property(p => p.LegalStatusId).ValueGeneratedNever();

            builder.HasQueryFilter(p => p.RemovedOn == null);

            builder.OwnsOne(p => p.Address,
                            od =>
                            {
                                od.OwnsOne(c => c.Co);
                                od.OwnsOne(c => c.Street);
                                od.OwnsOne(c => c.City);
                                od.OwnsOne(c => c.MonitoringDistrict);
                                od.OwnsOne(c => c.StatisticDistrict);
                            });

            builder.HasOne(p => p.LegalStatus).WithMany(p => p.Organisations).HasForeignKey(p => p.LegalStatusId);

            builder.OwnsOne(p => p.Activity);
            builder.OwnsOne(p => p.Comment);
            builder.OwnsOne(p => p.Mission);
            builder.OwnsOne(p => p.Name);
            builder.OwnsOne(p => p.OfficialJournalUrl);
            builder.OwnsOne(p => p.OpeningHours);
            builder.OwnsOne(p => p.Public);
            builder.OwnsOne(p => p.SocialBrusselsUrl);
            builder.OwnsOne(p => p.Website);
        }
    }

}