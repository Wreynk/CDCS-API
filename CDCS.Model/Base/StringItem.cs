#region

using TLT.BaseModel.Model;

#endregion

namespace CDCS.Model.Base {

    #region Base

    public interface IStringItem {
        string       TextValue    { get; set; }
        LanguageEnum Language     { get; set; }
        RefTableEnum RefTableEnum { get; set; }
        int          RefId        { get; set; }
    }

    public class OrganisationString : StringItem {
        protected OrganisationString() {}

        protected OrganisationString(string txt)
        {
            TextValue    = txt;
            RefTableEnum = RefTableEnum.ORGANISATION;
        }
    }

    #endregion

    #region String Items

    public class StringItem : BaseEntity {
        protected StringItem() {}

        protected StringItem(string txt)
        {
            TextValue    = txt;
            RefTableEnum = RefTableEnum.TBD;
        }

        public string       TextValue    { get; set; }
        public LanguageEnum Language     { get; set; }
        public RefTableEnum RefTableEnum { get; set; }
        public int          RefId        { get; set; }
    }

    public class String_NL : StringItem {
        protected String_NL() {}

        public String_NL(string txt) : base(txt)
        {
            Language = LanguageEnum.NL;
        }
    }

    #endregion

    #region Category

    public class CategoryString : StringItem {
        protected CategoryString() {}

        protected CategoryString(string txt)
        {
            TextValue    = txt;
            RefTableEnum = RefTableEnum.CATEGORY;
        }
    }

    #region FR

    public class CategoryString_FR : CategoryString {
        public CategoryString_FR() {}

        public CategoryString_FR(string txt) : base(txt)
        {
            Language = LanguageEnum.FR;
        }
    }

    public class Keyword_FR : CategoryString_FR {
        public Keyword_FR() {}
        public Keyword_FR(string txt) : base(txt) {}
    }

    #endregion

    #region NL

    public class CategoryString_NL : CategoryString {
        public CategoryString_NL()
        {
            Language = LanguageEnum.NL;
        }

        public CategoryString_NL(string txt) : base(txt) {}
    }

    public class Keyword_NL : CategoryString_NL {
        public Keyword_NL() {}

        public Keyword_NL(string txt) : base(txt) {}
    }

    #endregion

    #endregion

    #region Organisation

    public class String_FR : StringItem {
        protected String_FR() {}

        public String_FR(string txt) : base(txt)
        {
            Language = LanguageEnum.FR;
        }
    }

    #region FR

    public class OrganisationString_FR : OrganisationString {
        protected OrganisationString_FR() {}

        public OrganisationString_FR(string txt) : base(txt)
        {
            Language = LanguageEnum.FR;
        }
    }

    public class Accreditation_FR : OrganisationString_FR {
        public Accreditation_FR() {}
        public Accreditation_FR(string txt) : base(txt) {}
    }

    public class ContactMode_FR : OrganisationString_FR {
        public ContactMode_FR() {}
        public ContactMode_FR(string txt) : base(txt) {}
    }

    public class Email_FR : OrganisationString_FR {
        public Email_FR() {}
        public Email_FR(string txt) : base(txt) {}
    }

    public class Fax_FR : OrganisationString_FR {
        public Fax_FR() {}
        public Fax_FR(string txt) : base(txt) {}
    }

    public class FormerName_FR : OrganisationString_FR {
        public FormerName_FR() {}
        public FormerName_FR(string txt) : base(txt) {}
    }

    public class OtherWebsite_FR : OrganisationString_FR {
        public OtherWebsite_FR() {}
        public OtherWebsite_FR(string txt) : base(txt) {}
    }

    public class Phone_FR : OrganisationString_FR {
        public Phone_FR() {}
        public Phone_FR(string txt) : base(txt) {}
    }

    public class Publication_FR : OrganisationString_FR {
        public Publication_FR() {}
        public Publication_FR(string txt) : base(txt) {}
    }

    public class ServiceName_FR : OrganisationString_FR {
        public ServiceName_FR() {}
        public ServiceName_FR(string txt) : base(txt) {}
    }

    public class Url_FR : OrganisationString_FR {
        public Url_FR() {}
        public Url_FR(string txt) : base(txt) {}
    }

    public class UsedName_FR : OrganisationString_FR {
        public UsedName_FR() {}
        public UsedName_FR(string txt) : base(txt) {}
    }

    #endregion

    #region NL

    public class OrganisationString_NL : OrganisationString {
        protected OrganisationString_NL() {}

        public OrganisationString_NL(string txt) : base(txt)
        {
            Language = LanguageEnum.NL;
        }
    }

    public class Accreditation_NL : OrganisationString_NL {
        public Accreditation_NL() {}
        public Accreditation_NL(string txt) : base(txt) {}
    }

    public class ContactMode_NL : OrganisationString_NL {
        public ContactMode_NL() {}
        public ContactMode_NL(string txt) : base(txt) {}
    }

    public class Email_NL : OrganisationString_NL {
        public Email_NL() {}
        public Email_NL(string txt) : base(txt) {}
    }

    public class Fax_NL : OrganisationString_NL {
        public Fax_NL() {}
        public Fax_NL(string txt) : base(txt) {}
    }

    public class FormerName_NL : OrganisationString_NL {
        public FormerName_NL() {}
        public FormerName_NL(string txt) : base(txt) {}
    }

    public class OtherWebsite_NL : OrganisationString_NL {
        public OtherWebsite_NL() {}
        public OtherWebsite_NL(string txt) : base(txt) {}
    }

    public class Phone_NL : OrganisationString_NL {
        public Phone_NL() {}
        public Phone_NL(string txt) : base(txt) {}
    }

    public class Publication_NL : OrganisationString_NL {
        public Publication_NL() {}
        public Publication_NL(string txt) : base(txt) {}
    }

    public class ServiceName_NL : OrganisationString_NL {
        public ServiceName_NL() {}
        public ServiceName_NL(string txt) : base(txt) {}
    }

    public class Url_NL : OrganisationString_NL {
        public Url_NL() {}
        public Url_NL(string txt) : base(txt) {}
    }

    public class UsedName_NL : OrganisationString_NL {
        public UsedName_NL() {}
        public UsedName_NL(string txt) : base(txt) {}
    }

    #endregion

    #endregion

}