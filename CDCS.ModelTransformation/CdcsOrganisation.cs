#region

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using CDCS.ModelTransformation.Base;

#endregion

namespace CDCS.ModelTransformation
{

    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "updateRequestOrganisation")]
    public class CdcsOrganisation : CdcsEntity
    {
        [XmlElement("FICHE")]
        public int CdcsId { get; set; }

        [XmlElement("INFOR")]
        public string LastUpdate { get; set; }

        [XmlElement("NMOFFNL")]
        public string Name_NL { get; set; }

        [XmlElement("NMOFFFR")]
        public string Name_FR { get; set; }

        [XmlElement("NMUSENL")]
        public List<string> UsedNames_NL { get; set; }

        [XmlElement("NMUSEFR")]
        public List<string> UsedNames_FR { get; set; }

        [XmlElement("NMSERVNL")]
        public List<string> ServiceNames_NL { get; set; }

        [XmlElement("NMSERVFR")]
        public List<string> ServiceNames_FR { get; set; }

        [XmlElement("TEL_NL")]
        public List<string> Phones_NL { get; set; }

        [XmlElement("TEL")]
        public List<string> Phones_FR { get; set; }

        [XmlElement("FAX")]
        public List<string> Faxes_FR { get; set; }

        [XmlElement("EMAIL_NL")]
        public List<string> Emails_NL { get; set; }

        [XmlElement("EMAIL")]
        public List<string> Emails_FR { get; set; }

        [XmlElement("HTTP_NL")]
        public string Website_NL { get; set; }

        [XmlElement("HTTP")]
        public string Website_FR { get; set; }

        [XmlElement("HTTPNL2")]
        public List<string> OtherWebsites_NL { get; set; }

        [XmlElement("HTTP2")]
        public List<string> OtherWebsites_FR { get; set; }

        [XmlElement("URLNL")]
        public List<string> Urls_NL { get; set; }

        [XmlElement("URLFR")]
        public List<string> Urls_FR { get; set; }

        [XmlElement("ACTIVNL")]
        public string Activity_NL { get; set; }

        [XmlElement("ACTIVFR")]
        public string Activity_FR { get; set; }

        [XmlElement("PUBLIEK")]
        public string Public_FR { get; set; }

        [XmlElement("BENEF")]
        public string Public_NL { get; set; }

        [XmlElement("PERMANNL")]
        public string OpeningHours_NL { get; set; }

        [XmlElement("PERMANFR")]
        public string OpeningHours_FR { get; set; }

        [XmlElement("TIJDSCHR")]
        public List<string> Publications_NL { get; set; }

        [XmlElement("REVUE")]
        public List<string> Publications_FR { get; set; }

        [XmlElement("OPMERK")]
        public string Comment_NL { get; set; }

        [XmlElement("REMARQUE")]
        public string Comment_FR { get; set; }

        [XmlElement("PM_RP")]
        public string RegistrationNumber { get; set; }

        [XmlElement("DOEL")]
        public string Mission_NL { get; set; }

        [XmlElement("BUT")]
        public string Mission_FR { get; set; }

        [XmlElement("PUBLIBS")]
        public string OfficialJournalUrl_NL { get; set; }

        [XmlElement("PUBLIMB")]
        public string OfficialJournalUrl_FR { get; set; }

        [XmlElement("BRUSOFR")]
        public string SocialBrusselsUrl_FR { get; set; }

        [XmlElement("BRUSONL")]
        public string SocialBrusselsUrl_NL { get; set; }

        [XmlElement("ERKAND")]
        public List<string> Accreditations_NL { get; set; }

        [XmlElement("AGRAUTR")]
        public List<string> Accreditations_FR { get; set; }

        [XmlElement("OLDNAMNL")]
        public List<string> FormerNames_NL { get; set; }

        [XmlElement("OLDNAMFR")]
        public List<string> FormerNames_FR { get; set; }

        [XmlElement("CREE")]
        public string CreatedBy { get; set; }

        [XmlElement("DEEL", IsNullable = true)]
        public string ParentOrganisationId { get; set; }

        [XmlElement("ANTENNE", IsNullable = true)]
        public string ParentId { get; set; }

        [XmlElement("MOTHER")]
        public string ChildrenIds { get; set; }

        [XmlElement("FAX_NL")]
        public List<string> Faxes_NL { get; set; }

        [XmlElement("INT_SOC")]
        public string UsesInterpreters { get; set; }

        [XmlElement("addresseAdres")]
        public CdcsAddress CdcsAddress { get; set; }

        [XmlElement("statutstatuut")]
        public int LegalStatusId { get; set; }

        [XmlElement("LANGSTAT")]
        public string WorkingLanguage { get; set; }

        [XmlElement("ACCES")]
        public List<string> ContactModes_FR { get; set; }

        [XmlElement("AANMELD")]
        public List<string> ContactModes_NL { get; set; }

        [XmlElement("offrLingTaalAnb")]
        public int[] UsedLanguagesIds { get; set; }

        [XmlElement("natOffreHulpwijz")]
        public int[] ServiceModesIds { get; set; }

        [XmlElement("agrementErken")]
        public int[] AccreditationsIds { get; set; }

        [XmlElement("zoneActionWerkgebied")]
        public int[] GeographicalZonesIds { get; set; }

        [XmlElement("CATEG")]
        public int[] CategoriesIds { get; set; }
    }

}