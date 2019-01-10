#region

using CDCS.Model.Base;
using CDCS.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace CDCS.Data.Mappings {

    #region FR

    public class Accreditation_FR_Configuration : IEntityTypeConfiguration<Accreditation_FR> {
        public void Configure(EntityTypeBuilder<Accreditation_FR> builder)
        {
            builder.HasBaseType<OrganisationString_FR>();

            builder.HasOne<Organisation>().WithMany(c => c.Accreditations_FR).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class ContactMode_FR_Configuration : IEntityTypeConfiguration<ContactMode_FR> {
        public void Configure(EntityTypeBuilder<ContactMode_FR> builder)
        {
            builder.HasBaseType<OrganisationString_FR>();

            builder.HasOne<Organisation>().WithMany(c => c.ContactModes_FR).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class Email_FR_Configuration : IEntityTypeConfiguration<Email_FR> {
        public void Configure(EntityTypeBuilder<Email_FR> builder)
        {
            builder.HasBaseType<OrganisationString_FR>();

            builder.HasOne<Organisation>().WithMany(c => c.Emails_FR).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class Fax_FR_Configuration : IEntityTypeConfiguration<Fax_FR> {
        public void Configure(EntityTypeBuilder<Fax_FR> builder)
        {
            builder.HasBaseType<OrganisationString_FR>();

            builder.HasOne<Organisation>().WithMany(c => c.Faxes_FR).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class FormerName_FR_Configuration : IEntityTypeConfiguration<FormerName_FR> {
        public void Configure(EntityTypeBuilder<FormerName_FR> builder)
        {
            builder.HasBaseType<OrganisationString_FR>();

            builder.HasOne<Organisation>().WithMany(c => c.FormerNames_FR).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class OtherWebsite_FR_Configuration : IEntityTypeConfiguration<OtherWebsite_FR> {
        public void Configure(EntityTypeBuilder<OtherWebsite_FR> builder)
        {
            builder.HasBaseType<OrganisationString_FR>();

            builder.HasOne<Organisation>().WithMany(c => c.OtherWebsites_FR).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class Phone_FR_Configuration : IEntityTypeConfiguration<Phone_FR> {
        public void Configure(EntityTypeBuilder<Phone_FR> builder)
        {
            builder.HasBaseType<OrganisationString_FR>();

            builder.HasOne<Organisation>().WithMany(c => c.Phones_FR).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class Publication_FR_Configuration : IEntityTypeConfiguration<Publication_FR> {
        public void Configure(EntityTypeBuilder<Publication_FR> builder)
        {
            builder.HasBaseType<OrganisationString_FR>();

            builder.HasOne<Organisation>().WithMany(c => c.Publications_FR).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class ServiceName_FR_Configuration : IEntityTypeConfiguration<ServiceName_FR> {
        public void Configure(EntityTypeBuilder<ServiceName_FR> builder)
        {
            builder.HasBaseType<OrganisationString_FR>();

            builder.HasOne<Organisation>().WithMany(c => c.ServiceNames_FR).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class Url_FR_Configuration : IEntityTypeConfiguration<Url_FR> {
        public void Configure(EntityTypeBuilder<Url_FR> builder)
        {
            builder.HasBaseType<OrganisationString_FR>();

            builder.HasOne<Organisation>().WithMany(c => c.Urls_FR).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class UsedName_FR_Configuration : IEntityTypeConfiguration<UsedName_FR> {
        public void Configure(EntityTypeBuilder<UsedName_FR> builder)
        {
            builder.HasBaseType<OrganisationString_FR>();

            builder.HasOne<Organisation>().WithMany(c => c.UsedNames_FR).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    #endregion

    #region NL

    public class Accreditation_NL_Configuration : IEntityTypeConfiguration<Accreditation_NL> {
        public void Configure(EntityTypeBuilder<Accreditation_NL> builder)
        {
            builder.HasBaseType<OrganisationString_NL>();

            builder.HasOne<Organisation>().WithMany(c => c.Accreditations_NL).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class ContactMode_NL_Configuration : IEntityTypeConfiguration<ContactMode_NL> {
        public void Configure(EntityTypeBuilder<ContactMode_NL> builder)
        {
            builder.HasBaseType<OrganisationString_NL>();

            builder.HasOne<Organisation>().WithMany(c => c.ContactModes_NL).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class Email_NL_Configuration : IEntityTypeConfiguration<Email_NL> {
        public void Configure(EntityTypeBuilder<Email_NL> builder)
        {
            builder.HasBaseType<OrganisationString_NL>();

            builder.HasOne<Organisation>().WithMany(c => c.Emails_NL).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class Fax_NL_Configuration : IEntityTypeConfiguration<Fax_NL> {
        public void Configure(EntityTypeBuilder<Fax_NL> builder)
        {
            builder.HasBaseType<OrganisationString_NL>();

            builder.HasOne<Organisation>().WithMany(c => c.Faxes_NL).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class FormerName_NL_Configuration : IEntityTypeConfiguration<FormerName_NL> {
        public void Configure(EntityTypeBuilder<FormerName_NL> builder)
        {
            builder.HasBaseType<OrganisationString_NL>();

            builder.HasOne<Organisation>().WithMany(c => c.FormerNames_NL).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class OtherWebsite_NL_Configuration : IEntityTypeConfiguration<OtherWebsite_NL> {
        public void Configure(EntityTypeBuilder<OtherWebsite_NL> builder)
        {
            builder.HasBaseType<OrganisationString_NL>();

            builder.HasOne<Organisation>().WithMany(c => c.OtherWebsites_NL).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class Phone_NL_Configuration : IEntityTypeConfiguration<Phone_NL> {
        public void Configure(EntityTypeBuilder<Phone_NL> builder)
        {
            builder.HasBaseType<OrganisationString_NL>();

            builder.HasOne<Organisation>().WithMany(c => c.Phones_NL).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class Publication_NL_Configuration : IEntityTypeConfiguration<Publication_NL> {
        public void Configure(EntityTypeBuilder<Publication_NL> builder)
        {
            builder.HasBaseType<OrganisationString_NL>();

            builder.HasOne<Organisation>().WithMany(c => c.Publications_NL).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class ServiceName_NL_Configuration : IEntityTypeConfiguration<ServiceName_NL> {
        public void Configure(EntityTypeBuilder<ServiceName_NL> builder)
        {
            builder.HasBaseType<OrganisationString_NL>();

            builder.HasOne<Organisation>().WithMany(c => c.ServiceNames_NL).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class Url_NL_Configuration : IEntityTypeConfiguration<Url_NL> {
        public void Configure(EntityTypeBuilder<Url_NL> builder)
        {
            builder.HasBaseType<OrganisationString_NL>();

            builder.HasOne<Organisation>().WithMany(c => c.Urls_NL).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class UsedName_NL_Configuration : IEntityTypeConfiguration<UsedName_NL> {
        public void Configure(EntityTypeBuilder<UsedName_NL> builder)
        {
            builder.HasBaseType<OrganisationString_NL>();

            builder.HasOne<Organisation>().WithMany(c => c.UsedNames_NL).HasForeignKey(p => p.RefId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    #endregion

}