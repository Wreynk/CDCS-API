using System;
using CDCS.Model.JsonBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CDCS.DAL
{
    public class CdcsContext : DbContext {

        public static readonly LoggerFactory MyConsoleLoggerFactory
            = new LoggerFactory(new[] {
                new ConsoleLoggerProvider((category, level)
                                              => category == DbLoggerCategory.Database.Command.Name
                                                 && level == LogLevel.Information,
                                          true)
            });


        public DbSet<CdcsActionZone> CdcsActionZones { get; set; }
        public DbSet<CdcsAddress> CdcsAddresses { get; set; }
        public DbSet<CdcsAgreement> CdcsAgreements { get; set; }
        public DbSet<CdcsAgreementOrganization> CdcsAgreementOrganizations { get; set; }
        public DbSet<CdcsLanguage> CdcsLanguages { get; set; }
        public DbSet<CdcsLegalStatus> CdcsLegalStatuses { get; set; }
        public DbSet<CdcsSector> CdcsSectors { get; set; }
        public DbSet<CdcsServiceType> CdcsServiceTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<SamuraiBattle>()
            //             .HasKey(s => new {
            //                 s.BattleId,
            //                 s.SamuraiId
            //             });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyConsoleLoggerFactory)
                .EnableSensitiveDataLogging(true)
                .UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = CdcsData; Trusted_Connection = True;");
        }

    }}
