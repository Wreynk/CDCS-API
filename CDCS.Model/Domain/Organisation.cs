#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using CDCS.Model.Base;
using TLT.BaseModel.Base;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Model.Domain {

    public class Organisation : BaseEntity {
        public Address       Address              { get; set; }
        public BilingualItem Activity             { get; set; }
        public BilingualItem Comment              { get; set; }
        public BilingualItem Mission              { get; set; }
        public BilingualItem Name                 { get; set; }
        public BilingualItem OfficialJournalUrl   { get; set; }
        public BilingualItem OpeningHours         { get; set; }
        public BilingualItem Public               { get; set; }
        public BilingualItem SocialBrusselsUrl    { get; set; }
        public BilingualItem Website              { get; set; }
        public int          LegalStatusId        { get; set; }
        public int?          ParentId             { get; set; }
        public int?          ParentOrganisationId { get; set; }
        public string        AccreditationsIds    { get; set; }
        public string        CategoriesIds        { get; set; }
        public string        ChildrenIds          { get; set; }
        public string        GeographicalZonesIds { get; set; }
        public DateTime      LastUpdate           { get; set; }
        public string        RegistrationNumber   { get; set; }
        public string        ServiceModesIds      { get; set; }
        public string        UsedLanguagesIds     { get; set; }
        public bool          UsesInterpreters     { get; set; }
        public LanguageEnum  WorkingLanguage      { get; set; }

        // Collections
        public virtual ICollection<Accreditation_FR> Accreditations_FR { get; set; }
        public virtual ICollection<ContactMode_FR>   ContactModes_FR   { get; set; }
        public virtual ICollection<Email_FR>         Emails_FR         { get; set; }
        public virtual ICollection<Fax_FR>           Faxes_FR          { get; set; }
        public virtual ICollection<FormerName_FR>    FormerNames_FR    { get; set; }
        public virtual ICollection<OtherWebsite_FR>  OtherWebsites_FR  { get; set; }
        public virtual ICollection<Phone_FR>         Phones_FR         { get; set; }
        public virtual ICollection<Publication_FR>   Publications_FR   { get; set; }
        public virtual ICollection<ServiceName_FR>   ServiceNames_FR   { get; set; }
        public virtual ICollection<Url_FR>           Urls_FR           { get; set; }
        public virtual ICollection<UsedName_FR>      UsedNames_FR      { get; set; }
        public virtual ICollection<Accreditation_NL> Accreditations_NL { get; set; }
        public virtual ICollection<ContactMode_NL>   ContactModes_NL   { get; set; }
        public virtual ICollection<Email_NL>         Emails_NL         { get; set; }
        public virtual ICollection<Fax_NL>           Faxes_NL          { get; set; }
        public virtual ICollection<FormerName_NL>    FormerNames_NL    { get; set; }
        public virtual ICollection<OtherWebsite_NL>  OtherWebsites_NL  { get; set; }
        public virtual ICollection<Phone_NL>         Phones_NL         { get; set; }
        public virtual ICollection<Publication_NL>   Publications_NL   { get; set; }
        public virtual ICollection<ServiceName_NL>   ServiceNames_NL   { get; set; }
        public virtual ICollection<Url_NL>           Urls_NL           { get; set; }
        public virtual ICollection<UsedName_NL>      UsedNames_NL      { get; set; }

        public virtual OrganisationLegalStatus LegalStatus { get; set; }

        // [NotMapped]
        // public virtual Organisation Parent { get; set; }
        //
        // [NotMapped]
        // public virtual Organisation ParentOrganisation { get; set; }
    }

}