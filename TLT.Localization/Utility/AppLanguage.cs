namespace TLT.Localization.Utility {

    public static class AppLanguage {

        private const string NL_BE = "nl-BE";
        private const string FR_BE = "fr-FR";

        private static string Culture { get; set; }

        public static bool IsNL => Culture == NL_BE;

        public static string LocalizeProperty(string strNl, string strFr)
        {
            return Culture == NL_BE
                ? (string.IsNullOrWhiteSpace(strNl) ? strFr : strNl)
                : strFr;
        }

    }

}