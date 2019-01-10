#region

using System;
using AutoMapper;
using CDCS.Model.Base;
using CDCS.Model.Domain;
using CDCS.ModelTransformation;
using CDCS.ModelTransformation.Base;
using TLT.BaseModel.Base;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Model.Profiles {

    public class CdcsProfile : Profile {
        public CdcsProfile()
        {
            #region Base

            // Category strings
            CreateMap<string, Keyword_FR>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, Keyword_NL>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());

            // Organisation strings
            CreateMap<string, Accreditation_FR>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, ContactMode_FR>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, Email_FR>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, Fax_FR>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, FormerName_FR>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, OtherWebsite_FR>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, Phone_FR>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, Publication_FR>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, ServiceName_FR>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, Url_FR>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, UsedName_FR>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, Accreditation_NL>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, ContactMode_NL>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, Email_NL>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, Fax_NL>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, FormerName_NL>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, OtherWebsite_NL>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, Phone_NL>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, Publication_NL>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, ServiceName_NL>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, Url_NL>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());
            CreateMap<string, UsedName_NL>().ForCtorParam("txt", o => o.MapFrom(src => src.Trim())).ForAllOtherMembers(o => o.Ignore());

            // Helpers
            CreateMap<int[], string>().ConvertUsing<IntArray_To_JoinedStringConverter>();
            CreateMap<string, int?>().ConvertUsing<String_To_NullableIntConverter>();
            CreateMap<string, double?>().ConvertUsing<String_To_NullableDoubleConverter>();
            CreateMap<string, DateTime?>().ConvertUsing<String_To_NullableDateTimeConverter>();
            CreateMap<string, LanguageEnum>().ConvertUsing<String_To_LanguageEnumConverter>();

            CreateMap<CdcsEntity, BaseEntity>()

                // Organisations
                .Include<CdcsOrganisation, Organisation>()
                .Include<CdcsAccreditation, Accreditation>()
                .Include<CdcsAccreditor, Accreditor>()
                .Include<CdcsContactMode, ContactMode>()
                .Include<CdcsGeographicalZone, GeographicalZone>()
                .Include<CdcsLanguage, Language>()
                .Include<CdcsOrganisationLanguage, OrganisationLanguage>()
                .Include<CdcsOrganisationLegalStatus, OrganisationLegalStatus>()

                // Categories
                .Include<CdcsCategory, Category>()
                .Include<CdcsSector, Sector>()
                .Include<CdcsSectorCategoriesHierarchy, SectorCategoriesHierarchy>()
                .Include<CdcsTopic, Topic>()

                // Rest
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForAllOtherMembers(opt => opt.Ignore())
                ;

            #endregion

            #region Organisations

            CreateMap<CdcsOrganisationsInput, OrganisationsInput>();

            CreateMap<CdcsAddress, Address>()
                .ForMember(d => d.Co, m => m.MapFrom(src => new BilingualItem(src.Co_FR, src.Co_NL)))
                .ForMember(d => d.Street, m => m.MapFrom(src => new BilingualItem(src.Street_FR, src.Street_NL)))
                .ForMember(d => d.City, m => m.MapFrom(src => new BilingualItem(src.City_FR, src.City_NL)))
                .ForMember(d => d.MonitoringDistrict, m => m.MapFrom(src => new BilingualItem(src.MonitoringDistrict_FR, src.MonitoringDistrict_NL)))
                .ForMember(d => d.StatisticDistrict, m => m.MapFrom(src => new BilingualItem(src.StatisticDistrict_FR, src.MonitoringDistrict_NL)))
                ;

            CreateMap<CdcsOrganisation, Organisation>()
                .ForMember(d => d.Id, m => m.MapFrom(src => src.CdcsId))
                .ForMember(d => d.Name, m => m.MapFrom(src => new BilingualItem(src.Name_FR, src.Name_NL)))
                .ForMember(d => d.Website, m => m.MapFrom(src => new BilingualItem(src.Name_FR, src.Name_NL)))
                .ForMember(d => d.Activity, m => m.MapFrom(src => new BilingualItem(src.Activity_FR, src.Activity_NL)))
                .ForMember(d => d.Public, m => m.MapFrom(src => new BilingualItem(src.Public_FR, src.Public_NL)))
                .ForMember(d => d.OpeningHours, m => m.MapFrom(src => new BilingualItem(src.OpeningHours_FR, src.OpeningHours_NL)))
                .ForMember(d => d.Comment, m => m.MapFrom(src => new BilingualItem(src.Comment_FR, src.Comment_NL)))
                .ForMember(d => d.Mission, m => m.MapFrom(src => new BilingualItem(src.Mission_FR, src.Mission_NL)))
                .ForMember(d => d.OfficialJournalUrl, m => m.MapFrom(src => new BilingualItem(src.Name_FR, src.Name_NL)))
                .ForMember(d => d.SocialBrusselsUrl, m => m.MapFrom(src => new BilingualItem(src.OfficialJournalUrl_FR, src.OfficialJournalUrl_NL)))
                .ForMember(d => d.Address, m => m.MapFrom(src => src.CdcsAddress))
                .ForMember(d => d.UsesInterpreters, m => m.MapFrom(src => src.UsesInterpreters == "OUI"))
                .ForMember(d => d.LegalStatus, opt => opt.Ignore())
                ;

            CreateMap<CdcsAccreditation, Accreditation>()
                .ForMember(d => d.Name, m => m.MapFrom(src => new BilingualItem(src.CdcsTextItems[0].Text, src.CdcsTextItems[1].Text)))
                .ForMember(d => d.Accreditor, opt => opt.Ignore())
                ;

            CreateMap<CdcsAccreditor, Accreditor>()
                .ForMember(d => d.Name, m => m.MapFrom(src => new BilingualItem(src.CdcsTextItems[0].Text, src.CdcsTextItems[1].Text)))
                .ForMember(d => d.Accreditations, opt => opt.Ignore())
                ;

            CreateMap<CdcsContactMode, ContactMode>()
                .ForMember(d => d.Name, m => m.MapFrom(src => new BilingualItem(src.CdcsTextItems[0].Text, src.CdcsTextItems[1].Text)))
                ;

            CreateMap<CdcsGeographicalZone, GeographicalZone>()
                .ForMember(d => d.Name, m => m.MapFrom(src => new BilingualItem(src.CdcsTextItems[0].Text, src.CdcsTextItems[1].Text)))
                ;

            CreateMap<CdcsLanguage, Language>()
                .ForMember(d => d.Name, m => m.MapFrom(src => new BilingualItem(src.CdcsTextItems[0].Text, src.CdcsTextItems[1].Text)))
                ;

            CreateMap<CdcsOrganisationLanguage, OrganisationLanguage>()
                .ForMember(d => d.Name, m => m.MapFrom(src => new BilingualItem(src.CdcsTextItems[0].Text, src.CdcsTextItems[1].Text)))
                ;

            CreateMap<CdcsOrganisationLegalStatus, OrganisationLegalStatus>()
                .ForMember(d => d.Name, m => m.MapFrom(src => new BilingualItem(src.CdcsTextItems[0].Text, src.CdcsTextItems[1].Text)))
                .ForMember(d => d.Organisations, opt => opt.Ignore())
                ;

            #endregion

            #region Categories

            CreateMap<CdcsCategoriesInput, CategoriesInput>()
                .ForMember(d => d.Categories, m => m.MapFrom(src => src.CdcsCategories))
                .ForMember(d => d.Sectors, m => m.MapFrom(src => src.CdcsSectors))
                .ForMember(d => d.SectorCategoriesHierarchies, m => m.MapFrom(src => src.CdcsSectorCategoriesHierarchies))
                .ForMember(d => d.Topics, m => m.MapFrom(src => src.CdcsTopics))
                .ForAllOtherMembers(opt => opt.Ignore())
                ;

            CreateMap<CdcsCategory, Category>()
                .ForMember(d => d.Name, m => m.MapFrom(src => new BilingualItem(src.Name_FR, src.Name_NL)))
                .ForMember(d => d.Description, m => m.MapFrom(src => new BilingualItem(src.Description_FR, src.Description_NL)))
                .ForMember(d => d.Website, m => m.MapFrom(src => new BilingualItem(src.Website_FR, src.Website_NL)))
                .ForMember(d => d.SectorCategoriesHierarchies, opt => opt.Ignore())
                ;

            CreateMap<CdcsSector, Sector>()
                .ForMember(d => d.Name, m => m.MapFrom(src => new BilingualItem(src.Name_FR, src.Name_NL)))
                .ForMember(d => d.Description, m => m.MapFrom(src => new BilingualItem(src.Description_FR, src.Description_NL)))
                .ForMember(d => d.SectorCategoriesHierarchies, opt => opt.Ignore())
                ;

            CreateMap<CdcsSectorCategoriesHierarchy, SectorCategoriesHierarchy>()
                .ForMember(d => d.Category, opt => opt.Ignore())
                .ForMember(d => d.Sector, opt => opt.Ignore())
                .ForMember(d => d.Topic1, opt => opt.Ignore())
                .ForMember(d => d.Topic2, opt => opt.Ignore())
                .ForMember(d => d.Topic3, opt => opt.Ignore())
                .ForMember(d => d.Topic4, opt => opt.Ignore())
                ;

            CreateMap<CdcsTopic, Topic>()
                .ForMember(d => d.Name, m => m.MapFrom(src => new BilingualItem(src.Name_FR, src.Name_NL)))
                .ForMember(d => d.Topic1_SectorCategoriesHierarchies, opt => opt.Ignore())
                .ForMember(d => d.Topic2_SectorCategoriesHierarchies, opt => opt.Ignore())
                .ForMember(d => d.Topic3_SectorCategoriesHierarchies, opt => opt.Ignore())
                .ForMember(d => d.Topic4_SectorCategoriesHierarchies, opt => opt.Ignore())
                ;

            #endregion
        }
    }

}