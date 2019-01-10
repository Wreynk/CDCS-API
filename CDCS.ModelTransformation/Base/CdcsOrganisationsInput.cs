#region

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

#endregion

namespace CDCS.ModelTransformation.Base {

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.

    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName   = "updateRequest")]
    public class CdcsOrganisationsInput {
        [XmlArray("organisationList")]
        [XmlArrayItem("organisation", IsNullable = false)]
        public List<CdcsOrganisation> Organisations { get; set; }

        [XmlArray("LangStatList")]
        [XmlArrayItem("LangStat", IsNullable = false)]
        public List<CdcsOrganisationLanguage> OrganisationLanguages { get; set; }

        [XmlArrayItem("natOffreHulpwijz", IsNullable = false)]
        [XmlArray("natOffreHulpwijzList")]
        public List<CdcsContactMode> ContactModes { get; set; }

        [XmlArrayItem("offrLingTaal", IsNullable = false)]
        [XmlArray("offrLingTaalList")]
        public List<CdcsLanguage> Languages { get; set; }

        [XmlArrayItem("StatutStatuut", IsNullable = false)]
        [XmlArray("StatutStatuutList")]
        public List<CdcsOrganisationLegalStatus> OrganisationLegalStatuses { get; set; }

        [XmlArrayItem("zoneActionWerkgebied", IsNullable = false)]
        [XmlArray("zoneActionWerkgebiedList")]
        public List<CdcsGeographicalZone> GeographicalZones { get; set; }

        [XmlArrayItem("pouvoirAgreantErkenning", IsNullable = false)]
        [XmlArray("pouvoirAgreantErkenningList")]
        public List<CdcsAccreditor> Accreditors { get; set; }

        [XmlArrayItem("agrementErken", IsNullable = false)]
        [XmlArray("agrementErkenList")]
        public List<CdcsAccreditation> Accreditations { get; set; }
    }

}