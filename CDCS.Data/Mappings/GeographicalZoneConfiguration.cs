﻿#region

using CDCS.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace CDCS.Data.Mappings {

    public class GeographicalZoneConfiguration : IEntityTypeConfiguration<GeographicalZone> {
        public void Configure(EntityTypeBuilder<GeographicalZone> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedNever();

            builder.HasQueryFilter(p => p.RemovedOn == null);

            builder.OwnsOne(p => p.Name);
        }
    }

}