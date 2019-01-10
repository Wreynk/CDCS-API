using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CDCS.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accreditors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name_FR = table.Column<string>(nullable: true),
                    Name_NL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accreditors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name_FR = table.Column<string>(nullable: true),
                    Name_NL = table.Column<string>(nullable: true),
                    Description_FR = table.Column<string>(nullable: true),
                    Description_NL = table.Column<string>(nullable: true),
                    Website_FR = table.Column<string>(nullable: true),
                    Website_NL = table.Column<string>(nullable: true),
                    LinkCategoriesIds = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactModes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name_FR = table.Column<string>(nullable: true),
                    Name_NL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactModes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeographicalZones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name_FR = table.Column<string>(nullable: true),
                    Name_NL = table.Column<string>(nullable: true),
                    ParentsIds = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeographicalZones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name_FR = table.Column<string>(nullable: true),
                    Name_NL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganisationLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name_FR = table.Column<string>(nullable: true),
                    Name_NL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganisationLanguages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganisationLegalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name_FR = table.Column<string>(nullable: true),
                    Name_NL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganisationLegalStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Address_Co_FR = table.Column<string>(nullable: true),
                    Address_Co_NL = table.Column<string>(nullable: true),
                    Address_StreetNumber = table.Column<string>(nullable: true),
                    Address_Street_FR = table.Column<string>(nullable: true),
                    Address_Street_NL = table.Column<string>(nullable: true),
                    Address_City_FR = table.Column<string>(nullable: true),
                    Address_City_NL = table.Column<string>(nullable: true),
                    Address_PostCode = table.Column<string>(nullable: true),
                    Address_Monitoring_Code = table.Column<string>(nullable: true),
                    Address_MonitoringDistrict_FR = table.Column<string>(nullable: true),
                    Address_MonitoringDistrict_NL = table.Column<string>(nullable: true),
                    Address_StatisticDistrict_Code = table.Column<string>(nullable: true),
                    Address_StatisticDistrict_FR = table.Column<string>(nullable: true),
                    Address_StatisticDistrict_NL = table.Column<string>(nullable: true),
                    Address_Latitude = table.Column<double>(nullable: true),
                    Address_Longitude = table.Column<double>(nullable: true),
                    Address_PostalBox = table.Column<string>(nullable: true),
                    Address_X_Coord = table.Column<double>(nullable: true),
                    Address_Y_Coord = table.Column<double>(nullable: true),
                    Activity_FR = table.Column<string>(nullable: true),
                    Activity_NL = table.Column<string>(nullable: true),
                    Comment_FR = table.Column<string>(nullable: true),
                    Comment_NL = table.Column<string>(nullable: true),
                    Mission_FR = table.Column<string>(nullable: true),
                    Mission_NL = table.Column<string>(nullable: true),
                    Name_FR = table.Column<string>(nullable: true),
                    Name_NL = table.Column<string>(nullable: true),
                    OfficialJournalUrl_FR = table.Column<string>(nullable: true),
                    OfficialJournalUrl_NL = table.Column<string>(nullable: true),
                    OpeningHours_FR = table.Column<string>(nullable: true),
                    OpeningHours_NL = table.Column<string>(nullable: true),
                    Public_FR = table.Column<string>(nullable: true),
                    Public_NL = table.Column<string>(nullable: true),
                    SocialBrusselsUrl_FR = table.Column<string>(nullable: true),
                    SocialBrusselsUrl_NL = table.Column<string>(nullable: true),
                    Website_FR = table.Column<string>(nullable: true),
                    Website_NL = table.Column<string>(nullable: true),
                    LegalStatusId = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    ParentOrganisationId = table.Column<int>(nullable: true),
                    AccreditationsIds = table.Column<string>(nullable: true),
                    CategoriesIds = table.Column<string>(nullable: true),
                    ChildrenIds = table.Column<string>(nullable: true),
                    GeographicalZonesIds = table.Column<string>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    RegistrationNumber = table.Column<string>(nullable: true),
                    ServiceModesIds = table.Column<string>(nullable: true),
                    UsedLanguagesIds = table.Column<string>(nullable: true),
                    UsesInterpreters = table.Column<bool>(nullable: false),
                    WorkingLanguage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name_FR = table.Column<string>(nullable: true),
                    Name_NL = table.Column<string>(nullable: true),
                    Description_FR = table.Column<string>(nullable: true),
                    Description_NL = table.Column<string>(nullable: true),
                    SortOrder = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name_FR = table.Column<string>(nullable: true),
                    Name_NL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accreditations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name_FR = table.Column<string>(nullable: true),
                    Name_NL = table.Column<string>(nullable: true),
                    Name_AccreditationId = table.Column<int>(nullable: false),
                    AccreditorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accreditations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accreditations_Accreditors_AccreditorId",
                        column: x => x.AccreditorId,
                        principalTable: "Accreditors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryStrings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    TextValue = table.Column<string>(nullable: true),
                    Language = table.Column<int>(nullable: false),
                    RefTableEnum = table.Column<int>(nullable: false),
                    RefId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryStrings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryStrings_Categories_RefId",
                        column: x => x.RefId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoryStrings_Categories_RefId1",
                        column: x => x.RefId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrganisationStrings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    TextValue = table.Column<string>(nullable: true),
                    Language = table.Column<int>(nullable: false),
                    RefTableEnum = table.Column<int>(nullable: false),
                    RefId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganisationStrings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId1",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId2",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId3",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId4",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId5",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId6",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId7",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId8",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId9",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId10",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId11",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId12",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId13",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId14",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId15",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId16",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId17",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId18",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId19",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId20",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrganisationStrings_Organisations_RefId21",
                        column: x => x.RefId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SectorCategoriesHierarchies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RemovedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    SectorId = table.Column<int>(nullable: false),
                    Topic1Id = table.Column<int>(nullable: true),
                    Topic1_SortOrder = table.Column<int>(nullable: false),
                    Topic2Id = table.Column<int>(nullable: true),
                    Topic2_SortOrder = table.Column<int>(nullable: false),
                    Topic3Id = table.Column<int>(nullable: true),
                    Topic3_SortOrder = table.Column<int>(nullable: false),
                    Topic4Id = table.Column<int>(nullable: true),
                    Topic4_SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectorCategoriesHierarchies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectorCategoriesHierarchies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectorCategoriesHierarchies_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectorCategoriesHierarchies_Topics_Topic1Id",
                        column: x => x.Topic1Id,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SectorCategoriesHierarchies_Topics_Topic2Id",
                        column: x => x.Topic2Id,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SectorCategoriesHierarchies_Topics_Topic3Id",
                        column: x => x.Topic3Id,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SectorCategoriesHierarchies_Topics_Topic4Id",
                        column: x => x.Topic4Id,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accreditations_AccreditorId",
                table: "Accreditations",
                column: "AccreditorId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryStrings_RefId",
                table: "CategoryStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryStrings_RefId1",
                table: "CategoryStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId1",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId2",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId3",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId4",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId5",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId6",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId7",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId8",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId9",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId10",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId11",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId12",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId13",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId14",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId15",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId16",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId17",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId18",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId19",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId20",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationStrings_RefId21",
                table: "OrganisationStrings",
                column: "RefId");

            migrationBuilder.CreateIndex(
                name: "IX_SectorCategoriesHierarchies_CategoryId",
                table: "SectorCategoriesHierarchies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SectorCategoriesHierarchies_SectorId",
                table: "SectorCategoriesHierarchies",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_SectorCategoriesHierarchies_Topic1Id",
                table: "SectorCategoriesHierarchies",
                column: "Topic1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SectorCategoriesHierarchies_Topic2Id",
                table: "SectorCategoriesHierarchies",
                column: "Topic2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SectorCategoriesHierarchies_Topic3Id",
                table: "SectorCategoriesHierarchies",
                column: "Topic3Id");

            migrationBuilder.CreateIndex(
                name: "IX_SectorCategoriesHierarchies_Topic4Id",
                table: "SectorCategoriesHierarchies",
                column: "Topic4Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accreditations");

            migrationBuilder.DropTable(
                name: "CategoryStrings");

            migrationBuilder.DropTable(
                name: "ContactModes");

            migrationBuilder.DropTable(
                name: "GeographicalZones");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "OrganisationLanguages");

            migrationBuilder.DropTable(
                name: "OrganisationLegalStatuses");

            migrationBuilder.DropTable(
                name: "OrganisationStrings");

            migrationBuilder.DropTable(
                name: "SectorCategoriesHierarchies");

            migrationBuilder.DropTable(
                name: "Accreditors");

            migrationBuilder.DropTable(
                name: "Organisations");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
