#region

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using AutoMapper;
using CDCS.Data;
using CDCS.Model.Base;
using CDCS.Model.Domain;
using CDCS.Model.Profiles;
using CDCS.ModelTransformation.Base;
using TLT.BaseModel.Base;
using TLT.BaseModel.Interfaces;
using TLT.Helpers;

#endregion

namespace CDCS.DataImport {

    internal static class Program {
        private static void Main(string[] args) {
            // ((CDCS.ModelTransformation.CdcsOrganisationsInput)organisation_request).Organisations.FindAll(x=>x.UsedNames_FR.Count>0)
            // TODO encrypt app.config strings

            Console.WriteLine("Import CDCS Xml file into SqlServer database");
            string folderPath          = ConfigurationManager.AppSettings["XmlDirectory"];
            string inputCategories     = ConfigurationManager.AppSettings["InputCategories"];
            string outputCategories    = ConfigurationManager.AppSettings["OutputCategories"];
            string inputOrganisations  = ConfigurationManager.AppSettings["InputOrganisations"];
            string outputOrganisations = ConfigurationManager.AppSettings["OutputOrganisations"];

            // var test_organisations_deserialization = ConfigurationManager.AppSettings["TEST_ORGANISATIONS_DESERIALIZATION"];
            string xslTransformer = ConfigurationManager.AppSettings["XslTransformer"];

            // XmlImport.CleanXml(input_organisations, output_organisations, xsl_transformer, folder_path);
            // XmlImport.CleanXml(input_categories, output_categories, xsl_transformer, folder_path);

            var organisationInput = XmlImport.XmlToObjects(File.ReadAllText($@"{folderPath}{outputOrganisations}.xml"), typeof(CdcsOrganisationsInput));
            var categoryInput     = XmlImport.XmlToObjects(File.ReadAllText($@"{folderPath}{outputCategories}.xml"), typeof(CdcsCategoriesInput));

            var config = new MapperConfiguration(cfg => cfg.AddProfile<CdcsProfile>());
            config.AssertConfigurationIsValid();
            var mapper = config.CreateMapper();

            var categories    = mapper.Map<CdcsCategoriesInput, CategoriesInput>((CdcsCategoriesInput) categoryInput);
            var organisations = mapper.Map<CdcsOrganisationsInput, OrganisationsInput>((CdcsOrganisationsInput) organisationInput);

            Check_ForeignKeys(organisations);

            int nbOfChanges = SaveOrganisationsToDb(organisations, categories);
        }

        private static void Check_ForeignKeys(OrganisationsInput organisations) {
            var missingName = new BilingualItem("Missing", "Missing");

            //TODO: add unknown missing foreign keys

            // Accreditations
            List<int>           idAcs              = organisations.Accreditors.Select(x => x.Id).ToList();
            List<Accreditation> missingAccreditors = organisations.Accreditations.FindAll(x => x.AccreditorId == 0 || !idAcs.Contains(x.AccreditorId));
            var                 missingAccreditor  = new Accreditor { Id = 999999, Name = missingName };
            missingAccreditors.ForEach(x => x.Accreditor = missingAccreditor);

            // organisations.Accreditations.RemoveAll(x => x.AccreditorId == 0 || !idAcs.Contains(x.AccreditorId));

            // Organisations
            List<int>          idLss              = organisations.OrganisationLegalStatuses.Select(x => x.Id).ToList();
            var                missingLegalStatus = new OrganisationLegalStatus { Id = 999999, Name = missingName };
            List<Organisation> missingStatuses    = organisations.Organisations.FindAll(x => x.LegalStatusId == 0 || !idLss.Contains(x.LegalStatusId));
            missingStatuses.ForEach(x => x.LegalStatus = missingLegalStatus);

            // organisations.Organisations.RemoveAll(x => x.LegalStatusId == 0 || !idLss.Contains(x.LegalStatusId));
        }

        private static IList<T> GetCdcsObjectByType<T>(IEnumerable<IBaseEntity> cdcs_objects) where T : IBaseEntity {
            return cdcs_objects.OfType<T>().ToList();
        }

        private static int SaveOrganisationsToDb(OrganisationsInput organisations, CategoriesInput categories) {
            var changes = 0;

            using (var context = new CdcsContext()) {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Organisations.AddRange(organisations.Organisations);
                context.Accreditors.AddRange(organisations.Accreditors);
                context.Accreditations.AddRange(organisations.Accreditations);
                context.ContactModes.AddRange(organisations.ContactModes);
                context.GeographicalZones.AddRange(organisations.GeographicalZones);
                context.OrganisationLanguages.AddRange(organisations.OrganisationLanguages);
                context.OrganisationLegalStatuses.AddRange(organisations.OrganisationLegalStatuses);
                context.Languages.AddRange(organisations.Languages);

                context.Sectors.AddRange(categories.Sectors);
                context.Topics.AddRange(categories.Topics);
                context.Categories.AddRange(categories.Categories);
                context.SectorCategoriesHierarchies.AddRange(categories.SectorCategoriesHierarchies);

                changes = context.SaveChanges();
            }

            return changes;
        }
    }

}