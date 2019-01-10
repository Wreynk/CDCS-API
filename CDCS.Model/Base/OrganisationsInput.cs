#region

using System.Collections.Generic;
using CDCS.Model.Domain;

#endregion

namespace CDCS.Model.Base {

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.

    public class OrganisationsInput {
        public List<Accreditation>           Accreditations            { get; set; }
        public List<Accreditor>              Accreditors               { get; set; }
        public List<ContactMode>             ContactModes              { get; set; }
        public List<GeographicalZone>        GeographicalZones         { get; set; }
        public List<Language>                Languages                 { get; set; }
        public List<Organisation>            Organisations             { get; set; }
        public List<OrganisationLanguage>    OrganisationLanguages     { get; set; }
        public List<OrganisationLegalStatus> OrganisationLegalStatuses { get; set; }
    }

}