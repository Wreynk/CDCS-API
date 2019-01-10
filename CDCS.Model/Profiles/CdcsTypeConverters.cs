#region

using System;
using System.Linq;
using AutoMapper;
using CDCS.Model.Base;

#endregion

namespace CDCS.Model.Profiles {

    #region TypeConverters

    public class StringToStringItemFrConverter : ITypeConverter<string, String_FR> {
        public String_FR Convert(string source, String_FR destination, ResolutionContext context) {
            return new String_FR(source.Trim());
        }
    }

    public class StringToStringItemNlConverter : ITypeConverter<string, String_NL> {
        public String_NL Convert(string source, String_NL destination, ResolutionContext context) {
            return new String_NL(source.Trim());
        }
    }

    public class StringToOrganisationStringItemFrConverter : ITypeConverter<string, OrganisationString_FR> {
        public OrganisationString_FR Convert(string source, OrganisationString_FR destination, ResolutionContext context) {
            return new OrganisationString_FR(source.Trim());
        }
    }

    public class StringToOrganisationStringItemNlConverter : ITypeConverter<string, OrganisationString_NL> {
        public OrganisationString_NL Convert(string source, OrganisationString_NL destination, ResolutionContext context) {
            return new OrganisationString_NL(source.Trim());
        }
    }

    public class StringToCategoryStringItemFrConverter : ITypeConverter<string, CategoryString_FR> {
        public CategoryString_FR Convert(string source, CategoryString_FR destination, ResolutionContext context) {
            return new CategoryString_FR(source.Trim());
        }
    }

    public class StringToCategoryStringItemNlConverter : ITypeConverter<string, CategoryString_NL> {
        public CategoryString_NL Convert(string source, CategoryString_NL destination, ResolutionContext context) {
            return new CategoryString_NL(source.Trim());
        }
    }

    public class IntArray_To_JoinedStringConverter : ITypeConverter<int[], string> {
        public string Convert(int[] source, string destination, ResolutionContext context) {
            return source != null ? string.Join(",", source.Select(x => x.ToString())) : "";
        }
    }

    public class String_To_NullableIntConverter : ITypeConverter<string, int?> {
        public int? Convert(string source, int? destination, ResolutionContext context) {
            return int.TryParse(source, out int i) ? (int?) i : null;
        }
    }

    public class String_To_NullableDoubleConverter : ITypeConverter<string, double?> {
        public double? Convert(string source, double? destination, ResolutionContext context) {
            return double.TryParse(source, out double i) ? (double?) i : null;
        }
    }

    public class String_To_NullableDateTimeConverter : ITypeConverter<string, DateTime?> {
        public DateTime? Convert(string source, DateTime? destination, ResolutionContext context) {
            return DateTime.TryParse(source, out var d) ? d : new DateTime(1901, 01, 01);
        }
    }

    public class String_To_LanguageEnumConverter : ITypeConverter<string, LanguageEnum> {
        public LanguageEnum Convert(string source, LanguageEnum destination, ResolutionContext context) {
            switch (source) {
                case "FR":
                    return LanguageEnum.FR;
                case "NL":
                    return LanguageEnum.NL;
                case "FR-NL":
                    return LanguageEnum.FR_NL;
                default:
                    return LanguageEnum.FR;
            }
        }
    }

    public class String_To_IntConverter : ITypeConverter<string, int> {
        public int Convert(string source, int destination, ResolutionContext context) {
            return int.Parse(source);
        }
    }

    /*
    public class StringToKeyword_FRConverter : ITypeConverter<string, Keyword_FR> {
        public Keyword_FR Convert(string source, Keyword_FR destination, ResolutionContext context) {
            return (Keyword_FR) new CategoriesString_FR(source.Trim());
        }
    }
    public class StringToKeyword_NLConverter : ITypeConverter<string, Keyword_NL> {
        public Keyword_NL Convert(string source, Keyword_NL destination, ResolutionContext context) {
            return (Keyword_NL) new CategoriesString_NL(source.Trim());
        }
    }
    */

    #endregion

}