#region

using CDCS.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace CDCS.Data.Mappings {

    public class LanguageConfiguration : IEntityTypeConfiguration<Language> {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedNever();

            builder.HasQueryFilter(p => p.RemovedOn == null);

            builder.OwnsOne(p => p.Name);
        }
    }

}