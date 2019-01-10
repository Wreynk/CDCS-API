#region

using CDCS.Data.Mappings;
using CDCS.Model.Base;
using CDCS.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

#endregion

namespace CDCS.Data
{

    public class CdcsContext : DbContext
    {
        private static readonly LoggerFactory MyConsoleLoggerFactory
            = new LoggerFactory(new[] {
                new ConsoleLoggerProvider((category, level)
                                              => category == DbLoggerCategory.Database.Command.Name
                                                 && level == LogLevel.Information,
                                          true)
            });

        // public CdcsContext(DbContextOptions options)
        //     : base(options) {}

        // Imported Organisations
        public DbSet<Organisation> Organisations { get; set; }

        public DbSet<Accreditation> Accreditations { get; set; }
        public DbSet<Accreditor> Accreditors { get; set; }
        public DbSet<ContactMode> ContactModes { get; set; }
        public DbSet<GeographicalZone> GeographicalZones { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<OrganisationLanguage> OrganisationLanguages { get; set; }
        public DbSet<OrganisationLegalStatus> OrganisationLegalStatuses { get; set; }

        // Imported categories
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<SectorCategoriesHierarchy> SectorCategoriesHierarchies { get; set; }
        public DbSet<Topic> Topics { get; set; }

        // Helpers
        // public DbSet<StringItem>            StringItems       { get; set; }
        public DbSet<CategoryString> CategoryStrings { get; set; }
        public DbSet<OrganisationString> OrganisationStrings { get; set; }

        // public DbSet<String_FR>             StringFrs         { get; set; }
        // public DbSet<String_NL>             StringNls         { get; set; }
        // public DbSet<OrganisationString_FR> Organisations_FRs { get; set; }
        // public DbSet<OrganisationString_NL> Organisation_NLs  { get; set; }
        // public DbSet<CategoriesString_FR> Categories_FRs { get; set; }
        // public DbSet<CategoriesString_NL> Categories_NLs { get; set; }

        // Strings
        // public DbSet<Keyword_FR> Keywords_FR { get; set; }
        // public DbSet<Keyword_NL> Keywords_NL { get; set; }
        //
        // public DbSet<Accreditation_FR> Accreditations_FR { get; set; }
        // public DbSet<ContactMode_FR>   ContactModes_FR   { get; set; }
        // public DbSet<Email_FR>         Emails_FR         { get; set; }
        // public DbSet<Fax_FR>           Faxes_FR          { get; set; }
        // public DbSet<FormerName_FR>    FormerNames_FR    { get; set; }
        // public DbSet<OtherWebsite_FR>  OtherWebsites_FR  { get; set; }
        // public DbSet<Phone_FR>         Phones_FR         { get; set; }
        // public DbSet<Publication_FR>   Publications_FR   { get; set; }
        // public DbSet<ServiceName_FR>   ServiceNames_FR   { get; set; }
        // public DbSet<Url_FR>           Urls_FR           { get; set; }
        // public DbSet<UsedName_FR>      UsedNames_FR      { get; set; }
        // public DbSet<Accreditation_NL> Accreditations_NL { get; set; }
        // public DbSet<ContactMode_NL>   ContactModes_NL   { get; set; }
        // public DbSet<Email_NL>         Emails_NL         { get; set; }
        // public DbSet<Fax_NL>           Faxes_NL          { get; set; }
        // public DbSet<FormerName_NL>    FormerNames_NL    { get; set; }
        // public DbSet<OtherWebsite_NL>  OtherWebsites_NL  { get; set; }
        // public DbSet<Phone_NL>         Phones_NL         { get; set; }
        // public DbSet<Publication_NL>   Publications_NL   { get; set; }
        // public DbSet<ServiceName_NL>   ServiceNames_NL   { get; set; }
        // public DbSet<Url_NL>           Urls_NL           { get; set; }
        // public DbSet<UsedName_NL>      UsedNames_NL      { get; set; }

        protected override void OnModelCreating(ModelBuilder model_builder)
        {
            // Base
            // model_builder.Entity<String_FR>().HasBaseType<StringItem>();
            // model_builder.Entity<String_NL>().HasBaseType<StringItem>();

            // Organisations
            model_builder.ApplyConfiguration(new OrganisationConfiguration());
            model_builder.ApplyConfiguration(new AccreditationConfiguration());
            model_builder.ApplyConfiguration(new AccreditorConfiguration());
            model_builder.ApplyConfiguration(new ContactModeConfiguration());
            model_builder.ApplyConfiguration(new GeographicalZoneConfiguration());
            model_builder.ApplyConfiguration(new LanguageConfiguration());
            model_builder.ApplyConfiguration(new OrganisationConfiguration());
            model_builder.ApplyConfiguration(new OrganisationLanguageConfiguration());
            model_builder.ApplyConfiguration(new OrganisationLegalStatusConfiguration());

            // Strings --------------------------------------------------------------------------
            model_builder.ApplyConfiguration(new Accreditation_FR_Configuration());
            model_builder.ApplyConfiguration(new ContactMode_FR_Configuration());
            model_builder.ApplyConfiguration(new Email_FR_Configuration());
            model_builder.ApplyConfiguration(new Fax_FR_Configuration());
            model_builder.ApplyConfiguration(new FormerName_FR_Configuration());
            model_builder.ApplyConfiguration(new OtherWebsite_FR_Configuration());
            model_builder.ApplyConfiguration(new Phone_FR_Configuration());
            model_builder.ApplyConfiguration(new Publication_FR_Configuration());
            model_builder.ApplyConfiguration(new ServiceName_FR_Configuration());
            model_builder.ApplyConfiguration(new Url_FR_Configuration());
            model_builder.ApplyConfiguration(new UsedName_FR_Configuration());
            model_builder.ApplyConfiguration(new Accreditation_NL_Configuration());
            model_builder.ApplyConfiguration(new ContactMode_NL_Configuration());
            model_builder.ApplyConfiguration(new Email_NL_Configuration());
            model_builder.ApplyConfiguration(new Fax_NL_Configuration());
            model_builder.ApplyConfiguration(new FormerName_NL_Configuration());
            model_builder.ApplyConfiguration(new OtherWebsite_NL_Configuration());
            model_builder.ApplyConfiguration(new Phone_NL_Configuration());
            model_builder.ApplyConfiguration(new Publication_NL_Configuration());
            model_builder.ApplyConfiguration(new ServiceName_NL_Configuration());
            model_builder.ApplyConfiguration(new Url_NL_Configuration());
            model_builder.ApplyConfiguration(new UsedName_NL_Configuration());

            // Sectors
            model_builder.ApplyConfiguration(new CategoryConfiguration());
            model_builder.ApplyConfiguration(new SectorConfiguration());
            model_builder.ApplyConfiguration(new SectorCategoriesHierarchyConfiguration());
            model_builder.ApplyConfiguration(new TopicConfiguration());

            // Strings --------------------------------------------------------------------------
            model_builder.ApplyConfiguration(new Keyword_FR_Configuration());
            model_builder.ApplyConfiguration(new Keyword_NL_Configuration());

            //
            // // foreach (var relationship in model_builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //
            base.OnModelCreating(model_builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options_builder)
        {
            options_builder
                .UseLoggerFactory(MyConsoleLoggerFactory)
                .EnableSensitiveDataLogging(true)
                .UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = CdcsData; Trusted_Connection = True;");
        }
    }

}