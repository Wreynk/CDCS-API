#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using CDCS.ModelTransformation.Base;

#endregion

namespace CDCS.ModelTransformation {

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName   = "updateRequestRowCategory")]
    public class CdcsCategory : CdcsEntity {
        [XmlElement("denomination")]
        public string Name_FR { get; set; }

        [XmlElement("benaming")]
        public string Name_NL { get; set; }

        [XmlElement("description")]
        public string Description_FR { get; set; }

        [XmlElement("beschrijving")]
        public string Description_NL { get; set; }

        [XmlElement("urlFr")]
        public string Website_FR { get; set; }

        [XmlElement("urlNl")]
        public string Website_NL { get; set; }

        [XmlElement("motcle")]
        public List<string> Keywords_FR { get; set; }

        [XmlElement("trefwoord")]
        public List<string> Keywords_NL { get; set; }

        [XmlElement("rowCategoryLinked")]
        public int[] LinkCategoriesIds { get; set; }
    }

}